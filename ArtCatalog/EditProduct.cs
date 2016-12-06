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
            button2.Text = "Применить изменения";
            base.button2.Click -= base.button2_Click;
            base.button2.Click += new System.EventHandler(this.button2_Click);
        }

        private Product product;

        private void EditProduct_Load(object sender, EventArgs e)
        {
            var idSrt = (Owner as MainForm).DT.getData(0);
            int id = Convert.ToInt32(idSrt);
            var db = new Database();
            db.ConStr = Properties.Settings.Default.ConnectionString;
            product = db.getProductByID(id);
            pName.Text = product.Name;
            pDiscript.Text = product.Discription;
            pCount.Value = product.Cont;
            pPrice.Value = product.Price;
            picture.Image = product.Img;
        }
        
       

        protected new void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Database();
                db.ConStr = Properties.Settings.Default.ConnectionString;
                string sql;

                if (filePath.Text != String.Empty)
                {
                    sql = String.Format("UPDATE Products SET " + 
                                        "Name = '{0}', Discription = '{1}', Count = {2}, Price = {3}, Image = @image "+
                                        "where ID_product = {4};",
                                         pName.Text, pDiscript.Text, pCount.Value, pPrice.Value, product.Id);
                    db.Com.Parameters.Add("@image", SqlDbType.VarBinary).Value = imgBytes;
                }
                else
                {
                    sql = String.Format("UPDATE Products SET " +
                                       "Name = '{0}', Discription = '{1}', Count = {2}, Price = {3} "+
                                       "where ID_product = {4};",
                                        pName.Text, pDiscript.Text, pCount.Value, pPrice.Value, product.Id);
                }
                db.SqlQuery(sql);
                System.Windows.Forms.MessageBox.Show(
                     "Товар успешно изменен",
                     "Изменение товара",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Information
                    );

                #region "Добавление в дата грид"

                var dataGrid = (Owner as MainForm).DT.GetDTObject;
                dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[1].Value = pName.Text;
                dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[2].Value = pDiscript.Text;
                dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[3].Value = pCount.Value.ToString();
                dataGrid.Rows[dataGrid.CurrentRow.Index].Cells[4].Value = pPrice.Value.ToString();
                #endregion

                db = null;
                Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                     "Не удалось изменить товар\n\n" + ex.ToString(),
                     "Ошибка",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error
                    );
            }
        }

       
    }
}
