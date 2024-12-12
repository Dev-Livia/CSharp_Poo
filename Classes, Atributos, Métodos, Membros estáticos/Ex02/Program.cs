using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            //médio dos funcionários.

            Dados Nome, Nome2, Salario, Salario2;
            double media;

            Nome = new Dados();
            Salario = new Dados();
            Nome2 = new Dados();
            Salario2 = new Dados();

            Console.Write("Informe o nome: ");
            Nome.N = Console.ReadLine();

            Console.Write("Informe o salario: ");
            Salario.S = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Informe os dados do segundo funcionario...");
            Console.WriteLine();

            Console.Write("Informe o nome: ");
            Nome2.N = Console.ReadLine();

            Console.Write("Informe o Salario: ");
            Salario2.S = double.Parse(Console.ReadLine());

            media = (Salario.S + Salario2.S) / 2;

            Console.WriteLine("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
