using System;

namespace Consola
{
    class Aleatorio
    {
        private Random numero = new Random();

        public void GetNumeroAleatorio()
        {
            int numeroAleatorio = numero.Next(1, 100);
            int contador = 0;
            int numeroActual;

            Console.WriteLine("\n\n:::::: NUMERO ALEATORIO :::::");

            while (true)
            {

                Console.Write("Digite el numero: ");
                numeroActual = int.Parse(Console.ReadLine());

                if (numeroAleatorio == numeroActual) break;
                else if (numeroAleatorio > numeroActual) Console.WriteLine("Numero aleatorio es mayor");
                else if (numeroAleatorio < numeroActual) Console.WriteLine("Numero aleatorio es menor");

                contador++;

            }

            Console.WriteLine("\n\n:::::::: Adivino después de: " + contador + " veces");

        }

        public void GetNumeroAleatorio_TRY()
        {
            int numeroAleatorio = numero.Next(1, 100);
            int contador = 0;
            int numeroActual;

            Console.WriteLine("\n\n:::::: NUMERO ALEATORIO :::::");

            while (true)
            {
                try
                {
                    Console.Write("Digite el numero: ");
                    numeroActual = int.Parse(Console.ReadLine());
                    if (numeroAleatorio == numeroActual) break;
                    else if (numeroAleatorio > numeroActual) Console.WriteLine("Numero aleatorio es mayor");
                    else if (numeroAleatorio < numeroActual) Console.WriteLine("Numero aleatorio es menor");
                }

                catch (Exception)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("::::::NO INGRESO UN NUMERO");
                    Console.ResetColor();
                }

                contador++;

            }

            Console.WriteLine("\n\n:::::::: Adivino después de: " + contador + " veces");

        }

    }
}
