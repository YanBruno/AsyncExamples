using AsyncExamples.Entidades.Contratos;

namespace AsyncExamples.Entidades
{
    public class Pessoa
    {
        public string Nome { get; private set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}