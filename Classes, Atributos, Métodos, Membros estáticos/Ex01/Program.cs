using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados n1, i1, n2, i2;

            n1 = new Dados(); n2 = new Dados();

            i1 = new Dados(); i2 = new Dados();

            Console.Write("Nome: ");
            n1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            i1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Nome: ");
            n2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            i2.Idade = int.Parse(Console.ReadLine());

            if (i1.Idade > i2.Idade)
            {
                Console.WriteLine("Pessoa mais velha se chama "+n1.Nome+" ele(a) possui "+i1.Idade+" Anos");
            }
            else
            {
                Console.WriteLine("Pessoa mais velha se chama " + n2.Nome + " ele(a) possui " + i2.Idade + " Anos");
            }
        }
    }
}
