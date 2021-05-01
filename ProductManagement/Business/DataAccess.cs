using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    public class DataAccess
    {
        private SqlConnection Connection;
        private SqlCommand Command;

        public SqlDataReader Reader { get; set; }

        ///  BD Connections
        /// Mati  DESKTOP-K54EB4U\\SQLEXPRESS
        /// Doro LAPTOP-J10AEMSB\\SQLEXPRESS

        // 1. Constructor that initializes the connection to DB
        public DataAccess()
        {
            Connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS; Initial Catalog=Catalogo_DB; integrated security=true;");
            Command = new SqlCommand();
        }
        // 2. Set a query to the DB
        public void setQuery(string query)
        {
            Command.CommandType = System.Data.CommandType.Text;
            Command.CommandText = query;
        }
        // 3. Executes the query 
        public void executeQuery()
        {
            Command.Connection = Connection;
            Connection.Open();
            Reader = Command.ExecuteReader();
        }
        // 4. Closes DB connection
        public void closeConnection()
        {
            if (Reader != null)
            {
                Reader.Close();
            }
            Connection.Close();
        }
        // 5. Executes action for Insert, Update and Delete
        internal void executeAction()
        {
            Command.Connection = Connection;
            Connection.Open();
            Command.ExecuteNonQuery();
        }

        public void setParams(string name, object value)
        {
            Command.Parameters.AddWithValue(name, value);
        }

    }
}
