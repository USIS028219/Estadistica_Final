using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programacionII_estadistica
{
    public partial class Form1 : Form
    {
        estadsitica objEstadistica = new estadsitica();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMediaAritmetica_Click(object sender, EventArgs e)
        {
            //split => divide una cadena en base a un delimitador (patron) y devuelve una matriz
            lblrespuesta.Text = "X="+ objEstadistica.media(txtserie.Text.Split(','));
        }

        private void btnCalcularEstandar_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Estandar=" + objEstadistica.estandar(txtserie.Text.Split(','));
        }

        private void btnCalcularTpica_Click(object sender, EventArgs e)
        {
            lblrespuesta.Text = "Tipica=" + objEstadistica.tipica(txtserie.Text.Split(','));
        }

        private void grdEstadistica_KeyUp(object sender, KeyEventArgs e)
        {
            try{
                int nfilas = grdEstadistica.Rows.Count - 1,
                    sumaf1 = 0,
                    sumaxixfi = 0;
                double sumax2ixfi = 0;
                DataGridViewRow fila;

                for (int i = 0; i < nfilas; i++){
                    fila = grdEstadistica.Rows[i];
                    int x1 = int.Parse(fila.Cells["x1"].Value.ToString()),
                        f1 = int.Parse(fila.Cells["f1"].Value.ToString());
                    sumaf1 += f1;
                    sumaxixfi += x1 * f1;
                    sumax2ixfi += Math.Pow(x1, 2) * f1;

                    fila.Cells["fi"].Value = sumaf1.ToString();
                    fila.Cells["xixfi"].Value = (x1*f1).ToString();
                    fila.Cells["x2ixfi"].Value = ( Math.Pow(x1,2) * f1).ToString();
                }
                lbltotalf1.Text = sumaf1.ToString();
                lbltotalxixfi.Text = sumaxixfi.ToString();
                lbltotalx2ixfi.Text = sumax2ixfi.ToString();

                double media = sumaxixfi / sumaf1,
                    standar = sumax2ixfi / sumaf1 - Math.Pow(media,2),
                    tipica = Math.Sqrt(standar);
           
                lblmedia.Text = media.ToString();
                lblestandar.Text = standar.ToString();
                lbltipica.Text = tipica.ToString();
            }
            catch(Exception error) { 
                
            }
        }
        private void grdEstadistica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            objEstadistica.aritmetica(txtserie.Text.Split(','), 0);
            lblMediaR.Text = "Aritmetica: " + Math.Round(objEstadistica.media_a, 2);
        }

        private void btnModa_Click(object sender, EventArgs e)
        {
            objEstadistica.moda(txtserie.Text.Split(','));
            lblModa.Text = "Moda: " + objEstadistica.respuesta;
        }
    }
}
