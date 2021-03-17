using System;


namespace Consola.Herencia
{
    class Mamifero
    {
        private string nombre;

        protected string Nombre { get => nombre; set => nombre = value; }

        protected void CuidarCrias()
        {
            Console.WriteLine("CUIDO A MIS CRIAS");
        }

        public virtual void PensamientoBasico()
        {
            Console.WriteLine("TENGO Funciones de pensamientos Basicos");
        }

        public void Comer()
        {
            Console.WriteLine("COMO LO QUE SEA!!!!");
        }

    }
}
