using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace TokenRingDemo.Protocol
{
    public class Client : IDisposable {

        public event EventHandler<DataReceivedEventArgs> DataReceived;

        private readonly EndPoint _remoteEndPoint;
        private readonly Socket _socket;
        private readonly CancellationTokenSource _cancellationSource;
        
        public Client(EndPoint remoteEndPoint) {
            _remoteEndPoint = remoteEndPoint;
            _cancellationSource = new CancellationTokenSource();
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Open() {

            _socket.Connect(_remoteEndPoint);
            Debug.WriteLine($"Client connected to: {_remoteEndPoint}");

            var cancel = _cancellationSource.Token;
            var listenerThread = new Thread(() => {
                
                byte[] buffer = new byte[1024];
                string data = string.Empty;

                while (!cancel.IsCancellationRequested) {

                    do {
                        int receivedBytes = 0;
                        try {
                            receivedBytes = _socket.Receive(buffer);
                        } catch (SocketException) {
                            return; // socket closed
                        }
                        data += Encoding.ASCII.GetString(buffer, 0, receivedBytes);
                    } while (data.IndexOf("<EOF>", StringComparison.Ordinal) == -1);

                    Debug.WriteLine($"[{_socket.LocalEndPoint}] Received: {data}");
                    DataReceived?.Invoke(this, new DataReceivedEventArgs(_socket.RemoteEndPoint, data));

                }
            });
            listenerThread.Start();

        }

        public void Send(string payload) {
            try {
                _socket.Send(Encoding.ASCII.GetBytes(payload + "<EOF>"));
            } catch (SocketException) {
                return; // socket closed
            }
        }

        #region IDisposable


        #endregion

        #region IDisposable

        protected virtual void Dispose(bool disposing) {
            if (disposing) {
                _cancellationSource.Cancel();
                _socket.Shutdown(SocketShutdown.Both);
                _socket.Close();
                _socket.Dispose();
            }
        }
        
        /// <inheritdoc />
        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
