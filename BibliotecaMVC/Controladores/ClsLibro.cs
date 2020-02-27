using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;


namespace Controladores
{
    public class ClsLibro
    {
        DataTable dt = new DataTable();
        Modelo.Libro libModel = new Modelo.Libro();
      

        public DataTable listarLibros()
        {
            return dt = libModel.listarLibros();
        }
        public DataTable listarAutores()
        {
            dt = new DataTable();
            return dt = libModel.listarAutores();
        }
        public DataTable listarCategorias()
        {
            dt = new DataTable();
            return dt = libModel.listarCategorias();
        }
        public DataTable listarEditoriales()
        {
            dt = new DataTable();
            return dt = libModel.listarEditoriales();
        }
        public  bool RegistrarLibro(Libro libro)
        {
            return libModel.registrarLibro(libro.titulo, libro.fechaLanzamiento, libro.idAutor, libro.idCategoria, libro.idEditorial, libro.idioma, libro.nroPaginas, libro.descripcion);
        }

    }
}
