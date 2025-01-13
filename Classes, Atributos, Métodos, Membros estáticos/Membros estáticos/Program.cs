using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Membros_estáticos
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Circuferencia(raio);

            double volume = Volume(raio);

            Console.WriteLine("Circuferencia: "+circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //Criando uma função estatica
        static double Circuferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
