using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Xceed.Words.NET;
using Microsoft.Office.Interop.Word;


namespace RHInfosyp
{
    public partial class RegistrarPago : Form
    {
        public RegistrarPago()
        {
            InitializeComponent();
        }

        ConexDBDataContext conexdb = new ConexDBDataContext();
        int codigoempleado = 0;
        int contadorNoRepetirRegistro = 0;
        string mes = "";
        string adicional = "0";





        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal resultadoSmensual = 0;

                if (TbNombres.Text == "" || TbCedula.Text == "")
                {
                    MessageBox.Show("Para buscar necesita el Nombre y la Cedula del Empleado!");

                }
                else
                {
                    var query = from emp in conexdb.Empleados
                                join bc in conexdb.Bancos on emp.BancoID equals bc.Id
                                where emp.Nombres.Contains(TbNombres.Text) && emp.Cedula == TbCedula.Text
                                select new
                                {
                                    idempleado = emp.Id,
                                    nombresemp = emp.Nombres,
                                    apelliemp = emp.Apellidos,
                                    sueldof = emp.Sueldo_Fijo,
                                    cuentaemp = emp.No_Cuenta,
                                    bancoemp = bc.Nombre
                                };

                    foreach (var item in query)
                    {
                        

                        TbNombres.Text = item.nombresemp.ToString();
                        TbApellidos.Text = item.apelliemp.ToString();
                        TbSueldoFijo.Text = item.sueldof.ToString();
                        TbCuentaBanco.Text = item.cuentaemp.ToString();
                        resultadoSmensual = Convert.ToDecimal(TbSueldoFijo.Text) * 2;
                        TbSueldoMensual.Text = Convert.ToString(resultadoSmensual);
                        TbBanco.Text = item.bancoemp.ToString();
                        codigoempleado = Convert.ToInt16(item.idempleado.ToString());

                    }

                    double calculoImpuesto = 0;

                    calculoImpuesto = Convert.ToDouble(TbSueldoFijo.Text) * 0.06;
                    TbMontoRetencion.Text = Convert.ToString(calculoImpuesto);

                }

