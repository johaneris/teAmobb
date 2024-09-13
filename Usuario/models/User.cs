using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.models
{
    internal class User
    {
        private string[] nicks = new string[100];
        private string[] passwords = new string[100];
        private int indice = 0;

        public void AgregarUsuario(string nick, string password)
        {
            if (indice < 100)
            {
                nicks[indice] = nick;
                passwords[indice] = password;
                indice++;
            }
        }
        public string VerificarUsuario(string nick, string password)
        {
            int encontrado = -1;
            for (int i = 0; i < indice; i++)
            {
                if (nicks[i] == nick && passwords[i] == password)
                {
                    encontrado = i;
                    break;
                }
            }

            if (encontrado != -1)
            {
                return "Usuario registrado.";
            }
            else
            {
                return "Usuario no registrado.";
            }
        }
    }
}
