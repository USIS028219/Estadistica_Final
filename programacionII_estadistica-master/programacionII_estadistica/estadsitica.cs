using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionII_estadistica
{
    class estadsitica
    {
        public double media_a = 0, suma = 0, estand = 0, dat1 = 0;
        public string respuesta = "";
        public double media(String[] serie)
        {
            double suma = 0;
            foreach (string valor in serie) {
                suma += int.Parse(valor);
            }
            return suma / serie.Length;
        }
        public double estandar(String[] serie)
        {
            double media_aritmetica = media(serie), 
                suma = 0;
            foreach(string valor in serie) {
                suma += Math.Pow(double.Parse(valor) - media_aritmetica, 2);
            }
            return suma / serie.Length;
        }
        public double tipica(String[] serie)
        {
            return Math.Sqrt(estandar(serie));
        }

        public void moda(string[] serie)
        {
            int cont = 0;
            for (int i = 0; i < serie.Length; i++)
            {
                for (int j = 0; j < serie.Length; j++)
                {
                    if (double.Parse(serie[j]) == double.Parse(serie[i]))
                    {
                        cont++;
                    }
                }
                if (cont > dat1)
                {
                    respuesta = serie[i] + " Se repite " + cont;
                    dat1 = cont;
                }
                cont = 0;
            }
        }

        public void aritmetica(string[] serie, int index)
        {
            suma += double.Parse(serie[index]);
            if (index < serie.Length - 1)
            {
                aritmetica(serie, ++index);
            }
            else
            {
                media_a = suma / serie.Length;
                suma = 0;
            }
        }
    }
}
