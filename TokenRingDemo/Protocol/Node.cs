using System;
using System.Net;

namespace TokenRingDemo.Protocol {
    
    // network node
    public class Node : IDisposable {

        public event EventHandler TokenExpired;
        public event EventHandler<TimeSpan> TokenReceived;

        private NodeInfo _nodeThis = null;
        private NodeInfo _nodeNext = null;
        private Server _server = null; // each node is a server, that should be accessed by a client from the previous node
        private TokenClient _client = null; // each node has a client to access the server of the next node
        private TokenVault _tokenVault;

        public EndPoint EndPoint => new IPEndPoint(NetworkAddress, NetworkPort + _nodeThis.NodeId);

        public NodeInfo NodeInfo => _nodeThis;
        
        public IPAddress NetworkAddress { get; } = IPAddress.Parse("127.0.0.1");

        public int NetworkPort { get; } = 2000;

        public TimeSpan TokenTimeout { get; } = TimeSpan.FromSeconds(5);

        public TimeSpan TokenRemainingTime => _tokenVault.RemainingTime;

        public bool HasToken => _tokenVault.HasToken;

        public Node(int nodeId) {
            
            _nodeThis = new NodeInfo(nodeId);
            _tokenVault = new TokenVault();
            _tokenVault.TokenExpired += TokenVaultOnTokenExpired;

            _server = new Server(EndPoint);
            _server.DataReceived += ServerOnDataReceived;
            _server.Open();
        }

        private void TokenVaultOnTokenExpired(object sender, EventArgs e) {
            TokenExpired?.Invoke(this, EventArgs.Empty);
            ForwardToken();
        }
        
        public void SetNextNode(NodeInfo node) {
            _nodeNext = node;
            _client = new TokenClient(new IPEndPoint(NetworkAddress, NetworkPort + _nodeNext.NodeId));
            _client.Open();
        }
        
        private void ServerOnDataReceived(object sender, DataReceivedEventArgs e) {
            if (e.Payload.Equals("Token")) { // received token
                _tokenVault.SetToken(TokenTimeout);
                TokenReceived?.Invoke(this, TokenTimeout);
            }
        }
        
        public void ForwardToken() {
            _client.SendToken();
        }

        public bool TryLockResource() {
            return _tokenVault.TryLockToken();
        }

        public bool TryUnlockResource() {
            return _tokenVault.TryUnlockToken();
        }

        #region IDisposable

        public void Dispose() {
            _server?.Dispose();
            _client?.Dispose();
        }

        #endregion

    }
}
