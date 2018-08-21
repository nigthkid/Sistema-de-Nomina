using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace RHInfosyp
{
    public partial class ReportedePagos : Form
    {
        public ReportedePagos()
        {
            InitializeComponent();
        }

        ConexDBDataContext conexdb = new ConexDBDataContext();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportedePagos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBInfosypDataSet6.Bancos' Puede moverla o quitarla según sea necesario.
            this.bancosTableAdapter.Fill(this.dBInfosypDataSet6.Bancos);

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (CbBancos.Text == "")
                {
                    MessageBox.Show("Elegir el Banco y la Fecha para Proceder con el Reporte!");

                }
                else
                {

                    string año = DtpFecha.Value.Year.ToString();
                    string dia = DtpFecha.Value.Day.ToString();
                    string mes = DtpFecha.Value.Month.ToString();

                    if (Convert.ToInt16(dia) < 10)
                    {
                        dia = "0" + DtpFecha.Value.Day.ToString();
                    }


                    if (Convert.ToInt16(mes) < 10 )
                    {
                        mes = "0" + DtpFecha.Value.Month.ToString();
                    }

                    string fecha = año + "-" + mes + "-" + dia; 

                    DtgvReportePagos.DataSource = conexdb.Sp_ReportePagos(CbBancos.Text,fecha);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {

            try
            {
                if (DtgvReportePagos.Rows.Count == 0)
                {
                    MessageBox.Show("Buscar el Reporte por Fecha y Banco. Luego lo Intentas de nuevo!");

                }
                else
                {

                    DtgvReportePagos.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DtgvReportePagos.MultiSelect = true;
                    DtgvReportePagos.SelectAll();
                    DataObject dataObj = DtgvReportePagos.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    Microsoft.Office.Interop.Excel.Application xlexcel;
                    Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                    Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;
                    MessageBox.Show("Documento en Proceso, esperar unos segundos!");
                    xlexcel = new Excel.Application();
                    xlexcel.Visible = true;
                    xlWorkBook = xlexcel.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                    Excel.Range rango = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    rango.Select();
                    xlWorkSheet.PasteSpecial(rango, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


                    // la primera fila en negrita, centrada y con fondo gris
                    Excel.Range fila1 = (Excel.Range)xlWorkSheet.Rows[1];
                    fila1.Select();
                    fila1.EntireRow.Font.Bold = true;
                    fila1.EntireRow.HorizontalAlignment = HorizontalAlignment.Center;
                    fila1.EntireRow.Interior.Color = Color.Gray;

                    // si la primera celda de la primera columna está vacía, elimino la primera columna
                    // esto se puede omitir, pero lo dejo para ver cómo se podrían añadir/eliminar datos a posteriori
                    Excel.Range c1f1 = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    if (c1f1.Text == "")
                    {
                        Excel.Range columna1 = (Excel.Range)xlWorkSheet.Columns[1];
                        columna1.Select();
                        columna1.Delete();
                    }

                    // selecciono la primera celda de la primera columna
                    Excel.Range c1 = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    c1.Select();

                    DtgvReportePagos.ClearSelection();
                    DtgvReportePagos.MultiSelect = false;

                    
                    

                }

            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
