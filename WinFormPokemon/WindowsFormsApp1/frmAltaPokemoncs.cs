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
        public frmAltaPokemoncs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pokemon poke = new Pokemon();
            try
            {
                poke.Numero = int.Parse(txtNumero.Text);   
                poke.Nombre = txtNombre.Text;
                poke.Descripcion = txtDescripcion.Text;
                poke.Tipo = (Elemento)cbxTipo.SelectedItem;
                poke.Debilidad = (Elemento)cbxDebilidad.SelectedItem;
                poke.UrlImagen = txtImagen.Text;
            
                PokemonNegocio pokemonNegocio = new PokemonNegocio();
                pokemonNegocio.agregar(poke);
                MessageBox.Show("Pokemon Agregado" );
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
                cbxDebilidad.DataSource = elementoNegocio.listar();

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
