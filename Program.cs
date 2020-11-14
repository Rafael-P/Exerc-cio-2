using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite seu ano de nascimento");
            int nascimento = int.Parse(Console.ReadLine());

            int idade = 2020-nascimento;
            Console.WriteLine("Sua idade é "+idade);

            int semanas = idade*52;
            Console.WriteLine("Sua idade em semanas é "+semanas);
            
        }//FIM DO MAIN
    }
}
