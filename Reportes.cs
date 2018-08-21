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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReportePagos_Click(object sender, EventArgs e)
        {
            //Llamada al Formulario de Reporte de Pagos
            ReportedePagos rdp = new ReportedePagos();
            rdp.Show();

        }

        private void BtnReporteRegalia_Click(object sender, EventArgs e)
        {
            //Llamada al Formulario de Reporte de Regalias
            ReportedeRegalias rdr = new ReportedeRegalias();
            rdr.Show();

        }
    }
}
