using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TokenRingDemo.Protocol;

namespace TokenRingDemo.GUI
{
    public partial class FormNode : Form {
        
        private readonly Node _node;

        public FormNode(Node node) {
            _node = node;
            InitializeComponent();
            TextBox_Id.Text = node.NodeInfo.NodeId.ToString();
            TextBox_TokenStatus.Text = node.HasToken ? "SIM" : "NÃO";
            _node.TokenReceived += NodeOnTokenReceived;
            _node.TokenExpired += NodeOnTokenExpired;
        }
        
        private void FormNode_Load(object sender, EventArgs e) {
            BackColor = Color.FromArgb(255, 242, 242, 242);
            Button_Lock.Enabled = true;
            Button_Unlock.Enabled = false;
        }

        private void NodeOnTokenExpired(object sender, EventArgs e) {
            if (InvokeRequired) {
                BeginInvoke(new Action(() => NodeOnTokenExpired(sender, e)));
                return;
            }
            TimerToken.Stop();
            TextBox_TokenExpireTime.Text = "-";
            TextBox_TokenStatus.BackColor = Color.FromArgb(255, 184, 158, 168);
            TextBox_TokenStatus.Text = "NÃO";
        }

        private void NodeOnTokenReceived(object sender, TimeSpan timeout) {
            if (InvokeRequired) {
                BeginInvoke(new Action(() => NodeOnTokenReceived(sender, timeout)));
                return;
            }
            TimerToken.Start();
            TextBox_TokenStatus.BackColor = Color.FromArgb(255, 175, 203, 203);
            TextBox_TokenStatus.Text = "SIM";
            TextBox_TokenExpireTime.Text = _node.TokenRemainingTime.TotalSeconds.ToString("F0");
        }

        private void Button_Lock_Click(object sender, System.EventArgs e) {
            if (!_node.TryLockResource()) {
                MessageBox.Show("O recurso não pode ser acessado. Este nó não possui o Token para acesso.");
            } else {
                BackColor = Color.SeaGreen;
                Button_Lock.Enabled = false;
                Button_Unlock.Enabled = true;
            }
        }

        private void Button_Unlock_Click(object sender, System.EventArgs e) {
            if (_node.TryUnlockResource()) {
                BackColor = Color.FromArgb(255, 242, 242, 242);
                Button_Lock.Enabled = true;
                Button_Unlock.Enabled = false;
            }
        }

        private void FormNode_FormClosing(object sender, FormClosingEventArgs e) {
            MessageBox.Show("Para fechar o aplicativo, feche a janela de controle");
            e.Cancel = true;
        }

        private void TimerToken_Tick(object sender, EventArgs e) {
            TextBox_TokenExpireTime.Text = _node.TokenRemainingTime.TotalSeconds.ToString("F0");
        }

        
    }
}
