using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Libro
    {
        Datos.Libro objDatos = new Datos.Libro();
        public List<Entidades.Libro> TraerTodos()
        {
            return objDatos.TraerTodos();
        }

        public Object TraerAlgunos()
        {
            return objDatos.TraerAlgunos();
        }
        public Entidades.Libro TraerxISBN(string isbn)
        {
            return objDatos.TraerxISBN(isbn);
        }

        public List<Entidades.ViewModelLibro> TraerViewModel()
        {
            return objDatos.TraerViewModel();
        }
        public Entidades.Autore TraerAutorxID(int id)
        {
            return objDatos.TraerAutorxID(id);
        }
    }
}
