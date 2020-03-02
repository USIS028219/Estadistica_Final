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
    public partial class conversores : Form
    {
        
        Conversiones objConversor = new Conversiones();
        public conversores()
        {
            InitializeComponent();
        }
        private void cbotipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbode.Items.Clear();
                cboa.Items.Clear();

                cbode.Items.AddRange(objConversor.conversor[cbotipo.SelectedIndex]);
                cboa.Items.AddRange(objConversor.conversor[cbotipo.SelectedIndex]);
            }catch(Exception ex) {
                MessageBox.Show("Algo fue mal, por favor intentelo mas tarde...", "Conversores",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnconvertir_Click(object sender, EventArgs e)
        {
            try
            {
                lblrespuesta.Text = objConversor.convertir(cbotipo.SelectedIndex, cbode.SelectedIndex,
                    cboa.SelectedIndex, double.Parse(txtcantidad.Text)).ToString();

                errorProvider1.SetError(txtcantidad, "");


            }
            catch (Exception ex) {
                errorProvider1.SetError(txtcantidad, "Por favor dijite la cantidad");
                //MessageBox.Show("Ingrese los valores correspondiente.","Conversores",
                  //  MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
