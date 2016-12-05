using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ArtCatalog
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private Image img;  // картинка
        private byte[] imgBytes; // картинка в виде массива байтов

        private void AddProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.ShowDialog(); // Открытие диалога выбора файлов
                filePath.Text = openFile.FileName; // Присваивание TextBox путь к картинке

                img = Image.FromFile(filePath.Text);
                picture.Image = img;
                var converter = new ImageConvert();
                imgBytes = converter.imageToByteArray(img);
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new Database();
                db.ConStr = Properties.Settings.Default.ConnectionString;
                string sql;

                if (filePath.Text != String.Empty)
                {
                    sql = String.Format("INSERT INTO Products (Name, Discription, Count, Price, Image) VALUES (" +
                                 "'{0}', '{1}', {2}, {3}, @image);", pName.Text, pDiscript.Text, pCount.Value, pPrice.Value);
                    db.Com.Parameters.Add("@image", SqlDbType.VarBinary).Value = imgBytes;
                }
                else
                {
                    sql = String.Format("INSERT INTO Products (Name, Discription, Count, Price) VALUES (" +
                                "'{0}', '{1}', {2}, {3});", pName.Text, pDiscript.Text, pCount.Value, pPrice.Value);
                }
                db.SqlQuery(sql);
                System.Windows.Forms.MessageBox.Show(
                     "Товар успешно добавлен",
                     "Добавление товара",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Information
                    );

                #region "Добавление в дата грид"
                    sql = @"Select MAX(ID_product) From Products;";
                    string id = db.SqlQueryScalar(sql);
                    var dataGrid = (Owner as MainForm).DT.GetDTObject;
                    dataGrid.Rows.Add(id, 
                                      pName.Text,
                                      pDiscript.Text,
                                      pCount.Value.ToString(),
                                      pPrice.Value.ToString());
                #endregion

                db = null;
                Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                     "Не удалось добавить товар\n\n" + ex.ToString(),
                     "Ошибка",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error
                    );
            }
        }
    }
}
