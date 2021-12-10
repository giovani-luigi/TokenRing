using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TokenRingDemo.Protocol
{
    public class Server : IDisposable {
        
        public event EventHandler<DataReceivedEventArgs> DataReceived;

        private readonly Socket _socket;
        private readonly CancellationTokenSource _cancellationSource;

        private Socket _connectedClient;

        public Server(EndPoint localEndPoint) {
            _cancellationSource = new CancellationTokenSource();
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _socket.Bind(localEndPoint);
        }

        public void Open() {
            
            _socket.Listen(1);

            var cancel = _cancellationSource.Token;
            var listenerThread = new Thread(() => {
                
                
                try {
                    _connectedClient = _socket.Accept();
                    Debug.WriteLine($"Server at {_socket.LocalEndPoint} Accepted connection with client at {_connectedClient.RemoteEndPoint}");
                } catch (ObjectDisposedException) { // socket closed
                    return;
                }
                
                while (!cancel.IsCancellationRequested) {

                    byte[] buffer = new byte[1024];
                    string data = string.Empty;

                    do {
                        int receivedBytes = 0;
                        try {
                            receivedBytes = _connectedClient.Receive(buffer);
                        } catch (ObjectDisposedException) {
                            return; // socket closed
                        } catch (SocketException) {
                            return; // socket closed
                        }
                        data += Encoding.ASCII.GetString(buffer, 0, receivedBytes);
                        
                    } while (data.IndexOf("<EOF>", StringComparison.Ordinal) == -1);
                    
                    Debug.WriteLine($"[{_socket.LocalEndPoint}] Received: {data}");
                    DataReceived?.Invoke(this, new DataReceivedEventArgs(_connectedClient.RemoteEndPoint, data));
                    
                }
            });
            listenerThread.Start();
        }

        public void Send(string message) {
            try {
                _socket.Send(Encoding.ASCII.GetBytes(message));
            } catch (SocketException) {
                return; // socket closed
            }
        }

        #region IDisposable

        /// <inheritdoc />
        public void Dispose() {
            _cancellationSource.Cancel();
            _connectedClient?.Dispose();
            _socket.Dispose();
            _socket.Close();
            _socket?.Dispose();
        }

        #endregion
    }
}
