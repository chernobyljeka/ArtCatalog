using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArtCatalog
{
    class Database
    {

        #region "Конструкторы"
        public Database()
        {

        }
        #endregion

        #region "Поля"
        private SqlConnection con = new SqlConnection();
        private SqlCommand com = new SqlCommand();
        private string conStr;
        #endregion

        #region "Свойства"
        public string ConStr
        {
            get { return conStr; }
            set { conStr = value; }
        }

        public SqlCommand Com
        {
            get { return com; }
        }

        #endregion

        //Метод реализующий SqlQuery

        public void SqlQuery(string sql)
        {
            con.ConnectionString = conStr;
            com.Connection = con;
            com.CommandText = sql;
            try
            {
                con.Open();
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                     "В ходе запроса произошла ошибка\n\n" + ex.ToString(),
                     "Ошибка",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error
                    );
            }
            finally
            {
                con.Close();
            }
        }

        //Метод релизующий SqlQueryScalar
        public string SqlQueryScalar(string sql)
        {
            con.ConnectionString = conStr;
            com.Connection = con;
            com.CommandText = sql;
            try
            {
                con.Open();
                return com.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                     "В ходе запроса произошла ошибка\n\n" + ex.ToString(),
                     "Ошибка",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error
                    );
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        // Проверка на возможность преобразвать в DataTime
        private bool isDataTime(string DataTimeStr)
        {
            var date = new DateTime();
            try
            {
                date = Convert.ToDateTime(DataTimeStr);
                return true; 
            }
            catch
            {
                return false;
            }
        }

        // Метод для пребразования строки в Европейский формат даты 
        private string getDataTimeFormat(string DataTimeStr, string DateFormat)
        {
            var date = new DateTime();
            date = Convert.ToDateTime(DataTimeStr);
            return date.ToString(DateFormat);
        }

        //Метод реализующий SqlReader
        public void SQLReader(string sql, DataGridView dt)
        {
            con.ConnectionString = conStr;
            com.Connection = con;
            com.CommandText = sql;
            dt.Rows.Clear();

            try
            {
                con.Open();
                var dr = com.ExecuteReader();
                int j = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dt.Rows.Add();
                        for (int i = 0; i < dr.FieldCount; i++)
                            if (!isDataTime(dr[i].ToString()))
                            {
                                dt.Rows[j].Cells[i].Value = dr[i].ToString();
                            }
                            else
                            {
                                dt.Rows[j].Cells[i].Value = getDataTimeFormat(dr[i].ToString(), "dd/MM/yyyy");
                            }
                        j++;
                    }
                    dr.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                     "В ходе запроса произошла ошибка\n\n" + ex.ToString(),
                     "Ошибка",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error
                    );
            }
            finally
            {
                con.Close();
            }
        }

        // !!!! Реализация полиморфизма
        public void SQLReader(string sql, DataGridView dt, string DataFormat)
        {
            con.ConnectionString = conStr;
            com.Connection = con;
            com.CommandText = sql;
            dt.Rows.Clear();

            try
            {
                con.Open();
                var dr = com.ExecuteReader();
                int j = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dt.Rows.Add();
                        for (int i = 0; i < dr.FieldCount; i++)
                            if (!isDataTime(dr[i].ToString()))
                            {
                                dt.Rows[j].Cells[i].Value = dr[i].ToString();
                            }
                            else
                            {
                                dt.Rows[j].Cells[i].Value = getDataTimeFormat(dr[i].ToString(), DataFormat);
                            }
                        j++;
                    }
                    dr.Close();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(
                     "В ходе запроса произошла ошибка\n\n" + ex.ToString(),
                     "Ошибка",
                     System.Windows.Forms.MessageBoxButtons.OK,
                     System.Windows.Forms.MessageBoxIcon.Error
                    );
            }
            finally
            {
                con.Close();
            }
        }
        
        // Получение продукта по ID
        public Product getProductByID(int id)
        {
            con.ConnectionString = conStr;
            com.Connection = con;
            com.CommandText = String.Format("Select * From Products Where ID_product = {0};", id);
            Product pr = new Product();
            var imgConvert = new ImageConvert();
            
                con.Open();
                var dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        pr.Id = Convert.ToInt32(dr[0]);
                        pr.Name = dr[1].ToString();
                        pr.Discription = dr[2].ToString();
                        pr.Cont = Convert.ToInt32(dr[3]);
                        pr.Price = Convert.ToInt32(dr[4]);

                    if (dr[5] as byte[] != null && (dr[5] as byte[]).Length > 0)
                    {
                        pr.Img = imgConvert.byteArrayToImage(dr[5] as byte[]);
                    }
                    else
                    {
                        pr.Img = Properties.Resources.no_image;
                    }


                    }
                    dr.Close();
                }
                con.Close();
                return pr;
           
         }


    }
}
