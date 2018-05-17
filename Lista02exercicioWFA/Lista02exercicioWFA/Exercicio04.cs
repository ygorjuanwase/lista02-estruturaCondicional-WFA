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
    public partial class Exercicio04 : Form
    {
        public Exercicio04()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            string statusnumero ="";
            try
            {
                numero = Convert.ToInt16(txtNumero.Text);
            }
            catch
            {
                MessageBox.Show("Numero invalido.");
                txtNumero.Focus();
                return;
            }
            if(numero % 2 == 1)
            {
                statusnumero = "O numero é impar";
            }
            else if (numero % 2 == 0)
            {
                statusnumero = "O numero não é impar";
            }
            txtResultado.Text = statusnumero;





        }
    }
}
