using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write(" Ingrese el primer numero: ");
                int Num1 = int.Parse(Console.ReadLine());
                Console.Write(" Ingrese el segundo numero: ");
                int Num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(Num1 / Num2);
                // Codigo que busca si algo esta causando error
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Intente con otro numero");
                Console.ReadKey();
                Console.WriteLine("Presione enter para continuar");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Intente con algun numero");
                Console.ReadKey();
                Console.WriteLine("Presione enter para continuar");
            }
            finally
            {
                Console.Clear();
                Console.Write(" Ingrese el primer numero: ");
                int Num1 = int.Parse(Console.ReadLine());
                Console.Write(" Ingrese el segundo numero: ");
                int Num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(Num1 / Num2);
           

            }
        }
    }
}
