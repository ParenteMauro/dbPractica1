using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBorrarPokemon : Form
    {
        public frmBorrarPokemon()
        {
            InitializeComponent();
        }

        private void frmBorrarPokemon_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokemonBorrar = new PokemonNegocio();
            try
            {
                pokemonBorrar.quitar(txtNombre.Text);
                MessageBox.Show("Pokemon borrado exitosamente");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
