using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using static System.Data.SqlClient.SqlConnection;
using System.Data;
using System.Collections.Generic;

namespace DCLS
{
    public class AccessDatabase
    {
      
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Elmer\\Documents\\College 3 Files\\First Semester\\26315 Event-Driven Programming\\Output\\07 Laboratory Exercise & Performance Task 1\\Reniels Version\\DCLS\\Database.mdf\";Integrated Security=True";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Visual Studio Workshop\\3rd Year 1st Semester\\DCLS\\DCLS\\Database.mdf\";Integrated Security=True";
        DataTable dataTable = new DataTable();
        string query;

        public AccessDatabase(string query)
        {

            this.query = query;

        }
         
        // can return a datatable if the query has select or view function
        public DataTable executeDatabaseQuery()
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
              
                adapter.Fill(dataTable);

            }
            catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message);
            
            }

          return dataTable;

        }

    }
}
