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
    public partial class FrmBancos : Form
    {
        public FrmBancos()
        {
            InitializeComponent();
        }
        ConexDBDataContext conexdb = new ConexDBDataContext();
        
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //Cerrar formulario Bancos
            this.Close();
        }

       

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "")
                {
                    MessageBox.Show("Escribir el Nombre correcto para buscar!");
                }
                else
                {
                    //Buscar Bancos
                    DtgvBanco.DataSource = conexdb.Sp_BuscarBancos(TbNombres.Text);
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
                if (TbNombres.Text == "" || CbEstatusBanco.Text == "")
                {
                    MessageBox.Show("Llenar los campos en Blanco y Seleccionar el Codigo del Banco!");
                }
                else
                {
                    //Borrar bancos
                    conexdb.Sp_BorrarBancos(TbNombres.Text, Convert.ToInt16(CbCodigoEmpresa.Text));
                    DtgvBanco.DataSource = conexdb.Sp_ConsultaBancos();
                    MessageBox.Show("Borrado con Exito!");
                    TbNombres.Text = string.Empty;
                    CbEstatusBanco.Text = string.Empty;
                    CbCodigoEmpresa.Text = string.Empty;
                }

               
            }
            catch (Exception)
            {

                MessageBox.Show("El Banco no se puede borrar esta relacionado con otras informaciones Importantes!");

            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "" || CbEstatusBanco.Text == "")
                {
                    MessageBox.Show("Llenar los campos en Blanco y Seleccionar el Codigo o Escribirlo!");
                }

                else
                {
                    //Editar Bancos
                    conexdb.Sp_EditarBancos(TbNombres.Text, CbEstatusBanco.Text, Convert.ToInt16(CbCodigoEmpresa.Text));
                    DtgvBanco.DataSource = conexdb.Sp_ConsultaBancos();
                    MessageBox.Show("Editado con Exito!");
                    TbNombres.Text = string.Empty;
                    CbEstatusBanco.Text = string.Empty;
                    CbCodigoEmpresa.Text = string.Empty;
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
                if (TbNombres.Text == "" || CbEstatusBanco.Text == "")
                {
                    MessageBox.Show("Llenar los campos en Blanco!");
                }
                else
                {
                    //Agregando Bancos
                    conexdb.Sp_AgregarBancos(TbNombres.Text, CbEstatusBanco.Text);
                    DtgvBanco.DataSource = conexdb.Sp_ConsultaBancos();
                    MessageBox.Show("Agregado con Exito!");
                    TbNombres.Text = "";
                    CbEstatusBanco.Text = "";
                }
                
               

            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void Bancos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet.Bancos' Puede moverla o quitarla según sea necesario.
            this.bancosTableAdapter.Fill(this.dBInfosypDataSet.Bancos);
            CbCodigoEmpresa.Text = string.Empty;

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {   //Consulta de Bancos
                DtgvBanco.DataSource = conexdb.Sp_ConsultaBancos();
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }

        private void DtgvBanco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgvBanco.CurrentRow == null)
                    return;

                DataGridViewRow row = DtgvBanco.CurrentRow;

                TbNombres.Text = row.Cells[1].Value.ToString();
                CbCodigoEmpresa.Text = row.Cells[0].Value.ToString();
                CbEstatusBanco.Text = row.Cells[3].Value.ToString();


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
                CbEstatusBanco.Text = string.Empty;
            }
            catch (Exception)
            {

                MessageBox.Show("Intentarlo nuevamente!");
            }
        }
    }
}
