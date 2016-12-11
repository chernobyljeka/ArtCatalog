using System.Windows.Forms;

namespace ArtCatalog
{
    public class DataGridSell : CreateDataGrid
    {
        public DataGridSell(Panel DataGridPanel) : base (DataGridPanel)
        {

        }



        protected override void AddColums()
        {
            base.dt.Columns.Add("ID_sell", "№");
            dt.Columns["ID_sell"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dt.Columns.Add("ID_product", "Товар");
            dt.Columns.Add("ID_person", "Касссир");
            dt.Columns.Add("Date", "Дата продажи");
            dt.Columns.Add("Kol", "Количество");
            dt.Columns.Add("Sum", "Сумма");
        }

        public override void ClearData()
        {
            this.dt.Rows.Clear();
        }


    }
}
