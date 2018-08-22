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
    public partial class FrmEmpresas : Form
    {
        public FrmEmpresas()
        {
            InitializeComponent();
        }

        ConexDBDataContext conexdb = new ConexDBDataContext();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();

            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "")
                {

                    MessageBox.Show("Llenar los campos en Blanco!");

                }
                else
                {
                    DtgvEmpresas.DataSource = conexdb.Sp_BuscarEmpresas(TbNombres.Text);

                }
               
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "")
                {

                    MessageBox.Show("Llenar los campos en Blanco!");

                }
                else
                {
                    conexdb.Sp_AgregarEmpresas(TbNombres.Text);
                    DtgvEmpresas.DataSource = conexdb.Sp_ConsultarEmpresas();
                    MessageBox.Show("Agregada con Exito!");
                    TbNombres.Text = string.Empty;
                    CbCodigoEmpresa.Text = string.Empty;
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
                if (TbNombres.Text == "" || CbCodigoEmpresa.Text == "")
                {

                    MessageBox.Show("Llenar los campos en Blanco y seleccionar el Codigo o Escribirlo!");

                }
                else
                {
                    conexdb.Sp_BorrarEmpresas(TbNombres.Text, Convert.ToInt16(CbCodigoEmpresa.Text));
                    DtgvEmpresas.DataSource = conexdb.Sp_ConsultarEmpresas();
                    MessageBox.Show("Borrada con Exito!");
                    TbNombres.Text = string.Empty;
                    CbCodigoEmpresa.Text = string.Empty;

                }
               

            }
            catch (Exception)
            {

                MessageBox.Show("No se puede borrar esta Empresa esta relacionada con Informaciones Importantes!");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TbNombres.Text == "" || CbCodigoEmpresa.Text == "")
                {

                    MessageBox.Show("Llenar los campos en Blanco y seleccionar el Codigo o Escribirlo!");

                }
                else
                {
                    conexdb.Sp_EditarEmpresas(TbNombres.Text, Convert.ToInt16(CbCodigoEmpresa.Text));
                    DtgvEmpresas.DataSource = conexdb.Sp_ConsultarEmpresas();
                    MessageBox.Show("Editada con Exito!");
                    TbNombres.Text = string.Empty;
                    CbCodigoEmpresa.Text = string.Empty;
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
            {
                DtgvEmpresas.DataSource = conexdb.Sp_ConsultarEmpresas();

            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet1.Empresas' Puede moverla o quitarla según sea necesario.
            this.empresasTableAdapter.Fill(this.dBInfosypDataSet1.Empresas);           
            CbCodigoEmpresa.Text = string.Empty;


        }

        private void DtgvEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgvEmpresas.CurrentRow == null)
                    return;

                DataGridViewRow row = DtgvEmpresas.CurrentRow;

                TbNombres.Text = row.Cells[1].Value.ToString();
                CbCodigoEmpresa.Text = row.Cells[0].Value.ToString();

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
                TbNombres.Text = string.Empty;
                CbCodigoEmpresa.Text = string.Empty;
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }
    }
}