                if (codigoempleado == 0)
                {
                    MessageBox.Show("Revisar el Nombre o la Cedula que este correcta!");

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {                

                if (contadorNoRepetirRegistro == 0)
                {
                    if (TbNombres.Text == "" || TbApellidos.Text == "" || TbCedula.Text == "" || TbSueldoFijo.Text == "" || 
                        TbCuentaBanco.Text =="" || TbBanco.Text == "")
                    {
                        MessageBox.Show("Llenar los campos con el Asterisco (*) para registrar el Pago!");
                    }
                    else
                    {
                        
                        decimal resultado = 0;
                        decimal resultadoNeto = 0;

                        DialogResult resultadoDecision = MessageBox.Show("El Descuento Seguro se le resta al Empleado?", "Mensaje", MessageBoxButtons.YesNo);

                        if (resultadoDecision == DialogResult.Yes)
                        {
                            resultado = Convert.ToDecimal(TbSueldoFijo.Text) + Convert.ToDecimal(TbHorasExtras.Text) + Convert.ToDecimal(TbBonoEspecial.Text) +
                            Convert.ToDecimal(adicional) - Convert.ToDecimal(TbMontoRetencion.Text) - Convert.ToDecimal(TbSeguroSalud.Text);
                           
                        }

                       else if (resultadoDecision == DialogResult.No)
                        {
                            resultado = Convert.ToDecimal(TbSueldoFijo.Text) + Convert.ToDecimal(TbHorasExtras.Text) + Convert.ToDecimal(TbBonoEspecial.Text) +
                            Convert.ToDecimal(adicional) - Convert.ToDecimal(TbMontoRetencion.Text) + Convert.ToDecimal(TbSeguroSalud.Text);

                        }



                        DialogResult resultadoDecisionDos = MessageBox.Show("El Reembolso de Gastos se le resta al Empleado?", "Mensaje", MessageBoxButtons.YesNo);

                        if (resultadoDecisionDos == DialogResult.Yes)
                        {
                            resultado = resultado - Convert.ToDecimal(TbReembolsoGastos.Text);
                           

                        }

                        else if (resultadoDecisionDos == DialogResult.No)
                        {
                            resultado = resultado + Convert.ToDecimal(TbReembolsoGastos.Text);
                           

                        }

                        TbTotalCobrar.Text = Convert.ToString(resultado);


                        //resultado = Convert.ToDecimal(TbSueldoFijo.Text) + Convert.ToDecimal(TbHorasExtras.Text) + Convert.ToDecimal(TbBonoEspecial.Text) +
                            //Convert.ToDecimal(adicional) + Convert.ToDecimal(TbReembolsoGastos.Text) -
                            //Convert.ToDecimal(TbMontoRetencion.Text) - Convert.ToDecimal(TbSeguroSalud.Text);
                        //TbTotalCobrar.Text = Convert.ToString(resultado);

                        resultadoNeto = Convert.ToDecimal(TbSueldoFijo.Text) - Convert.ToDecimal(TbMontoRetencion.Text);
                        TbNeto.Text = Convert.ToString(resultadoNeto);

                        conexdb.SP_AgregarPagos(Convert.ToDecimal(TbMontoRetencion.Text), Convert.ToDecimal(TbTotalCobrar.Text), Convert.ToDecimal(TbReembolsoGastos.Text),
                            Convert.ToDecimal(TbHorasExtras.Text), Convert.ToDecimal(TbBonoEspecial.Text), Convert.ToDecimal(TbSeguroSalud.Text), Convert.ToDecimal(adicional),
                            codigoempleado,Convert.ToDecimal(TbSueldoFijo.Text));

                        MessageBox.Show("Pago registrado con Exito!");

                        DtgvRegistrarPago.DataSource = conexdb.ConsultaPagoRegistrado(codigoempleado);
                        contadorNoRepetirRegistro++;
                    }

                   
                }
                else
                {
                    MessageBox.Show("No se puede registrar el mismo Pago, Precionar el Boton limpiar y registre otro nuevo!");

                }

               
                      

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BtnWord_Click(object sender, EventArgs e)
        {
            if (DtpFechaCobroHasta.Value.Month == 1)
            {
                mes = "Enero";

            }
            else if (DtpFechaCobroHasta.Value.Month == 2)
            {
                mes = "Febrero";
            }

            else if (DtpFechaCobroHasta.Value.Month == 3)
            {
                mes = "Marzo";

            }
            else if (DtpFechaCobroHasta.Value.Month == 4)
            {
                mes = "Abril";
            }

            else if (DtpFechaCobroHasta.Value.Month == 5)
            {
                mes = "Mayo";

            }
            else if (DtpFechaCobroHasta.Value.Month == 6)
            {
                mes = "Junio";
            }
            else if (DtpFechaCobroHasta.Value.Month == 7)
            {
                mes = "Julio";
            }

            else if (DtpFechaCobroHasta.Value.Month == 8)
            {
                mes = "Agosto";

            }
            else if (DtpFechaCobroHasta.Value.Month == 9)
            {
                mes = "Septiembre";
            }
            else if (DtpFechaCobroHasta.Value.Month == 10)
            {
                mes = "Octubre";
            }

            else if (DtpFechaCobroHasta.Value.Month == 11)
            {
                mes = "Noviembre";

            }
            else if (DtpFechaCobroHasta.Value.Month == 12)
            {
                mes = "Diciembre";
            }


            try
            {

                if (CbFechaCobroDesde.Text=="")
                {
                    MessageBox.Show("Seleccionar la Fecha DESDE antes de pasar el Reporte a Documento Word!");
                }
                else
                {
                    string path = @"c:\ReportePagos2\";
                    if (Directory.Exists(path))
                    {
                        using (var document = DocX.Create(path + "ReportePagoWord.docx"))
                        {

                            document.InsertParagraph("Pago Servicios Profesional").Font(new Xceed.Words.NET.Font("Times New Roman"))
                                .FontSize(20d).Color(Color.Blue).Bold().Alignment = Alignment.center;
                            document.InsertParagraph();

                            string SueldoEscrito = "";
                            decimal nletra = Convert.ToDecimal(SueldoEscrito);
                            SueldoEscrito = nletra.Numeroletras();

                            document.InsertParagraph("Yo " + TbNombres.Text + " " + TbApellidos.Text + " certifico haber recibido el depósito en el Banco " +
                                TbBanco.Text + " a la cuenta No. " + TbCuentaBanco.Text + " por la cantidad de dinero RD$" + TbTotalCobrar.Text +
                              " (" + SueldoEscrito + ")"
                                + " correspondiente al pago de Servicios Profesionales prestados en el periodo desde " + CbFechaCobroDesde.Text + " al " +
                                DtpFechaCobroHasta.Value.Day.ToString() + " de " + mes +
                                " del " + DtpFechaCobroHasta.Value.Year.ToString() + " año de contrato vigente.").Font(new Xceed.Words.NET.Font("Times New Roman")).Color(Color.Blue);
                            document.InsertParagraph();

                            document.InsertParagraph("Ajuste por Descuento TSS contributiva 6 % correspondiente al periodo aquí pagado por" +
                            " un monto RD$" + TbMontoRetencion.Text).Font(new Xceed.Words.NET.Font("Times New Roman")).Color(Color.Blue);
                            document.InsertParagraph();

                            document.InsertParagraph("Detalle de Pago de Quincena.").Font(new Xceed.Words.NET.Font("Times New Roman")).Color(Color.Blue);
                            document.InsertParagraph();

                            //Cuadro

                            var table = document.InsertTable(1,4);

                            table.AutoFit = AutoFit.Window;
                            var border = new Xceed.Words.NET.Border(Xceed.Words.NET.BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Black);
                            table.SetBorder(TableBorderType.InsideH, border);
                            table.SetBorder(TableBorderType.Bottom, border);
                            table.SetBorder(TableBorderType.InsideV, border);
                            table.SetBorder(TableBorderType.Left, border);
                            table.SetBorder(TableBorderType.Right, border);
                            table.SetBorder(TableBorderType.Top, border);
                            

                            var tableHeader = table.Rows[0];
                            tableHeader.Cells[0].InsertParagraph().Append("Fecha").Color(Color.Blue).Bold();
                            tableHeader.Cells[1].InsertParagraph().Append("Monto").Color(Color.Blue).Bold();
                            tableHeader.Cells[2].InsertParagraph().Append("Impuesto").Color(Color.Blue).Bold();
                            tableHeader.Cells[3].InsertParagraph().Append("Neto").Color(Color.Blue).Bold();

                            ///Desde 01 al 15 de julio del 2018
                              var tableRow = table.InsertRow();

                            tableRow.Cells[0].InsertParagraph().Append("Desde " + CbFechaCobroDesde.Text + " al " +
                            DtpFechaCobroHasta.Value.Day.ToString() + " de " + DtpFechaCobroHasta.Value.Month.ToString() +
                            " del " + DtpFechaCobroHasta.Value.Year.ToString()).Color(Color.Blue);

                            

                            if (TbSeguroSalud.Text == "" || TbSeguroSalud.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[0].InsertParagraph().Append("____________________________");
                                tableRow.Cells[0].InsertParagraph().Append("Seguro de Salud").Color(Color.Blue);
                            }


                            if (TbHorasExtras.Text == "" || TbHorasExtras.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[0].InsertParagraph().Append("____________________________");
                                tableRow.Cells[0].InsertParagraph().Append("Horas Extras").Color(Color.Blue);
                            }

                            if (TbBonoEspecial.Text == "" || TbBonoEspecial.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[0].InsertParagraph().Append("____________________________");
                                tableRow.Cells[0].InsertParagraph().Append("Bono Especial").Color(Color.Blue);
                            }

                            if (adicional == "" || adicional == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[0].InsertParagraph().Append("____________________________");
                                tableRow.Cells[0].InsertParagraph().Append("Adicional").Color(Color.Blue);
                            }

                            if (TbReembolsoGastos.Text == "" || TbReembolsoGastos.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[0].InsertParagraph().Append("____________________________");
                                tableRow.Cells[0].InsertParagraph().Append("Reembolso de Gastos").Color(Color.Blue);
                            }

                            tableRow.Cells[0].InsertParagraph().Append("____________________________");
                            tableRow.Cells[0].InsertParagraph().Append("TOTAL").Color(Color.Blue).Bold();      

                            tableRow.Cells[1].InsertParagraph().Append("RD$" + TbSueldoFijo.Text).Color(Color.Blue);
                            tableRow.Cells[1].InsertParagraph().Append("____________________________");

                            tableRow.Cells[2].InsertParagraph().Append("RD$" + TbMontoRetencion.Text).Color(Color.Blue);
                            tableRow.Cells[2].InsertParagraph().Append("________");

                            decimal sueldoneto = Convert.ToDecimal(TbSueldoFijo.Text) - Convert.ToDecimal(TbMontoRetencion.Text);
                            Convert.ToString(sueldoneto);

                            tableRow.Cells[3].InsertParagraph().Append("RD$" + sueldoneto).Color(Color.Blue);


                            if (TbSeguroSalud.Text == "" || TbSeguroSalud.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[3].InsertParagraph().Append("___________");
                                tableRow.Cells[3].InsertParagraph().Append("RD$" + TbSeguroSalud.Text).Color(Color.Blue);
                            }


                            if (TbHorasExtras.Text == "" || TbHorasExtras.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[3].InsertParagraph().Append("___________");
                                tableRow.Cells[3].InsertParagraph().Append("RD$" + TbHorasExtras.Text).Color(Color.Blue);
                            }

                            if (TbBonoEspecial.Text == "" || TbBonoEspecial.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[3].InsertParagraph().Append("___________");
                                tableRow.Cells[3].InsertParagraph().Append("RD$" + TbBonoEspecial.Text).Color(Color.Blue);
                            }

                            if (adicional == "" || adicional == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[3].InsertParagraph().Append("___________");
                                tableRow.Cells[3].InsertParagraph().Append("RD$" + adicional).Color(Color.Blue);
                            }

                            if (TbReembolsoGastos.Text == "" || TbReembolsoGastos.Text == "0")
                            {

                            }
                            else
                            {
                                tableRow.Cells[3].InsertParagraph().Append("___________");
                                tableRow.Cells[3].InsertParagraph().Append("RD$" + TbReembolsoGastos.Text).Color(Color.Blue);
                            }


                            tableRow.Cells[3].InsertParagraph().Append("___________");
                            tableRow.Cells[3].InsertParagraph().Append("RD$" + TbTotalCobrar.Text).Color(Color.Blue);



                            document.InsertParagraph();
                            document.InsertParagraph("Hecho y firmado en Santo Domingo, Distrito Nacional de la República Dominicana, a los "
                            + "(" + DtpFechaCobroHasta.Value.Day.ToString() + ")" + " días del mes de " + mes +
                            " del año " + DtpFechaCobroHasta.Value.Year.ToString()).Font(new Xceed.Words.NET.Font("Times New Roman")).Color(Color.Blue);
                            document.InsertParagraph();


                            document.InsertParagraph("_________________________________     ___________________________________").Color(Color.Blue);
                            document.InsertParagraph("Sr. " + TbNombres.Text + " " + TbApellidos.Text + "        " + "Sr. José Abraham Cocco Risk")
                                .Font(new Xceed.Words.NET.Font("Times New Roman"))
                                .Color(Color.Blue);




                            document.Save();

                            MessageBox.Show("Documento listo!");
                        }
                

                    }

                }       
            }
            catch (Exception)
            {

                MessageBox.Show("Cerrar el Documento y Intentarlo nuevamente!");
            }
        }

        private void BtnPDF_Click(object sender, EventArgs e)
        {


            try
            {



                Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                MessageBox.Show("Espere unos segundos, documento en Proceso!");
                WordDocument = appWord.Documents.Open(@"C:\ReportePagos2\ReportePagoWord.docx");
                WordDocument.ExportAsFixedFormat(@"C:\ReportePagos2\ReportePagosPDF.pdf", WdExportFormat.wdExportFormatPDF);
                WordDocument.Close();
                appWord.Quit();



                MessageBox.Show("Documento en PDF Listo!");



            }


            catch (Exception)
            {

                MessageBox.Show("Cerrar el Documento PDF e Intentelo nuevamente!");
            }

                       
           }

           public Microsoft.Office.Interop.Word.Document WordDocument { get; set; }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                TbNombres.Text = "";
                TbApellidos.Text = "";
                TbCedula.Text = "";
                TbSueldoFijo.Text = "";
                TbCuentaBanco.Text = "";
                TbHorasExtras.Text = "0";
                TbMontoRetencion.Text = "0";
                TbSeguroSalud.Text = "0";
                TbBonoEspecial.Text = "0";
                TbBanco.Text = "";                
                TbReembolsoGastos.Text = "0";
                TbTotalCobrar.Text = "0";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            TltpCedula.SetToolTip(TbCedula, "Introducir correctamente la Cedula!");
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

                throw;
            }
        }
    }
}
