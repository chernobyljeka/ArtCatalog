using System;
using System.Threading;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            db.ConStr = Properties.Settings.Default.ConnectionString;
            //var sql = String.Format("SELECT login FROM Persons Where login like '{0}'", LoginTxt.Text);
            //var resault = bd.SqlQueryScalar(sql);

            Program.Input = db.Login(LoginTxt.Text, pasTxt.Text);
            if (Program.Input == true)
            {
                Close();
                Dispose();
            }
            else
            {
                InfoLabel.Text = "Неверный логин или пароль";
            }
            
        }
    }
}
