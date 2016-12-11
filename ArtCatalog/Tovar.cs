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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private Product product;

        private void Tovar_Load(object sender, EventArgs e)
        {
            var idSrt = (Owner as MainForm).DT.getData(0);
            int id = Convert.ToInt32(idSrt);
            var db = new Database();
            db.ConStr = Properties.Settings.Default.ConnectionString;
            product = db.getProductByID(id);
            idLabel.Text = id.ToString();
            this.Text = "Карточка товара №:" + id.ToString() + " - " + product.Name;
            title.Text = product.Name;
            discript.Text = product.Discription;
            kol.Text = product.Cont.ToString();
            cost.Text = product.Price.ToString();
            picture.Image = product.Img;
        }
    }
}
