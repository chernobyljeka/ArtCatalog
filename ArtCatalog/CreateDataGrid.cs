using System.Windows.Forms;

namespace ArtCatalog
{
    class CreateDataGrid 
    {

        private DataGridView dt;

        public CreateDataGrid(Panel f1)
        {
            dt = new DataGridView();
            dt.Columns.Add("ID_product","№");
            dt.Columns.Add("Name", "Наименование");
            dt.Columns.Add("Discription", "Описание");
            dt.Columns.Add("Count", "Колличество");
            dt.Columns.Add("Price", "Цена");
        }

        private void Set

        public void ClearData()
        {
            dt.Rows.Clear();
        }

    }
}
