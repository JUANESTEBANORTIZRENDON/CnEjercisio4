using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnEjercisio4
{


    internal class Program
    {
        /// <summary>
        ///nombre:Juan Esteban Ortiz Rendon
        ///Fecha:28/08/2023
        ///Descripcion:Algoritmo para imprimir el valor ddel lado de un cuadrado y sacar su superficie y perimetro e imprimirla
        ///</summary>

        static void Main(string[] args)
        {

            Console.WriteLine("Porfavor escriba el lado del cuadrado para realizar los procesos");
            double l1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("la superfice del cuadrado es:" + superficie(l1));
            Console.WriteLine("el Perimetro del cuadrado es:" + area(l1));

            Console.ReadLine();

        }
        static double superficie(double l1)
        {
            double super;
            super = l1 + l1 + l1 + l1;
            return super;

        }
        static double area(double l1)
        {
            double are;
            are = l1 * l1;
            return are;

        }
    }
}
