using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Pokemon
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxpokemons.Load(imagen);
            }
            catch
            {
                pbxpokemons.Load("https://agroworldspain.com/img/noimage.png");
            }
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            pokemon obj = new pokemon();
            try
            {
                obj.Numero = int.Parse(txtNumero.Text);
                obj.Nombre = txtNombre.Text;
                obj.Descripcion = txtDescripcion.Text;
                obj.URLImagen = txtUrlimagen.Text;
                obj.Tipo = (Elemento)cbxTipo.SelectedItem;
                obj.Debilidad = (Elemento)cbxDebilidad.SelectedItem;

                negocio.AgregarPokemon(obj);
                MessageBox.Show("Se agrego correctamente el pokemon. ");
                Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();
            try
            {
                cbxTipo.DataSource = negocio.Listar();
                cbxDebilidad.DataSource = negocio.Listar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtUrlimagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtUrlimagen.Text);
        }
    }
}
