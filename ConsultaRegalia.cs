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
    public partial class ConsultaRegalia : Form
    {
        public ConsultaRegalia()
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

                    DtgvConsultaRegalias.DataSource = conexdb.Sp_ConsultaRegalia(codigoempleado, TbNombre.Text);


                }




            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
