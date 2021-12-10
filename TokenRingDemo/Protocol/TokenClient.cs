using System.Net;

namespace TokenRingDemo.Protocol
{
    internal class TokenClient : Client {
        
        public TokenClient(EndPoint remoteEndPoint) : base(remoteEndPoint) {
        }

        public void SendToken() {
            base.Send("Token");
        }

    }
}
