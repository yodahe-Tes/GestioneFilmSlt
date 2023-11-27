using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    internal interface IMedia
    {
        public string? Titolo { get; set; }
        public int Durata { get; set; }

        void Play();
    }
}
