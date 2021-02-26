using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteEscCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private ServiceReference1.SenamhiSoapClient servicio;


        private void btnconsulta_Click(object sender, EventArgs e)
        {
            servicio = new ServiceReference1.SenamhiSoapClient();
            dgvReporte.DataSource = servicio.ListarCiudades().Tables[0];
        }

        private void btnconsultaC_Click(object sender, EventArgs e)
        {
            string ciudad = txtCiudad.Text.Trim();
            servicio = new ServiceReference1.SenamhiSoapClient();
            dgvReporte.DataSource = servicio.ListarxCiudad(ciudad).Tables[0];
        }
    }
}
