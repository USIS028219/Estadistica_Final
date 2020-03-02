using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionII_estadistica
{
    class Conversiones
    {
        public string[][] conversor = {
            new string[]{"Dolares","Euros","Quetzalez","Lempira","Cordobas","Colon CR"}, //monedas
            new string[]{"Metros","CM","Pulgadas","Pie","Varas","Yardas"}, //Longitud
            new string[]{"Libra","Gramos","Kilogramos","Onzas","Quintales"} //Peso
        };
        double[][] valores = {
            new double[]{1,0.92,7.65,24.9,34.22,572.26}, //monedas
            new double[]{1,100,39.37,3.281,1.196,1.094}, //Longitud
            new double[]{1,0.001, 0.453592, 16, 0.000453592} //Peso
        };
        public double convertir(int opcion, int de, int a, double cantidad)
        {
            return valores[opcion][a] / valores[opcion][de] * cantidad;
        }
    }
}
