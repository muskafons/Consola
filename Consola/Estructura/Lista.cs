using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Estructura
{
    class Lista
    {
        static public void SumaNumeros()
        {
            List<int> numeros = new List<int>();
            int suma = 0;


            while (true)
            {
                try
                {
                    Console.Write("Ingrese numero 1: ");
                    numeros.Add(Int32.Parse(Console.ReadLine()));
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(":::::::::::INGRESE UN NUMERO SOQUETE");
                    Console.ResetColor();
                }
                finally
                {
                    Console.WriteLine("FINALLY Pase lo que pase el programa llega hasta aca");
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Ingrese numero 2: ");
                    numeros.Add(Int32.Parse(Console.ReadLine()));
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(":::::::::::INGRESE UN NUMERO SOQUETE");
                    Console.ResetColor();
                }
            }

            Console.WriteLine($" Total en la lista =  {numeros.Count}");
            foreach (var item in numeros) { suma += item; }

            Console.WriteLine($"La suma es { suma }");
        }
    }
}
