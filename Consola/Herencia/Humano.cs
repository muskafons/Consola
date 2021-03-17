using System;

namespace Consola.Herencia
{
    class Humano : Mamifero
    {
        private string apellido;
        public string Apellido { get => apellido; set => apellido = value; }

        public Humano(string nombre)
        {
            Nombre = nombre;
        }
        
        public string Getnombre()
        {
            return Nombre;
        }

        public override void PensamientoBasico()
        {
            Console.WriteLine(">>>> Pienso con más detalle");
            CuidarCrias();
        } 
    }
}
