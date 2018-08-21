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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario de Pagos
            FrmPagos pgs = new FrmPagos();
            pgs.Show();

        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario de Empleados
            FrmEmpleados emp = new FrmEmpleados();
            emp.Show();
        }

        private void BtnEmpresas_Click(object sender, EventArgs e)
        {  ////Llamada del Formulario de Empresas
            FrmEmpresas empr = new FrmEmpresas();
            empr.Show();
        }

        private void BtnBancos_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario de Bancos
            FrmBancos bnc = new FrmBancos();
            bnc.Show();
        }

        private void BtnSeguros_Click(object sender, EventArgs e)
        {   ////Llamada del Formulario de Seguros
            FrmSeguros sgr = new FrmSeguros();
            sgr.Show();
        }


        private void BtnSalir_Click_1(object sender, EventArgs e)
        {   ///Para salir del Formulario
            this.Close();
        }
    }
}
