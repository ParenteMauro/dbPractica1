using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace WindowsFormsApp1
{
    public partial class frmAltaPokemoncs : Form
    {
        private Pokemon pokemon = null;
        public frmAltaPokemoncs()
        {
            InitializeComponent();
        }

        public frmAltaPokemoncs(Pokemon pokemon)
        {
            this.pokemon = pokemon;

            InitializeComponent();
            Text = "Modificar Pokemon";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(pokemon== null)
                {
                    pokemon = new Pokemon();
                }

                pokemon.Numero = int.Parse(txtNumero.Text);   
                pokemon.Nombre = txtNombre.Text;
                pokemon.Descripcion = txtDescripcion.Text;
                pokemon.Tipo = (Elemento)cbxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbxDebilidad.SelectedItem;
                pokemon.UrlImagen = txtImagen.Text;
            
                PokemonNegocio pokemonNegocio = new PokemonNegocio();
                if (pokemon.Id != 0)
                {
                    pokemonNegocio.modificar(pokemon);
                    MessageBox.Show("Pokemon Modificado");
                  
                }
                else
                {
                    pokemonNegocio.agregar(pokemon);
                    MessageBox.Show("Pokemon Agregado");

                }


                this.Close();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPokemoncs_Load(object sender, EventArgs e)
        {
            try
            {
                ElementoNegocio elementoNegocio = new ElementoNegocio();
                cbxTipo.DataSource = elementoNegocio.listar();
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";
                cbxDebilidad.DataSource = elementoNegocio.listar();
                cbxDebilidad.ValueMember = "Id";
                cbxDebilidad.DisplayMember = "Descripcion";

                if(pokemon != null)
                {
                    txtNumero.Text = pokemon.Numero.ToString();
                    txtNombre.Text = pokemon.Nombre;
                    txtDescripcion.Text = pokemon.Descripcion;
                    txtImagen.Text = pokemon.UrlImagen.ToString();
                    cargarImagen(pokemon.UrlImagen);
                    cbxTipo.SelectedValue = pokemon.Tipo.Id;
                    cbxDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }

            }
            catch (Exception ex) 
            { 
            
                throw ex;
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagen.Text);
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
    }
}
