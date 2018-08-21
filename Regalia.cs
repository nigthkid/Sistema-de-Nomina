using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RHInfosyp
{
    public partial class Regalia : Form
    {
        public Regalia()
        {
            InitializeComponent();
        }

        private void BtnConsultaRegalia_Click(object sender, EventArgs e)
        {
            //Llamada al Formulario Consulta Regalia
            ConsultaRegalia cr = new ConsultaRegalia();
            cr.Show();
        }

        private void BtnRegistrarRegalia_Click(object sender, EventArgs e)
        {
            //Llamada al Formulario Registrar Regalia
            RegistrarRegalia rr = new RegistrarRegalia();
            rr.Show();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
