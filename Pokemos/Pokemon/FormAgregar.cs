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
        pokemon poke= null;
        public FormAgregar()
        {
            InitializeComponent();
        }

        public FormAgregar(pokemon agregado)
        {
            InitializeComponent();
            this.poke = agregado;
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
            
            try
            {
                poke.Numero = int.Parse(txtNumero.Text);
                poke.Nombre = txtNombre.Text;
                poke.Descripcion = txtDescripcion.Text;
                poke.URLImagen = txtUrlimagen.Text;
                poke.Tipo = (Elemento)cbxTipo.SelectedItem;
                poke.Debilidad = (Elemento)cbxDebilidad.SelectedItem;

                if (poke.Id!=0)
                {
                    negocio.Modificarpokemon(poke);
                    MessageBox.Show("Se modifico correctamente el pokemon. ");
                }
                else
                {
                negocio.AgregarPokemon(poke);
                    MessageBox.Show("Se agrego correctamente el pokemon. ");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Close();
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocio = new ElementoNegocio();
            try
            {
                cbxTipo.DataSource = negocio.Listar();
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";
                cbxDebilidad.DataSource = negocio.Listar();
                cbxDebilidad.ValueMember = "Id";
                cbxDebilidad.DisplayMember = "Descripcion";

                if (poke!=null)
                {
                    txtNumero.Text = poke.Numero.ToString();
                    txtNombre.Text = poke.Nombre;
                    txtDescripcion.Text = poke.Descripcion;
                    txtUrlimagen.Text = poke.URLImagen;
                    cbxTipo.SelectedValue = poke.Tipo.Id;
                    cbxDebilidad.SelectedValue = poke.Debilidad.Id;

                }

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
