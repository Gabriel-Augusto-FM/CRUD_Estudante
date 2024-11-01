using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Estudante
{
    public static class InicializadorBD
    {
        private const string ConnectionString = "Data Source=Estudante.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Estudantes(
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Idade INT NOT NULL,
                 CPF INT NOT NULL
                );";

                connection.Execute(commandoSQL);
            }
        }
    }
}
    