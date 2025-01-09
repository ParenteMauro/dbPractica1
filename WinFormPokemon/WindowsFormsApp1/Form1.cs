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
            cbxCampo.Items.Add("Número");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
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
            if (dgvPokemons.CurrentRow != null) {
                Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
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
            eliminar();
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.listar();
                dgvPokemons.DataSource = listaPokemon;
                ocultarColumnas();
                cargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void eliminar ( bool logico = false)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            try
            {
                DialogResult result = MessageBox.Show("Estás seguro que querés eliminar Pokemon?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    if (logico)
                        pokemonNegocio.eliminarLogico(seleccionado.Id);
                    else
                        pokemonNegocio.quitar(seleccionado.Id);


                 cargar();
                    
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPokemons.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Pokemon no seleccionado");
                }
                else
                {
                    Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

                    frmAltaPokemoncs modificar = new frmAltaPokemoncs(seleccionado);
                    modificar.ShowDialog();
                    cargar();
                }
            }
            catch(NullReferenceException ex)
            {
                throw ex;
            }
            
        }

        private void btnBorrarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
            PokemonNegocio negocio = new PokemonNegocio();
                if (cbxCampo.SelectedItem != null && cbxCriterio.SelectedItem != null)
                {
                    string campo = cbxCampo.SelectedItem.ToString();
                    string criterio = cbxCriterio.SelectedItem.ToString();
                    string filtro = cbxFiltro.Text;
                    dgvPokemons.DataSource = negocio.filtrar(campo, criterio, filtro);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void ocultarColumnas()
        {
            dgvPokemons.Columns["Id"].Visible = false;
            dgvPokemons.Columns["UrlImagen"].Visible = false;

        }

        private void txtfiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
        private void buscar(string filtro, List<Pokemon> listaFiltrada)
        {

        }

        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtfiltro.Text;
            if (filtro.Length >= 3)
            {

                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaPokemon;
            }
            dgvPokemons.DataSource = null;

            dgvPokemons.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if(opcion == "Número")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }
    }
}
