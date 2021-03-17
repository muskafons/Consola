using System;


namespace Consola
{
    class Items
    {

        private int[] numeros = new int[5];//Arrays de tamaño fijo, a diferencia de las listas
        private string[] nombres = { "JULIO", "ALEZ", "POERL" };
        string[] nombres2 = new string[] { "JULIO", "ALEZ", "POERL" };

        public void SetNumeros()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"::::DIGITE EL NÚMERO {i}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
        }

        public void GetNumeros()
        {
            foreach (var item in numeros)
            {
                // Console.WriteLine(item);
                Console.WriteLine("NUMERO LEIDO: " + numeros[item - 1]);
                // item - 1 Porque comienza en 1.
            }
        }

    }
}
