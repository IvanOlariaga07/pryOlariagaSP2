using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryOlariagaSP2
{
    public partial class frmVentaTicket : Form
    {
        public frmVentaTicket()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if ( txtNumero.Text == "")

            MessageBox.Show("Debe ingresar un número de ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
              if (cmbTickets.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              else
              {
               lstRegistro.Items.Add("Ticket N°: " + txtNumero.Text + " - Tipo: " + cmbTickets.SelectedItem.ToString() + " - Fecha: " + DateTime.Now.ToString("dd-MM-yyyy"));
               txtNumero.Clear();
               cmbTickets.Text = "";
                }
                    
              
            }
            //variables
            string numero= txtNumero.Text;
            string tipo= cmbTickets.Text;
            string fecha = dtmFecha.Text;
                //mensaje
            string linea = numero + " - " + tipo + " - " + fecha + " - ";

            //Limpiar
            txtNumero. Clear();
            cmbTickets.SelectedIndex = -1;

            //desahilitar

            cmbTickets.Enabled = false;
            btnRegistrar.Enabled = false;

            //focus
            txtNumero.Focus();

            //crear archivo


            lstRegistro.Items.Add(linea);
            StreamWriter sw = new StreamWriter("MiArchivoOculto.xxx", true);
            sw.WriteLine(linea);
            sw.Close();
            txtNumero.Clear() ;
            cmbTickets .SelectedIndex = -1 ;
            txtNumero.Focus();

        }
    }
}
