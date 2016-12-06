using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtCatalog
{
    public partial class EditProduct : AddProduct
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            var idSrt = (Owner as MainForm).DT.getData(0);
            int id = Convert.ToInt32(idSrt);
            var db = new Database();
            db.ConStr = Properties.Settings.Default.ConnectionString;
            var product = db.getProductByID(id);
            pName.Text = product.Name;
            pDiscript.Text = product.Discription;
            pCount.Value = product.Cont;
            pPrice.Value = product.Price;
            picture.Image = product.Img;
        }
    }
}
