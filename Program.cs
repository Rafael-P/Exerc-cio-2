using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite seu ano de nascimento");
            int nascimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano atual");
            int ano = int.Parse(Console.ReadLine());

            int idade = ano-nascimento;
            Console.WriteLine("Sua iade é "+idade+" anos");

            int semanas = idade*52;
            Console.WriteLine("Sua idade em semanas é "+semanas);
            
        }//FIM DO MAIN
    }
}
