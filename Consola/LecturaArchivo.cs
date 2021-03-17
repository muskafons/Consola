using System;

namespace Consola
{
    class LecturaArchivo
    {

        private System.IO.StreamReader archivo;
        private string path;
        private int contador;
        private string linea;

        public void Lectura()
        {
         
            path = @"E:\OneDrive\DESARROLLO\NET\texto.txt";
            contador = 0;
            

            try
            {
                archivo = new System.IO.StreamReader(path); //Dentro del TRY para que se cumpla la excepción
                //linea = archivo.ReadLine();

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("ERROR AL LEER EL ARCHIVO");
            }

            Console.WriteLine("Programa Terminado");
            Console.WriteLine("Numero de Lineas: " + contador);

        }

    }
}
