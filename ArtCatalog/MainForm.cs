﻿using System;
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

        private void FillDT()
        {
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            dt = new CreateDataGrid(DataGridPanel); //создание экземляра класса, реализуюшего создание 
            dt.GetDTObject.Name = "DataGridProduct";
            FillDT();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var addproduct = new AddProduct(){ Owner = this };
            addproduct.ShowDialog();
            addproduct.Dispose();
        }

        private void AboutProgramMenu_Click(object sender, EventArgs e)
        {
            var about = new AboutProgramm();
            about.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var EditForm = new EditProduct() { Owner = this }; ;
            EditForm.ShowDialog();
            EditForm.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dt.getData(1) != "")
            {
                var dr = MessageBox.Show(String.Format(@"Действительно хотите удалить продукцию «{0}»", dt.getData(1)),
                                         "Удаление продукциия",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string sql = String.Format("DELETE FROM Sells Where ID_product = {0};" +
                                               "DELETE FROM Products Where ID_product = {0};", dt.getData(0));
                    var db = new Database();
                    db.ConStr = Properties.Settings.Default.ConnectionString;
                    db.SqlQuery(sql);
                    db = null;
                    dt.RemoveCurrentRow();
                }
            }
            else
            {
                MessageBox.Show("Не выбрана продукция из списка",
                                         "Удаление продукциия",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
            }
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void обновитьТаблицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dt.ClearData();
            dtS.ClearData();
            FillDT();
        }
    }
}
