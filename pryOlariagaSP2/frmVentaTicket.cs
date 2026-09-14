using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
               lstRegistro.Items.Add("Ticket N°: " + txtNumero.Text + " - Tipo: " + cmbTickets.SelectedItem.ToString() + " - Fecha: " + DateTime.Now.ToString("yyyy-MM-dd"));
               txtNumero.Clear();
               cmbTickets.Text = "";
                }
                    
              
            }


        }
    }
}
