using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicketSystem.DB_Classes
{
    public class ConexaoDB
    {
        public SqlConnection connection;

        public void conn()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-O4SMKJK\SQLEXPRESS;Failover Partner=DESKTOP-O4SMKJK;Initial Catalog=ticketsystem;Integrated Security=True";
                connection = new SqlConnection(connectionString);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
