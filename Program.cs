using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string novamente = "sim";
            Preenchimento a = new Preenchimento();
            do
            {

                a.Boasvindas();

                a.geral();

                Console.WriteLine("\n            Tecle Enter para começar!");
                Console.ReadLine();
                Console.Clear();

                a.Boasvindas();
                a.limpartabuleiro();
                a.preenchertabuleiro();
                Console.WriteLine("    Gostaria de jogar novamente? digite sim ou não");
                novamente = Console.ReadLine();
                novamente.ToLower();
                novamente.Trim();
                Console.Clear();


            } while (novamente == "sim");



        }
    }
}
