using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDiscos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscosNegocios lista = new DiscosNegocios();

            List<Disco> listaDiscos = new List<Disco>();

            listaDiscos = lista.listar();
            

            dgvDiscos.DataSource = listaDiscos; 





        }

       
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Disco actual = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                pbxDisco.Load(actual.UrlImagen);
            }
            catch (Exception ex)
            {
                pbxDisco.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }
    }
}
