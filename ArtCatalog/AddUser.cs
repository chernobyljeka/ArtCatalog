using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArtCatalog
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pas2_Validating(object sender, CancelEventArgs e)
        {
            if (pas1.Text != pas2.Text)
            {
                MessageBox.Show("Пароли не совпадают",
                                "Валидация формы",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private bool validate()
        {
            foreach (var c in Controls.OfType<TextBox>())
            {
                if (c.Text == String.Empty)
                {
                    MessageBox.Show("Поля не должны быть пустыми",
                               "Валидация формы",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (pas1.Text != pas2.Text)
            {
                MessageBox.Show("Пароли не совпадают",
                                "Валидация формы",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool checkLogin(string login)
        {
            var db = new Database();
            db.ConStr = Properties.Settings.Default.ConnectionString;
            string sql = String.Format("Select login from Persons Where login like '{0}';",
                                        login);
            string res = db.SqlQueryScalar(sql);
             res = db.SqlQueryScalar(sql);
            if (res != String.Empty)
            {
                db = null;
                return false;
            }
            db = null;
            return true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                

                if (checkLogin(login.Text))
                {
                    var md5 = new md5();
                    var db = new Database();
                    db.ConStr = Properties.Settings.Default.ConnectionString;
                    var sql = String.Format(@"Insert Into Persons Values ('{0}', '{1}', '{2}', '{3}', @date, '{4}');",
                                            login.Text,
                                            md5.HashMD5(pas1.Text),
                                            pName.Text,
                                            pSurname.Text,
                                            position.Text);
                    db.Com.Parameters.Add("@date", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                    db.SqlQuery(sql);
                    MessageBox.Show("Пользователь успешно добавлен",
                                   "Добавление пользователя",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Такой логин уже существует",
                                    "Добавление пользователя",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                 
                }
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
