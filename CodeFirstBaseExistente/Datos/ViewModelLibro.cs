using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ViewModelLibro
    {
        public string ISBN { get; set; }
        public string Nombre { get; set; }
        public int? Edicion { get; set; }
        public int? Paginas{ get; set; }
        public string Genero{ get; set; }
        public string Editorial{ get; set; }

    }
}
