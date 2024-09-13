using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Usuario.models;

namespace Usuario
{
    public partial class Form1 : Form
    {
        User usuarios = new User();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void RegistrarUsuario()
        {
            try
            {
                string nick = tbNick.Text;
                string password = tbPassword.Text;

                if (!string.IsNullOrEmpty(nick) && !string.IsNullOrEmpty(password))
                {
                    usuarios.AgregarUsuario(nick, password);
                    MessageBox.Show("Usuario registrado exitosamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbNick.Clear();
                    tbPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, complete ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerificarUsuario()
        {
            try
            {
                string nick = tbNick.Text;
                string password = tbPassword.Text;

                if (!string.IsNullOrEmpty(nick) && !string.IsNullOrEmpty(password))
                {
                    string resultado = usuarios.VerificarUsuario(nick, password);
                    MessageBox.Show(resultado, "Verificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, complete ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            VerificarUsuario();
        }
    }
}
