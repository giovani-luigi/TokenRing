using System.Collections.Generic;

namespace TokenRingDemo.Protocol
{
    public static class NodeFactory {

        public static IReadOnlyCollection<Node> GenerateRingNetwork(int nodeCount) {

            if (nodeCount <= 0)
                return new List<Node>();

            var nodes = new LinkedList<Node>();

            // create all nodes
            for (int i = 0; i < nodeCount; i++) {
                nodes.AddLast(new Node(i));
            }

            // connect first/last nodes
            nodes.Last.Value.SetNextNode(nodes.First.Value.NodeInfo);

            // connect all nodes
            var node = nodes.First;
            while (node.Next != null) {
                node.Value.SetNextNode(node.Next.Value.NodeInfo);
                node = node.Next;
            }
            
            return nodes;
        }

    }
}
