namespace CRUD_Estudante
{
    public class Estudante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int CPF { get; set; }

        internal List<Estudante> Listar()
        {
            throw new NotImplementedException();
        }
    }
}