using System;
using System.Windows.Forms;

namespace ArtCatalog
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Input = false;
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Input = false;
            Application.Exit();
        }
    }
}
