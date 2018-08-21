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
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void BtnConsultaPagos_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario Consulta de Pagos
            ConsultadePagos cdp = new ConsultadePagos();
            cdp.Show();
        }

        private void BtnRegistrarPago_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario Registrar Pago
            RegistrarPago rp = new RegistrarPago();
            rp.Show();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario Reportes
            Reportes r = new Reportes();
            r.Show();
        }


        private void BtnSalir_Click_1(object sender, EventArgs e)
        {   ///Para salir del Formulario
            this.Close();
        }

        private void BtnRegalia_Click(object sender, EventArgs e)
        {
            Regalia reg = new Regalia();
            reg.Show();
        }
    }
}
