﻿using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ArtCatalog
{
    class Database
    {
        public Database()
        {

        }

        private SqlConnection con = new SqlConnection();
        private SqlCommand com = new SqlCommand();

        //Метод реализующий SqlQuery

        public void SqlQuery(string conStr, string sql)
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
        public string SqlQueryScalar(string conStr, string sql)
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

        // Дороботать
        private string isDataTime(string DataTimeStr)
        {
            var date = new DateTime();
            try
            {
                date = Convert.ToDateTime(DataTimeStr);
                return date.ToString("dd/MM/yyyy");
            }
            catch
            {
                return "";
            }
        }

        //Метод реализующий SqlReader
        public void SQLReader(string conStr, string sql, DataGridView dt)
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
                            if (isDataTime(dr[i].ToString()) == "")
                            {
                                dt.Rows[j].Cells[i].Value = dr[i].ToString();
                            }
                            else
                            {
                                dt.Rows[j].Cells[i].Value = isDataTime(dr[i].ToString());
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



    }
}
