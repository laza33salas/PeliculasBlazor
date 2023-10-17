using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PeliculasBlazor.Shared.Entidades
{
    public class Pelicula
    {
        public string Titulo { get; set; } = null!;
        public DateTime Lanzamiento { get; set; }

    }
}
