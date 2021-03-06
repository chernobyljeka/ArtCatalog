﻿using System.Windows.Forms;

namespace ArtCatalog
{
    public class CreateDataGrid 
    {

        protected DataGridView dt; // Свойство типа DataGridView

        public DataGridView GetDTObject
         {
            get { return this.dt; }
         }

        // Конструктор класса 
        public CreateDataGrid(Panel DataGridPanel) 
        {
            dt = new DataGridView();
            this.SetProperty();
            this.AddColums();
            DataGridPanel.Controls.Add(dt); // Размещение дата грида на форме
        }

        //Задание свойств дата грида
        private void SetProperty()
        {
            dt.Dock = DockStyle.Fill;
            dt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt.ReadOnly = true;
            dt.AllowUserToDeleteRows = false;
            dt.AllowUserToOrderColumns = true;
            dt.AllowUserToResizeColumns = true;
            dt.AllowUserToAddRows = false;
            dt.RowHeadersVisible = false;
            dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        // Добавление столбцов
        protected virtual void AddColums()
        {
            dt.Columns.Add("ID_product", "№");
            dt.Columns["ID_product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dt.Columns.Add("Name", "Наименование");
            dt.Columns.Add("Discription", "Описание");
            dt.Columns.Add("Count", "Колличество");
            dt.Columns.Add("Price", "Цена");
        }

        public string getData(int columIndex)
        {   try
            {
                var currentIndex = dt.CurrentCell.RowIndex;
                return this.dt.Rows[currentIndex].Cells[columIndex].Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        public void RemoveCurrentRow()
        {
            try
            {
                dt.Rows.Remove(dt.CurrentRow);               
            }
            catch
            {
               
            }
        }

        public virtual void ClearData()
        {
            dt.Rows.Clear();
        }

    }
}
