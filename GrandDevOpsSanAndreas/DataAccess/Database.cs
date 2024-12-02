using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandDevOpsSanAndreas.DataAccess
{
    internal class Database
    {
        // ATRIBUTOS
        private string connectionString = "Server=localhost;Database=av2;Uid=root;Pwd=;";

        // MÉTODOS
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
