using System;
using System.Net;

namespace TokenRingDemo.Protocol {
    public class DataReceivedEventArgs : EventArgs {
        
        public EndPoint RemoteEndPoint { get; }
        
        public string RawData { get; }

        public string Payload => RawData.Substring(0, RawData.Length - "<EOF>".Length);

        public DataReceivedEventArgs(EndPoint remoteEndPoint, string rawData) {
            RemoteEndPoint = remoteEndPoint;
            RawData = rawData;
        }
    }
}