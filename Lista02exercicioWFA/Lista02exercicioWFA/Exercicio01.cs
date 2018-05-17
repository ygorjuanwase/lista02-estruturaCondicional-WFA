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
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
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
                MessageBox.Show("Numero digitado invalido.");
                txtNumero.Focus();
                return;
            }
            if (numero <= 0)
            {
                statusNumero = "O numero não e positivo.";
            }
            else if(numero > 0)
            {
                statusNumero = "O numero é positivo.";
            }
            txtCofirmado.Text = statusNumero;
           
            
        }
    }
}
