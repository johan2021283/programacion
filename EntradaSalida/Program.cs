using System;

namespace EntradaSalida
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();
        }
    }
}
