using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Деловые_дамы1
{
    class Bd
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLOCALDB;Initial Catalog=master;Integrated Security=True";
        public void View(string sql, DataGridView table)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                table.DataSource = ds.Tables[0];
                connection.Close();
            }
        }
        public void command(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    int n = command.ExecuteNonQuery();
                    connection.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show("Ошибка добавления");
                }
            }
        }
    }
}
