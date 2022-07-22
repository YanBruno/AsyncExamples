using AsyncExamples.Entidades;

namespace AsyncExamples.Tarefas
{
    public static class Tarefa
    {
        public static async Task<Ovo> BuscarOvos(Pessoa pessoa)
        {
            Console.WriteLine($"{pessoa.Nome} saiu de casa para buscar ovos");
            await Task.Delay(2000);

            Console.WriteLine($"{pessoa.Nome} chegou no celeiro e está recolhendo os ovos");
            await Task.Delay(5000);

            Console.WriteLine($"{pessoa.Nome} está voltando para casa");
            await Task.Delay(2000);

            Console.WriteLine($"{pessoa.Nome} chegou em casa");
            return new Ovo();
        }
        public static async Task<Farinha> ComprarFarinha(Pessoa pessoa)
        {
            Console.WriteLine($"{pessoa.Nome} saiu de casa para comprar farinha");
            await Task.Delay(5000);

            Console.WriteLine($"{pessoa.Nome} chegou no mercado e está comprando a farinha");
            await Task.Delay(1000);

            Console.WriteLine($"{pessoa.Nome} está voltando para casa");
            await Task.Delay(5000);

            Console.WriteLine($"{pessoa.Nome} chegou em casa");
            return new Farinha();
        }

        public static async Task AguardarIngredientes(Pessoa pessoa)
        {
            Console.WriteLine($"{pessoa.Nome} pediu para buscarem os ingredietnes e está aguardando...");
            await Task.Delay(13000);
            Console.WriteLine($"{pessoa.Nome} terminou de esperar");
        }

        public static async Task<Omelete> CozinharOmelete(Pessoa pessoa, Ovo ovo)
        {
            Console.WriteLine($"{pessoa.Nome} Está preparando o omelete...");
            await Task.Delay(2000);
            Console.WriteLine($"{pessoa.Nome} terminou o omelete");

            return new Omelete();
        }

        public static async Task<Omelete> AssarPao(Pessoa pessoa, Ovo ovo, Farinha farinha)
        {
            Console.WriteLine($"{pessoa.Nome} Está preparando o pão...");
            await Task.Delay(3000);
            Console.WriteLine($"{pessoa.Nome} terminou o pão");

            return new Omelete();
        }

    }
}