using System;
using System.Collections.Generic;
using System.Text;

namespace Reservas.Interfaces
{
    public  interface IConcierto
    {
         string Luces();
         string Sonido();
        string Cantantes();
        string Cantantes(Lugar lugar);
        string GeneroMusical();
    }
}
