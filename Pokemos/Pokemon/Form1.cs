using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private List<Pokemon> ListaPokemon;

        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            ListaPokemon = negocio.Listar();
            dgwPokemons.DataSource = ListaPokemon;
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
            Pokemon seleccionado = (Pokemon)dgwPokemons.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.URLImagen);
        }
    }
}
