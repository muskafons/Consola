using System;
using System.Timers;
using System.Collections.Generic;
using Consola.Herencia;
using Consola.Estructura;


namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {


            int contador = 0;

            while (true)
            {
                Console.WriteLine(contador);
                if (Console.ReadLine() != "") break; //Si la entrada es diferente de ENTER, acaba el programa
                Console.Clear();
                contador++;
            }

            Console.WriteLine($"Numero de veces: {contador}");


            //Console.Title = "LA CONSOLA HP";
            //for (int i = 0; i < 15; i++)
            //{

            //    Console.WriteLine(i);
            //    Console.Beep();
            //    Console.Clear();

            //}


            //PedirDatos pedirDatos = new PedirDatos();
            //pedirDatos.PedirDatos1();



            //List<String> nombres = new List<String>();
            //List<int> numeros = new List<int>();        
            //nombres.Add("JUL");
            //nombres.Add("OAA");
            //nombres.Add("DD");
            //nombres.Add("Pdd");
            //foreach (var item in nombres)
            //{
            //    Console.WriteLine(item);
            //}




            //Humano Julian = new Humano("Julian")
            //{
            //    Apellido = "Fonseca"
            //};
            //Gorila Pinky = new Gorila("Pinky");
            //Console.WriteLine($"Hola me LLamo {Julian.Getnombre()} {Julian.Apellido}");
            //Julian.PensamientoBasico();
            //Julian.Comer();
            //Console.WriteLine($"Tengo una mascota llamada {Pinky.MeLlamo()}");
            //Pinky.PensamientoBasico();




            //Aleatorio aleatorio = new Aleatorio();
            ////aleatorio.GetNumeroAleatorio();
            //aleatorio.GetNumeroAleatorio_TRY();




            //LecturaArchivo lecturaArchivo = new LecturaArchivo();
            //lecturaArchivo.Lectura();




            //Items item = new Items();
            //item.SetNumeros();
            //item.GetNumeros();
            //Lista.SumaNumeros();

            Console.Read();

        }
    }

}
