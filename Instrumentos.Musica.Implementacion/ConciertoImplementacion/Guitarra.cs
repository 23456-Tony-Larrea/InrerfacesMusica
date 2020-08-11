using Reservas.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Instrumentos.Musica.Implementacion.ConciertoImplementacion
{
    public class Guitarra : IConcierto
    {
        public string Cantantes()
        {
            return "Yo me llamo Juanito";
        }

        public string Cantantes(Lugar lugar)
        {
            if (Lugar.Quito==lugar || Lugar.Manta==lugar )
            {
                return $"Cante en {lugar}";
            }
            return "No nado";
        }

        public string Cantates()
        {
              return "Me llamo Juanito y estoy caantando en el desierto";
        }
      
        public string GeneroMusical()
        {
            return "Genero musica Bachata";
        }

        public string Luces()
        {
            return "Para el concierto uso luces azules";
        }

        public string Sonido()
        {
            return "Yo genero el sonido con la Guitarra";
        }
    }
}
