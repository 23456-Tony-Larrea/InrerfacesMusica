using Instrumentos.Musica.Implementacion.ConciertoImplementacion;
using Reservas.Interfaces;
using System;

namespace Instrumentos.Musica.Implementacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hola bienvenido al concierto!");

            IConcierto concierto = new Guitarra();
            Console.WriteLine();
            Console.WriteLine(concierto.Cantantes());
            Console.WriteLine(concierto.Cantantes(Lugar.Quito));
            Console.WriteLine(concierto.Luces());
            Console.WriteLine(concierto.Sonido());
            Console.WriteLine(concierto.GeneroMusical());
              
            concierto = new Tambor();
            Console.WriteLine();
            Console.WriteLine(concierto.Cantantes());
            Console.WriteLine(concierto.Cantantes(Lugar.Manta));
            Console.WriteLine(concierto.Luces());
            Console.WriteLine(concierto.Sonido());
            Console.WriteLine(concierto.GeneroMusical());
            Console.ReadLine();
           
        }
    }
}
