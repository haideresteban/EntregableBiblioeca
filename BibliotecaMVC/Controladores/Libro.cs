using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class Libro
    {
        public int idLibro { get; set; }
        public string titulo { get; set; }
        public DateTime fechaLanzamiento { get; set; }
        public int idAutor { get; set; }
        public int idCategoria { get; set; }
        public int idEditorial { get; set; }
        public string idioma { get; set; }
        public int nroPaginas { get; set; }
        public string descripcion { get; set; }
    }
}
