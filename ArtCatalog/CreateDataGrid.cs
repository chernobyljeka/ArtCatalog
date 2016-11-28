using System.Windows.Forms;

namespace ArtCatalog
{
    class CreateDataGrid 
    {

        private DataGridView dt;

        public CreateDataGrid(Panel DataGridPanel)
        {
            dt = new DataGridView();
            this.SetProperty();
            this.AddColums();
            DataGridPanel.Controls.Add(dt);
        }

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
        }

        private void AddColums()
        {
            dt.Columns.Add("ID_product", "№");
            dt.Columns["ID_product"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dt.Columns.Add("Name", "Наименование");
            dt.Columns.Add("Discription", "Описание");
            dt.Columns.Add("Count", "Колличество");
            dt.Columns.Add("Price", "Цена");
        }

        public void ClearData()
        {
            dt.Rows.Clear();
        }

    }
}
