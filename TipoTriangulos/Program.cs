using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoTriangulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Averiguar el tipo de triangulo 
            int LADO1, LADO2, LADO3;
            string linea;
            Console.WriteLine("Digite el lado 1: "); linea = Console.ReadLine();
            LADO1 = int.Parse(linea);

            Console.WriteLine("Digite el lado 2:"); linea = Console.ReadLine();
            LADO2 = int.Parse(linea);   

            Console.WriteLine("Digite el lado 3"); linea = Console.ReadLine();
            LADO3 = int .Parse(linea);  

            if ((LADO1 == LADO2 ) & (LADO2 == LADO3))
            {
                Console.WriteLine("TRIANGULO EQUILATERO. TODOS IGUALES");
            }

            else
            {
                if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3 ))
                {
                    Console.WriteLine("TRIANGULO ESCALENO. NINGUNO IGUAL");
                }
                else
                {
                    Console.WriteLine("TRIANGULO ISOSCELES. DOS LADOS IGUALES");
                }
            }
            Console.ReadLine();
        }
    }
}
