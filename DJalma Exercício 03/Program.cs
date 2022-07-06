using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DJalma_Exercício_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m1, m2, c3, res;
            string forma = null;
            var area = Convert.ToDouble(null);
            Console.WriteLine("Escolha uma figura:");
            Console.WriteLine();

            Console.WriteLine("1: Trapézio");

            Console.WriteLine("2: Prisma");

            Console.WriteLine("3: Paralelogramo");
            Console.WriteLine();

            res = Convert.ToInt32(Console.ReadLine());

            switch (res)
            {
                case 1:

                    forma = ("Trapézio");
                    Console.WriteLine("Informe Valor da base maior:");
                    m2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe Valor Da base menor");
                    m1= double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe Altura ");
                    c3 = double.Parse(Console.ReadLine());
                    area = (m2 * m1) * c3 / 2;
                    break;

                    case 2:

                    forma = ("Prisma");
                    Console.WriteLine("Informe Valor da base");
                    m2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ifome valor da largura");
                    m1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("informe valor da altura");
                    c3= double.Parse(Console.ReadLine());

                    area = m2 * 4 + m1 * 4 + c3 * 4;
                    break;

                case 3:
                    forma = ("Paralelogramo");
                    Console.WriteLine("Informe Valor de Base:");
                    m2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe Altura");
                    m1 = double.Parse(Console.ReadLine());
                    break;
                    }
            Console.WriteLine();

            Console.WriteLine("Sua " + forma + " tem uma area total de: " + area + "cm².");
                        Console.ReadKey();
        }
    }
}
