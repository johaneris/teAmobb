using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion.models
{
    public class number
    {

        private string[] numeros = new string[100];
        private int indice = 0;

        public void AgregarNumero(string numero)
        {
            if (indice < 100)
            {
                numeros[indice] = numero;
                indice++;
            }
        }

        public string[] ObtenerNumeros()
        {
            return numeros;
        }

        public int ObtenerSuma()
        {
            int suma = 0;
            for (int i = 0; i < indice; i++)
            {
                if (int.TryParse(numeros[i], out int num))
                {
                    suma += num;
                }
            }
            return suma;
        }

        public string ObtenerMayor()
        {
            int max = int.MinValue;
            string numeroMayor = "";

            for (int i = 0; i < indice; i++)
            {
                if (int.TryParse(numeros[i], out int num) && num > max)
                {
                    max = num;
                    numeroMayor = numeros[i];
                }
            }
            return numeroMayor;
        }

        public string ObtenerMenor()
        {
            int min = int.MaxValue;
            string numeroMenor = "";

            for (int i = 0; i < indice; i++)
            {
                if (int.TryParse(numeros[i], out int num) && num < min)
                {
                    min = num;
                    numeroMenor = numeros[i];
                }
            }
            return numeroMenor;
        }

    }
}
