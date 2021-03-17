using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Herencia
{
    class Gorila : Mamifero
    {

        public Gorila(string nombre)
        {
            Nombre = nombre;
        }

        public void Trepar(int altura)
        {
            Console.WriteLine($"Yo como Gorila Trepo {altura}");
            CuidarCrias();
        }

        public string MeLlamo()
        {
            return Nombre;
        }
    }
}
