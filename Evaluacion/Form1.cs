using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.models;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        number numeros = new number();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void lblMenor_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblMayor_Click(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarNumero();

        }
        private void AgregarNumero()
        {
            try
            {
                string numeroTexto = tbNumero.Text;
                if (int.TryParse(numeroTexto, out int numero) && numero >= 0)
                {
                    numeros.AgregarNumero(numeroTexto);
                    MostrarResultados();
                    tbNumero.Clear();
                    tbNumero.Focus();
                }
                else if (numero < 0)
                {
                    MessageBox.Show("Número negativo detectado.", "Fin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarResultadosFinales();
                    tbNumero.Clear();
                    tbNumero.Enabled = false;
                    btnAdd.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarResultados()
        {
            lbNumeros.Items.Clear();
            string[] nums = numeros.ObtenerNumeros();
            for (int i = 0; i < nums.Length && !string.IsNullOrEmpty(nums[i]); i++)
            {
                lbNumeros.Items.Add(nums[i]);
            }
        }

        private void MostrarResultadosFinales()
        {
            int suma = numeros.ObtenerSuma();
            string mayor = numeros.ObtenerMayor();
            string menor = numeros.ObtenerMenor();

            lblSuma.Text = "Suma: " + suma;
            lblMax.Text = "Máximo: " + mayor;
            lblMin.Text = "Mínimo: " + menor;
        }

        private void lbNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
