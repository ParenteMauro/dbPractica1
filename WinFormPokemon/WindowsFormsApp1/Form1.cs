using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                int resultado;
                resultado = calcular();
                label1.Text = "Resultado: " + resultado.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Cargar bien los datos");
                
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por 0");
            }
            catch(Exception ex) {
                MessageBox.Show("Error generico");
            }
            finally 
            {

            }
            
           

            }
        private int calcular()
        {
            try {
                int a, b, r;
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                r = a + b;
                return r;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
