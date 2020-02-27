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

namespace Vista
{
    public partial class Form1 : Form
    {
        ClsLibro clsLibro = new ClsLibro();
        public Form1()
        {
            InitializeComponent();
            llenarCombos();
            consultarLibros();

        }
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

                Libro libro = new Libro();
                libro.titulo = txtTitulo.Text.Trim();
                libro.fechaLanzamiento = dtFecha.Value;
                libro.idAutor = Convert.ToInt32(cbAutores.SelectedValue);
                libro.idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
                libro.idEditorial = Convert.ToInt32(cbEditorial.SelectedValue);
                libro.idioma = cbIdioma.Text;
                libro.nroPaginas = Convert.ToInt32(txtNumeroPaginas.Value);
                libro.descripcion = txtDescripcion.Text;
                return clsLibro.RegistrarLibro(libro);
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
            else
            {
                MessageBox.Show("No se ha podido hacer la insersion de los datos.");
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAutores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbEditorial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumeroPaginas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {

        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
