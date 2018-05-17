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
    public partial class Exercicio03 : Form
    {
        public Exercicio03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;

            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text);
            }
            catch
            {
                MessageBox.Show("Numero invalido.");
                    txtNumero1.Focus();
                return;
            }
            try
            {
                numero2 = Convert.ToInt32(txtNumero2.Text);
            }
            catch
            {
                MessageBox.Show("numero invalido.");
                txtNumero2.Focus();
                return;
            }
            if (cbopcoes.SelectedItem.ToString().ToLower() == "somar")
            {
                int somar = numero1 + numero2;
                txtresultado.Text = Convert.ToString(somar);

            }
            if (cbopcoes.SelectedItem.ToString().ToLower() == "subtrair")
            {
                int diminuir = numero1 - numero2;
                txtresultado.Text = Convert.ToString(diminuir); 
            }
            if (cbopcoes.SelectedItem.ToString().ToLower() == "multilplicar")
            {
                int multiplicar = numero1 * numero2;
                txtresultado.Text = Convert.ToString(multiplicar);
            }
            if (cbopcoes.SelectedItem.ToString().ToLower() == "dividir")
            {
                double dividir = numero1 / numero2;
                txtresultado.Text = Convert.ToString(dividir);
            }
      



            }


     
        }
    }

