using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

using Controladores.Models;

namespace Bibliteca2Capas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            llenarCombos();
            consultarLibros();
        }

        Libro clsLibro = new Libro();

        public bool validarCampos()
        {
            if (!(String.IsNullOrWhiteSpace(txtTitulo.Text)) && cbIdioma.SelectedIndex > -1 && cbEditorial.SelectedIndex > -1 && cbAutores.SelectedIndex > -1 && cbCategoria.SelectedIndex > -1 && txtNumeroPaginas.Value > 0)
            {
                return true;
            }
            return false;

        }

        public bool registrarLibro()
        {
            if (validarCampos())
            {

                LibroModel libro = new LibroModel();
                libro.titulo = txtTitulo.Text.Trim();
                libro.fechaLanzamiento = dtFecha.Value;
                libro.idAutor = Convert.ToInt32(cbAutores.SelectedValue);
                libro.idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                libro.idEditorial = Convert.ToInt32(cbEditorial.SelectedValue);
                libro.idioma = cbIdioma.Text;
                libro.nroPaginas = Convert.ToInt32(txtNumeroPaginas.Value);
                libro.descripcion = txtDescripcion.Text;
                return clsLibro.registrarLibro(libro);
            }
            return false;


        }
        public void consultarLibros()
        {
            grdLibros.DataSource = clsLibro.listarLibros();
        }
        public void llenarCombos()
        {
            DataTable dt = new DataTable();
            dt = clsLibro.listarCategorias();
            cbCategoria.DataSource = dt;
            cbCategoria.SelectedIndex = -1;
            dt = clsLibro.listarAutores();
            cbAutores.DataSource = dt;
            cbAutores.SelectedIndex = -1;
            dt = clsLibro.listarEditoriales();
            cbEditorial.DataSource = dt;
            cbEditorial.SelectedIndex = -1;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (registrarLibro())
            {
                llenarCombos();
                consultarLibros();
                MessageBox.Show("Se registro de manera exitosa el libro");
            }
        }


    }

}
