using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Business
{
    class DataAccess
    {
        private SqlConnection Connection;
        private SqlCommand Command;

        public SqlDataReader Reader { get; set; }

        /// <summary>
        ///  Conetion BD
        /// Mati  DESKTOP-K54EB4U\\SQLEXPRESS
        /// Doro LAPTOP-J10AEMSB\\SQLEXPRESS
        /// </summary>
        public DataAccess()
        {
            Connection = new SqlConnection("Data Source=(local)\\SQLEXPRESS; Initial Catalog=Catalogo_DB; integrated security=true;");
            Command = new SqlCommand();
        }
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

    }
}
