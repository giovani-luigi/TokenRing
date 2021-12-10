using System.Windows.Forms;

namespace TokenRingDemo.GUI
{
    public partial class FormNewNode : Form {

        public int NodeCount => (int)Nud_Count.Value;

        public bool Start = false;

        public FormNewNode() {
            InitializeComponent();
        }

        private void Button_Iniciar_Click(object sender, System.EventArgs e) {
            Start = true;
            Close();
        }
    }
}
