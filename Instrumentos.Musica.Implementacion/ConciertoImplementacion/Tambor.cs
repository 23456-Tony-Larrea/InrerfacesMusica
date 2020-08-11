using Reservas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumentos.Musica.Implementacion.ConciertoImplementacion
{
    class Tambor : IConcierto
    {
        public string Cantantes()
        {
            return "Yo me llamo Andres";
        }

        public string Cantantes(Lugar lugar)
        {
            return "Yo me llamo Andres";
        }

        public string GeneroMusical()
        {
            return "Genero musica Bachata";
        }

        public string Luces()
        {
            return "Mis luces favoritas son amarillas ";
        }

        public string Sonido()
        {
            return "Genero sonido con tambor";
        }
    }
}
