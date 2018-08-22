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
    public partial class FrmSeguros : Form
    {
        public FrmSeguros()
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

                MessageBox.Show("Intentalo nuevamente!");
            }
           
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "")
                {
                    MessageBox.Show("Llenar los Campos en Blanco!");

                }
                else
                {
                    DtgvSeguro.DataSource = conexdb.Sp_BuscarSeguros(TbNombres.Text);
                }

                
            }
            catch (Exception)
            {

                MessageBox.Show("Intentalo nuevamente!"); 
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TbNombres.Text == "")
                {
                    MessageBox.Show("Llenar los Campos en Blanco!");

                }
                else
                {
                    conexdb.Sp_AgregarSeguros(TbNombres.Text);
                    DtgvSeguro.DataSource = conexdb.Sp_ConsultarSeguros();
                    MessageBox.Show("Agregada con Exito!");
                    TbNombres.Text = string.Empty;
                    
                }

               

            }
            catch (Exception)
            {

                MessageBox.Show("Intentalo nuevamente!");
            }


        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (TbNombres.Text == "" || CbCodigoSeguro.Text == "")
                {
                    MessageBox.Show("Llenar los Campos en Blanco y Seleccionar el Codigo o Escribirlo!");

                }
                else
                {
                    conexdb.Sp_BorrarSeguros(TbNombres.Text, Convert.ToInt16(CbCodigoSeguro.Text));
                    DtgvSeguro.DataSource = conexdb.Sp_ConsultarSeguros();
                    MessageBox.Show("Borrada con Exito!");
                    TbNombres.Text = string.Empty;
                    CbCodigoSeguro.Text = string.Empty;

                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("No se puede Borrar esta entidad esta relacionada con Informaciones Importantes!");
            }


        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TbNombres.Text == "" || CbCodigoSeguro.Text == "")
                {
                    MessageBox.Show("Llenar los Campos en Blanco y Seleccionar el Codigo o Escribirlo!");

                }
                else
                {
                    conexdb.Sp_EditarSeguros(TbNombres.Text, Convert.ToInt16(CbCodigoSeguro.Text));
                    DtgvSeguro.DataSource = conexdb.Sp_ConsultarSeguros();
                    MessageBox.Show("Editada con Exito!");
                    TbNombres.Text = string.Empty;
                    CbCodigoSeguro.Text = string.Empty;

                }
                

            }
            catch (Exception)
            {

                MessageBox.Show("No se puede Editar || Intentalo nuevamente!");
            }

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                DtgvSeguro.DataSource = conexdb.Sp_ConsultarSeguros();
               
            }
            catch (Exception)
            {

                MessageBox.Show("Intentalo nuevamente!");
            }

        }

        private void Seguros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet2.Seguros' Puede moverla o quitarla según sea necesario.
            this.segurosTableAdapter.Fill(this.dBInfosypDataSet2.Seguros);            
            CbCodigoSeguro.Text = string.Empty;

        }

        private void DtgvSeguro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DtgvSeguro.CurrentRow == null)
                    return;

                DataGridViewRow row = DtgvSeguro.CurrentRow;

                TbNombres.Text = row.Cells[1].Value.ToString();
                CbCodigoSeguro.Text = row.Cells[0].Value.ToString();

            }
            catch (Exception)
            {

                MessageBox.Show("Intentalo nuevamente!");
            }

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TbNombres.Text = string.Empty;
                CbCodigoSeguro.Text = string.Empty;
            }
            catch (Exception)
            {

                MessageBox.Show("Intentalo nuevamente!"); 
            }
        }
    }
}
