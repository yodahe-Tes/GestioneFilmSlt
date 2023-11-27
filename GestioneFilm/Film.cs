using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    internal class Film : IMedia
    {
        public string? Titolo { get ; set ; }
        public int Durata { get; set; }

        enum Premio { Oscar , David , Grammy}
        public void Play()
        {
            Random rnd = new Random();
            int Durata = rnd.Next(1, 61);
            Console.WriteLine("il film" + Titolo + " e al minuto " + Durata);
            
        }
    }
}
