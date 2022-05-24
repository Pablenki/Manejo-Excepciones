using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Excepciones_T3
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Indique un numero: "); 
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado del numero elevado al cuadrado es de: {0}" , Math.Pow(num1, 2));
                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadKey();
            }
          
            catch (FormatException)
            {
                Console.WriteLine("El tipo de dato no es entero, pruebe con un numero que no haga uso decimales");
            }
         
            catch (OverflowException)
            {
                Console.WriteLine("El numero es muy grande, intente con un numero mas chico");
            }
            Console.ReadKey();
        }
    }
}
