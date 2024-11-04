using CRUD_Estudante.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Estudante.Service
{
    public class EstudanteService
    {
        private readonly EstudanteRepository repository;

        public EstudanteService(IConfiguration config)
        {
            repository = new EstudanteRepository(config);
        }

        public void Adicionar(Estudante estudante)
        {
            repository.Adicionar(estudante);
        }

        public List<Estudante> Listar()
        {
            return repository.Listar();
        }
    }
}
