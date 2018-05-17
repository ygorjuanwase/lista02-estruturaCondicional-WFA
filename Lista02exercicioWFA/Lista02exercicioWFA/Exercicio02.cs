using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista02exercicioWFA
{
    public partial class Exercicio02 : Form
    {
        public Exercicio02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            string statusNumero = "";
            try
            {
                numero = Convert.ToInt32(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Numero invalido.");
                txtNumero.Focus();
                return;
            }
            if (numero >= 0)
            {
                statusNumero = "Numero é positivo.";
            }
            else if(numero < 0)
            {
                statusNumero = "Numero é negativo.";
            }
            txtConfirmado.Text = statusNumero;
        }
    }
}
