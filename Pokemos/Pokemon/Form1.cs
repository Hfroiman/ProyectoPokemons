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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private List<pokemon> ListaPokemon;

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            ListaPokemon = negocio.Listar();
            dgwPokemons.DataSource = ListaPokemon;
            ocultarColumna();
            CargarImagen(ListaPokemon[0].URLImagen);
        }

        public void ocultarColumna()
        {
            dgwPokemons.Columns["URLImagen"].Visible = false;
            dgwPokemons.Columns["Id"].Visible = false;
        }

        private void CargarImagen(string imagen) {
            try
            {
                pbxpokemons.Load(imagen);
            }
            catch
            {
                pbxpokemons.Load("https://agroworldspain.com/img/noimage.png");
            }
        }

        private void dgwPokemons_SelectionChanged(object sender, EventArgs e)
        {
            pokemon seleccionado = (pokemon)dgwPokemons.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.URLImagen);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            pokemon seleccionado = new pokemon();
            seleccionado = (pokemon)dgwPokemons.CurrentRow.DataBoundItem;
            FormAgregar modificar = new FormAgregar(seleccionado);
            modificar.ShowDialog();
        }

        private void btneliminacionfisica_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btneliminarlogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            pokemon seleccionado = new pokemon();
            try
            {
            DialogResult msj = MessageBox.Show("De verdad quieres eliminarlo?","Eliminado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msj == DialogResult.Yes)
                {
                    if (logico==false)
                    {
                    seleccionado = (pokemon)dgwPokemons.CurrentRow.DataBoundItem;
                    negocio.EliminacionFisica(seleccionado.Id);
                    MessageBox.Show("Pokemon Eliminado correctamente..");
                    }
                    else
                    {
                    seleccionado = (pokemon)dgwPokemons.CurrentRow.DataBoundItem;
                    negocio.eliminacionlogica(seleccionado.Id);
                    MessageBox.Show("Pokemon Eliminado correctamente..");    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Cargar();
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            List<pokemon> listafiltrada;
            string filtro = txtfiltro.Text;
            if (filtro!="")
            {
                listafiltrada = ListaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listafiltrada = ListaPokemon;
            }
            dgwPokemons.DataSource = null;
            dgwPokemons.DataSource = listafiltrada;
            ocultarColumna();
        }
    }
}
