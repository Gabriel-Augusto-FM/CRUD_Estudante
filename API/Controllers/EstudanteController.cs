using CRUD_Estudante;
using CRUD_Estudante.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class EstudanteController
    {
        private readonly EstudanteService Service;

        public EstudanteController(EstudanteService service, IConfiguration config)
        {

            string _config = config.GetConnectionString("DefaultConnection");
            Service = service;
        }

        [HttpPost("Adicionar")]

        public Estudante AdicionarEstudante()
        {
            return null;
        }
    }
}
