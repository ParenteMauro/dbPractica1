using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using negocio;
using dominio;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listaPokemon = new List<Pokemon>();
        private List<Elemento> listaElemento = new List<Elemento>();
        public Form1()
        {
            InitializeComponent();
        }

 
        private void Form1_Load(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            cargar();

            ElementoNegocio negocioElemen = new ElementoNegocio();
            listaElemento = negocioElemen.listar();


        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {

            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string Imagen)
        {
            try
            {
                pbxPokemon.Load(Imagen);
            }
            catch (Exception ex)
            {
                pbxPokemon.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemoncs alta = new frmAltaPokemoncs();
            alta.ShowDialog();
            
            cargar();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            frmBorrarPokemon borrar = new frmBorrarPokemon();
            borrar.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemons.DataSource = listaPokemon;
                dgvPokemons.Columns["UrlImagen"].Visible = false;
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
