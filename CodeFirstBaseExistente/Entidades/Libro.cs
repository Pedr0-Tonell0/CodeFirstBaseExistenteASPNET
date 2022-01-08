using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class Libro
    {
        Entidades.ModeloBiblioteca db = new Entidades.ModeloBiblioteca();
        
        public List<Entidades.Libro> TraerTodos()
        {
            var listaLibros = (from l in db.Libros
                               select l).ToList();
            return listaLibros;
        }

        public Object TraerAlgunos()
        {
            var libros = (from l in db.Libros
                               select new 
                               { 
                                    ISBN = l.ISBN, 
                                    Nombre = l.Titulo,
                                    Edicion = l.Edicion,
                                    Genero = l.Genero.Descripcion,
                                    Editorial = l.Editoriale.Descripcion
                               }).ToList();
            return libros;
        }

        public Entidades.Libro TraerxISBN (string isbn)
        {
            var libro = db.Libros.Find(isbn);
            if(libro == null)
            {
                libro = new Entidades.Libro();
                libro.Titulo = "No encontrado";
            }
            return libro;
        }

        public List<Entidades.ViewModelLibro> TraerViewModel()
        {
            var lista = (from l in db.Libros
                         select new Entidades.ViewModelLibro
                         {
                             ISBN = l.ISBN,
                             Nombre = l.Titulo,
                             Edicion = l.Edicion,
                             Paginas = l.Paginas,
                             Genero = l.Genero.Descripcion,
                             Editorial = l.Editoriale.Descripcion
                         }).ToList();
            return lista;
        }
    
        public Entidades.Autore TraerAutorxID(int id)
        {
            var autor = db.Autores.Find(id);
            return autor;
        }
    }
}
