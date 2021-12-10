using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TokenRingDemo.Protocol;

namespace TokenRingDemo.GUI
{
    public partial class FormControl : Form {
        
        private readonly IEnumerable<Node> _nodes;

        public FormControl(IEnumerable<Node> nodes) {
            _nodes = nodes;
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void Button_Start_Click(object sender, System.EventArgs e) {
            Button_Start.Enabled = false;
            _nodes.Last().ForwardToken(); // force last node to send token to first and start the cycle
        }
    }
}
