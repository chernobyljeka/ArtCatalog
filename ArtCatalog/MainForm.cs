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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private CreateDataGrid dt;
        private DataGridSell dtS;
        public CreateDataGrid DT
        {
           get { return dt; }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            dt = new CreateDataGrid(DataGridPanel); //создание экземляра класса, реализуюшего создание 
            dt.GetDTObject.Name = "DataGridProduct";
            // Создание экземляра класса
            Database db = new Database();
            db.ConStr = Properties.Settings.Default.ConnectionString;
            string sql = "Select  [ID_product], [Name] ,[Discription] ,[Count] ,[Price] From Products";
            // Вызов метода выполнение запроса с возвращением результата в дата грид
            db.SQLReader(sql, dt.GetDTObject);

            dtS = new DataGridSell(SellPanel);
            sql = @"SELECT ID_sell, P.Name, Pr.Name, Date, Sum FROM " +
                   "(Sells as S Inner Join Persons as P ON S.ID_person = P.ID_Person)" +
                   "Inner Join Products as Pr ON S.ID_product= Pr.ID_product;";
            // !!!! Демонстрация полиморфизма
            db.SQLReader(sql, dtS.GetDTObject, "0:MM/dd/yyyy    H:mm");
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addproduct = new AddProduct(){ Owner = this };
            addproduct.ShowDialog();
        }

        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            var about = new AboutProgramm();
            about.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var EditForm = new EditProduct();
            EditForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
