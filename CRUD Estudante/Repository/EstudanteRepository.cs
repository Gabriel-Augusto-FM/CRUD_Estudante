using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Estudante.Repository
{
    public class EstudanteRepository
    {
        public string ConnectionString { get;  set; }

        public EstudanteRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("DefaultConnection");

        }
        public void Adicionar(Estudante estudante)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Estudante>(estudante);
        }

        public List<Estudante> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            List<Estudante> lista = connection.GetAll<Estudante>().ToList();
            return lista;
        }
    }
}
