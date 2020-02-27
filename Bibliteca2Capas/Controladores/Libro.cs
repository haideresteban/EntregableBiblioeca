using Controladores.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class Libro
    {
        public static SqlConnection con = new SqlConnection("server=DESKTOP-19G8BCC;database=dbBiblioteca;Trusted_Connection=True;");
        SqlDataAdapter sqlDa;

        public bool registrarLibro(LibroModel libro)
        {
            try
            {
                con.Open();
                string actualizar = @"insert into Libros (titulo, fechaLanzamiento, idAutor, idCategoria, idEditorial, idioma,nroPaginas, descripcion)
                                    values(@titulo, @fechaLanzamiento, @idAutor,@idCategoria,@idEditorial,@idioma,@nroPaginas, @descripcion )";
                SqlCommand comando = new SqlCommand(actualizar, con);
                comando.Parameters.AddWithValue("@titulo", libro.titulo.Trim());
                comando.Parameters.AddWithValue("@fechaLanzamiento", libro.fechaLanzamiento);
                comando.Parameters.AddWithValue("@idAutor", libro.idAutor);
                comando.Parameters.AddWithValue("@idCategoria", libro.idCategoria);
                comando.Parameters.AddWithValue("@idEditorial", libro.idEditorial);
                comando.Parameters.AddWithValue("@idioma", libro.idioma);
                comando.Parameters.AddWithValue("@nroPaginas", libro.nroPaginas);
                comando.Parameters.AddWithValue("@descripcion", libro.descripcion);
                comando.ExecuteNonQuery();
                con.Close();
                return true;

            }
            catch (Exception)
            {
                return false;
            }


        }

        public DataTable listarLibros()
        {
            DataTable dt = new DataTable();
            try
            {

                string sql = @"Select titulo as 'Título', CONVERT(varchar(25), fechaLanzamiento, 103) as 'Fecha de lanzamiento', autor_nombre AS 'Aútor',  nombreCategoria as Categoria, nombreEditorial As Editorial,idioma as Idioma, nroPaginas as 'Número de paginas',descripcion as 'Descripción'
                            from Libros
                            inner join Autores on (Libros.idAutor = Autores.idAutor)
                            inner
                            join Categorias on (Libros.idCategoria = Categorias.idCategoria)
                            inner
                            join Editoriales on (Libros.idEditorial = Editoriales.idEditorial)";
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Connection = con;
                sqlDa = new SqlDataAdapter(command);
                sqlDa.Fill(dt);
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return dt;

        }
        public DataTable listarAutores()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"Select * from autores";
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Connection = con;
                sqlDa = new SqlDataAdapter(command);
                sqlDa.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;

        }

        public DataTable listarCategorias()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"Select* from Categorias";
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Connection = con;
                sqlDa = new SqlDataAdapter(command);
                sqlDa.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;

        }
        public DataTable listarEditoriales()
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = @"Select * from Editoriales";
                con.Open();
                SqlCommand command = con.CreateCommand();
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Connection = con;
                sqlDa = new SqlDataAdapter(command);
                sqlDa.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            return dt;

        }

    }
}
