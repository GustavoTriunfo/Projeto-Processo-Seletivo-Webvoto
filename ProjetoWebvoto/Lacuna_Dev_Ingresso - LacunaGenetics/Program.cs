using Lacuna.Dev.Ingresso.LacunaGenetics.Abstraction;
using Lacuna.Dev.Ingresso.LacunaGenetics.UseCase;

namespace Lacuna.Dev.Ingresso.LacunaGenetics
{
    public class Program 
    {
        static void Main(string[] args)
        {
            IOperationsDNAUseCase program = new OperationsDNAUseCase();
            program.Execute();
            Console.WriteLine("Pressione qualquer tecla para finalizar!!");
            Console.ReadKey();
        }
    }
}