using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TokenRingDemo.GUI;
using TokenRingDemo.Protocol;

namespace TokenRingDemo {
    
    internal class CustomApplicationContext : ApplicationContext {
        
        public int NetworkSize { get; }

        private IEnumerable<Node> _nodes;
        private List<FormNode> _formNodes;

        public CustomApplicationContext(int nodeCount) {
            NetworkSize = nodeCount;
            _formNodes = new List<FormNode>(nodeCount);
            _nodes = NodeFactory.GenerateRingNetwork(nodeCount);
            foreach (var node in _nodes) {
                var form = new FormNode(node);
                _formNodes.Add(form);
                form.Show();
            }

            var formMain = new FormControl(_nodes);
            formMain.FormClosed += FormMainOnFormClosed;
            formMain.Show();

            // organize forms in a circle
            var angles = Enumerable.Range(0, nodeCount).Select(x => (Math.PI * 2 / nodeCount) * x).ToArray();
            var r = Math.Max(_formNodes.First().Width, _formNodes.First().Height) * (1 + Math.Pow(nodeCount, 1.5) / 100);
            var c = new Point(formMain.Location.X + (formMain.Width / 2), formMain.Location.Y + (formMain.Height / 2));
            for (int i = 0; i < nodeCount; i++) {
                int x = (int)(r * Math.Cos(angles[i]) + c.X);
                int y = (int)(r * Math.Sin(angles[i]) + c.Y);
                _formNodes[i].Top = y - (_formNodes[i].Height / 2);
                _formNodes[i].Left = x - (_formNodes[i].Width / 2);
            }

            formMain.BringToFront();
        }

        private void FormMainOnFormClosed(object sender, FormClosedEventArgs e) {
            foreach (var node in _nodes) {
                node.Dispose();
            }
            OnMainFormClosed(this, EventArgs.Empty);
        }
    }
}
