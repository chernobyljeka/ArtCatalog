using System;
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

        private void AddProduct_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            filePath.Text = openFile.FileName;
            var img = Image.FromFile(filePath.Text);
            picture.Image = img;
            var converter = new ImageConvert();
            byte[] imgBytes = converter.imageToByteArray(img);
        }
    }
}
