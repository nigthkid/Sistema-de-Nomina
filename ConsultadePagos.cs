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
    public partial class ConsultadePagos : Form
    {
        public ConsultadePagos()
        {
            InitializeComponent();
        }
        ConexDBDataContext conexdb = new ConexDBDataContext();
        int codigoempleado = 0;
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (TbNombre.Text == "" || TbCedula.Text == "")
                {
                    MessageBox.Show("Llenar los campos en blancos para hacer la busqueda!");

                }
                else
                {


                    var query = from emp in conexdb.Empleados
                                where emp.Nombres.Contains(TbNombre.Text) && emp.Cedula == TbCedula.Text
                                select new
                                {
                                    idempleado = emp.Id
                                };

                    foreach (var item in query)
                    {


                        codigoempleado = Convert.ToInt16(item.idempleado.ToString());

                    }

                    DtgvConsultaPagos.DataSource =  conexdb.SP_ConsultaPago(codigoempleado,TbNombre.Text);


                }

            }

            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
           


}

private void BtnSalir_Click_1(object sender, EventArgs e)
        {

            try
            {
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }

        }

        private void BtnConsultarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEmpleados emp = new FrmEmpleados();
                emp.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }
    }
}
