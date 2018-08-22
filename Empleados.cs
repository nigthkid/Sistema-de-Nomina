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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        ConexDBDataContext conexdb = new ConexDBDataContext();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
          
            try
            {   //Cerrar formulario
                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet5.Bancos' Puede moverla o quitarla según sea necesario.
            this.bancosTableAdapter.Fill(this.dBInfosypDataSet5.Bancos);
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet4.Seguros' Puede moverla o quitarla según sea necesario.
            this.segurosTableAdapter.Fill(this.dBInfosypDataSet4.Seguros);
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet3.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.Fill(this.dBInfosypDataSet3.Empresas);
            CbBanco.Text = String.Empty;
            CbEmpresa.Text = String.Empty;
            CbSeguro.Text = String.Empty;

        }
               
       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "" ||
                 TbCedula.Text == ""
                )
                {
                    MessageBox.Show("Con el Nombre y la Cedula puedes buscar un Empleado!");


                }
                else
                {   //Buscar Empleado
                    DtgvEmpleados.DataSource = conexdb.Sp_BuscarEmpleados(TbNombres.Text, TbCedula.Text);

                }           

            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "" ||                
                TbCedula.Text == "" 
               )
                {
                    MessageBox.Show("Con el Nombre y la Cedula puedes Borrar un Empleado!");


                }
                else
                {
                    //Borrar empleado
                    conexdb.Sp_BorrarEmpleado(TbNombres.Text, TbCedula.Text);
                    DtgvEmpleados.DataSource = conexdb.Sp_ConsultaEmpleados();

                    MessageBox.Show("Empleado borrado con Exito!");

                    TbNombres.Text = String.Empty;
                    TbApellidos.Text = String.Empty;
                    TbEdad.Text = String.Empty;
                    TbSueldo.Text = String.Empty;
                    TbCedula.Text = String.Empty;
                    TbNoCuenta.Text = String.Empty;
                    TbPuesto.Text = String.Empty;
                    CbEmpresa.Text = String.Empty;
                    CbSeguro.Text = String.Empty;
                    CbBanco.Text = String.Empty;

                }
        

            }
            catch (Exception)
            {

                MessageBox.Show("El Empleado no se puede borrar esta relacionado con otras informaciones Importantes!");
            }

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "" ||
               TbApellidos.Text == "" ||
               TbEdad.Text == "" ||
               TbSueldo.Text == "" ||
               TbCedula.Text == "" ||
               TbNoCuenta.Text == "" ||
               TbPuesto.Text == "" ||
               CbEmpresa.Text == "" ||
               CbSeguro.Text == "" ||
               CbBanco.Text == "")
                {
                    MessageBox.Show("Llenar todos los campos en Blanco y que los Datos sean Correctos!");


                }
                else
                {
                    //Seleccionamos el id desde el Combobox

                    int idempresa = Convert.ToInt16(CbEmpresa.SelectedValue.ToString());
                    int idbanco = Convert.ToInt16(CbBanco.SelectedValue.ToString());
                    int idseguro = Convert.ToInt16(CbSeguro.SelectedValue.ToString());

                    //Editamos por medio del Stored Procedure al empleado
                    conexdb.Sp_EditarEmpleado(TbNombres.Text, TbApellidos.Text, Convert.ToInt16(TbEdad.Text), Convert.ToDecimal(TbSueldo.Text),
                        TbCedula.Text, TbNoCuenta.Text, TbPuesto.Text, idempresa, idseguro, idbanco);

                    //Cargamos la lista de empleados en el DataGridVieww
                    DtgvEmpleados.DataSource = conexdb.Sp_ConsultaEmpleados();


                    MessageBox.Show("Empleado editado con Exito!");

                    //Limpiamos los campos usados

                    TbNombres.Text = String.Empty;
                    TbApellidos.Text = String.Empty;
                    TbEdad.Text = String.Empty;
                    TbSueldo.Text = String.Empty;
                    TbCedula.Text = String.Empty;
                    TbNoCuenta.Text = String.Empty;
                    TbPuesto.Text = String.Empty;
                    CbEmpresa.Text = String.Empty;
                    CbSeguro.Text = String.Empty;
                    CbBanco.Text = String.Empty;
                }

               

            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try {

                if (TbNombres.Text == "" ||
                TbApellidos.Text == "" ||
                TbEdad.Text == "" ||
                TbSueldo.Text == "" ||
                TbCedula.Text == "" ||
                TbNoCuenta.Text == "" ||
                TbPuesto.Text == "" ||
                CbEmpresa.Text == "" ||
                CbSeguro.Text == "" ||
                CbBanco.Text == "" )
                {
                    MessageBox.Show("Llenar todos los campos en Blanco!");


                }
                else
                {
                    //Seleccionamos el id desde el Combobox
                    int idempresa = Convert.ToInt16(CbEmpresa.SelectedValue.ToString());
                    int idbanco = Convert.ToInt16(CbBanco.SelectedValue.ToString());
                    int idseguro = Convert.ToInt16(CbSeguro.SelectedValue.ToString());

                    //Agregamos por medio del Stored Procedure al empleado
                    conexdb.Sp_AgregarEmpleado(TbNombres.Text, TbApellidos.Text, Convert.ToInt16(TbEdad.Text), Convert.ToDecimal(TbSueldo.Text),
                       TbCedula.Text, TbNoCuenta.Text, TbPuesto.Text, idempresa, idseguro, idbanco);

                    //Cargamos la lista de empleados en el DataGridVieww
                    DtgvEmpleados.DataSource = conexdb.Sp_ConsultaEmpleados();

                    MessageBox.Show("Empleado agregado con Exito!");

                    //Limpiamos los campos usados

                    TbNombres.Text = String.Empty;
                    TbApellidos.Text = String.Empty;
                    TbEdad.Text = String.Empty;
                    TbSueldo.Text = String.Empty;
                    TbCedula.Text = String.Empty;
                    TbNoCuenta.Text = String.Empty;
                    TbPuesto.Text = String.Empty;
                    CbEmpresa.Text = String.Empty;
                    CbSeguro.Text = String.Empty;
                    CbBanco.Text = String.Empty;

                }


               
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {   //Consulta de Empleados
                DtgvEmpleados.DataSource = conexdb.Sp_ConsultaEmpleados();

            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void DtgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgvEmpleados.CurrentRow == null)
                    return;

                DataGridViewRow row = DtgvEmpleados.CurrentRow;

                TbNombres.Text = row.Cells[1].Value.ToString();
                TbApellidos.Text = row.Cells[2].Value.ToString();
                TbEdad.Text = row.Cells[3].Value.ToString(); ;
                TbSueldo.Text = row.Cells[4].Value.ToString(); ;
                TbCedula.Text = row.Cells[5].Value.ToString(); ;
                TbNoCuenta.Text = row.Cells[6].Value.ToString(); ;
                TbPuesto.Text = row.Cells[7].Value.ToString(); ;
                CbEmpresa.Text = row.Cells[9].Value.ToString(); ;
                CbSeguro.Text = row.Cells[10].Value.ToString(); ;
                CbBanco.Text = row.Cells[11].Value.ToString(); ;


            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }



        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TbNombres.Text = String.Empty;
                TbApellidos.Text = String.Empty;
                TbEdad.Text = String.Empty;
                TbSueldo.Text = String.Empty;
                TbCedula.Text = String.Empty;
                TbNoCuenta.Text = String.Empty;
                TbPuesto.Text = String.Empty;
                CbEmpresa.Text = String.Empty;
                CbSeguro.Text = String.Empty;
                CbBanco.Text = String.Empty;
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }
    }
}
