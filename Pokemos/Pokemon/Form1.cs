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
            dgwPokemons.Columns["URLImagen"].Visible = false;
            dgwPokemons.Columns["Id"].Visible = false;
            CargarImagen(ListaPokemon[0].URLImagen);
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
    }
}
