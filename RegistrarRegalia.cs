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
    public partial class RegistrarRegalia : Form
    {
        public RegistrarRegalia()
        {
            InitializeComponent();
        }


        ConexDBDataContext conexdb = new ConexDBDataContext();
        int codigoempleado = 0;
        int contadorNoRepetirRegistro = 0;
        string mes = "Diciembre";
        int contadorSueldosCobrados = 0;
        decimal sueldouno = 0;
        decimal sueldodos = 0;
        decimal sueldotres = 0;
        decimal sueldocuatro = 0;
        decimal sueldocinco = 0;
        decimal sueldoseis = 0;
        decimal sueldosiete = 0;
        decimal sueldoocho = 0;
        decimal sueldonueve = 0;
        decimal sueldodiez = 0;
        decimal sueldoonce = 0;
        decimal sueldodoce = 0;
        decimal sueldotrece = 0;
        decimal sueldocatorce = 0;
        decimal sueldoquince = 0;
        decimal sueldodieciseis = 0;
        decimal sueldodiecisiete = 0;
        decimal sueldodieciocho = 0;
        decimal sueldodiecinueve = 0;
        decimal sueldoveinte = 0;
        decimal sueldoveintiuno = 0;
        decimal sueldoveintidos = 0;
        decimal sueldoveintitres = 0;
        decimal sueldoveinticuatro = 0;

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
                    MessageBox.Show("Para buscar solo Necesita el Nombre y la Cedula del Empleado!");
                }
                else
                {
                    var query = from emp in conexdb.Empleados
                                join bc in conexdb.Bancos on emp.BancoID equals bc.Id
                                where emp.Nombres.Contains(TbNombre.Text) && emp.Cedula == TbCedula.Text
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

                        TbNombre.Text = item.nombresemp.ToString();
                        TbApellidos.Text = item.apelliemp.ToString();
                        TbSueldoFijo.Text = item.sueldof.ToString();
                        TbCuentadeBanco.Text = item.cuentaemp.ToString();
                        TbBanco.Text = item.bancoemp.ToString();
                        codigoempleado = Convert.ToInt16(item.idempleado.ToString());

                    }
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
            decimal AcumuladorSueldo = 0;           
            decimal sumatoriaSueldos = 0;
            


            try
            {
                if (contadorNoRepetirRegistro == 0)
                {
                    if (TbNombre.Text == "" || TbApellidos.Text == "" || TbCedula.Text == "" ||
                        TbSueldoFijo.Text == "" || TbCuentadeBanco.Text == "" || TbBanco.Text == "")
                    {
                        MessageBox.Show("Llenar los campos con el Asterisco (*) para registrar el Pago Regalia!");
                    }
                    else
                    {
                        var query = from pag in conexdb.Pagos
                                    where pag.EmpleadoID == codigoempleado &&
                                    pag.Fecha.ToString().Contains(DtpDesde.Value.Year.ToString())
                                    select new
                                    {
                                        sueldoempleado = pag.SueldoBruto

                                    };


                        foreach (var item in query)
                        {

                            AcumuladorSueldo = Convert.ToDecimal(item.sueldoempleado.ToString());

                            sumatoriaSueldos = sumatoriaSueldos + AcumuladorSueldo;

                            contadorSueldosCobrados++;

                            //Almacenando lo sueldos
                            if (contadorSueldosCobrados == 1)
                            {
                                sueldouno = AcumuladorSueldo;

                            }
                            else if (contadorSueldosCobrados == 2)
                            {
                                sueldodos = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 3)
                            {
                                sueldotres = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 4)
                            {
                                sueldocuatro = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 5)
                            {
                                sueldocinco = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 6)
                            {
                                sueldoseis = AcumuladorSueldo;

                            }
                            else if (contadorSueldosCobrados == 7)
                            {
                                sueldosiete = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 8)
                            {
                                sueldoocho = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 9)
                            {
                                sueldonueve = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 10)
                            {
                                sueldodiez = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 11)
                            {
                                sueldoonce= AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 12)
                            {
                                sueldodoce = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 13)
                            {
                                sueldotrece = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 14)
                            {
                                sueldocatorce = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 15)
                            {
                                sueldoquince = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 16)
                            {
                                sueldodieciseis = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 17)
                            {
                                sueldodiecisiete = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 18)
                            {
                                sueldodieciocho = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 19)
                            {
                                sueldodiecinueve = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 20)
                            {
                                sueldoveinte = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 21)
                            {
                                sueldoveintiuno = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 22)
                            {
                                sueldoveintidos = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 23)
                            {
                                sueldoveintitres = AcumuladorSueldo;
                            }
                            else if (contadorSueldosCobrados == 24)
                            {
                                sueldoveinticuatro = AcumuladorSueldo;
                            }

                        }



                        TbTotalBruto.Text = Convert.ToString(sumatoriaSueldos);

                        RegaliaAcumulada.Text = Convert.ToString(sumatoriaSueldos / 12);

                        TotalCobrar.Text = RegaliaAcumulada.Text;

                        conexdb.Sp_AgregarRegalia(Convert.ToDecimal(TotalCobrar.Text), codigoempleado);
                        contadorNoRepetirRegistro++;

                        MessageBox.Show("Regalia Registrada!");
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

            try
            {
                if (TbNombre.Text == "" || TbApellidos.Text == "" || TbCedula.Text == "" ||
                        TbSueldoFijo.Text == "" || TbCuentadeBanco.Text == "" || TbBanco.Text == "" || 
                        TbTotalBruto.Text == "" || RegaliaAcumulada.Text == "" || TotalCobrar.Text == ""
                        )
                {
                    MessageBox.Show("Registra el Pago Regalia Primero y intentalo nuevamente!");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Llenaste las Fechas del Periodo?", "Mensaje", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Yes)
                    {
                        string path = @"c:\ReporteRegalia\";
                        if (Directory.Exists(path))
                        {
                            using (var document = DocX.Create(path + "ReporteRegaliaWord.docx"))
                            {

                                var image = document.AddImage(path + "LogoInfosyp.png");
                                var picture = image.CreatePicture(140, 708);
                                var p = document.InsertParagraph();
                                p.AppendPicture(picture);
                                document.InsertParagraph();

                                document.InsertParagraph("Pago Servicios Profesional").Font(new Xceed.Words.NET.Font("Times New Roman"))
                                    .FontSize(20d).Color(Color.Blue).Bold().Alignment = Alignment.center;
                                document.InsertParagraph();

                                decimal nletra = Convert.ToDecimal(TotalCobrar.Text);
                                TbTotalCobrarEscrito.Text = nletra.Numeroletras();

                                document.InsertParagraph("Yo " + TbNombre.Text + " " + TbApellidos.Text + " certifico haber recibido el depósito en el Banco " +
                                    TbBanco.Text + " a la cuenta No. " + TbCuentadeBanco.Text + " por la cantidad de dinero RD$" + TotalCobrar.Text +
                                  " (" + TbTotalCobrarEscrito.Text + "),").Font(new Xceed.Words.NET.Font("Times New Roman")).Color(Color.Blue);


                                document.InsertParagraph(" correspondiente al pago de Regalía acumulada por Servicios Profesionales prestados en el periodo " + DtpDesde.Value.Day.ToString() + "-" +
                                    DtpDesde.Value.Month.ToString() + "-" + DtpDesde.Value.Year.ToString() + " al " +
                                    DtpHasta.Value.Day.ToString() + "-" + DtpHasta.Value.Month.ToString() + "-" + DtpHasta.Value.Year.ToString() + " año de contrato vigente.").Font(new Xceed.Words.NET.Font("Times New Roman"));

                                document.InsertParagraph();


                                document.InsertParagraph("Detalle de Pago de Regalía.").Font(new Xceed.Words.NET.Font("Times New Roman"));
                                document.InsertParagraph();

                                //Cuadro

                                var table = document.InsertTable(1, 4);

                                table.AutoFit = AutoFit.Window;
                                var border = new Xceed.Words.NET.Border(Xceed.Words.NET.BorderStyle.Tcbs_single, BorderSize.one, 0, Color.Black);
                                table.SetBorder(TableBorderType.InsideH, border);
                                table.SetBorder(TableBorderType.Bottom, border);
                                table.SetBorder(TableBorderType.InsideV, border);
                                table.SetBorder(TableBorderType.Left, border);
                                table.SetBorder(TableBorderType.Right, border);
                                table.SetBorder(TableBorderType.Top, border);


                                var tableHeader = table.Rows[0];
                                tableHeader.Cells[0].InsertParagraph().Append("Fecha").Bold();
                                tableHeader.Cells[1].InsertParagraph().Append("Sueldo Bruto").Bold();
                                tableHeader.Cells[2].InsertParagraph().Append("Monto").Bold();
                                tableHeader.Cells[3].InsertParagraph().Append("Neto Pagar").Bold();


                                var tableRow = table.InsertRow();

                                if (contadorSueldosCobrados == 1)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();


                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");


                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 2)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();
                                }
                                else if (contadorSueldosCobrados == 3)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();
                                }
                                else if (contadorSueldosCobrados == 4)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();
                                }
                                else if (contadorSueldosCobrados == 5)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();
                                }
                                else if (contadorSueldosCobrados == 6)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 7)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 8)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 9)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();


                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 10)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 11)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();


                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 12)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 13)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 14)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 15)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 16)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 17)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 18)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 19)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecinueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 20)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveinte).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 21)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveinte).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintiuno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();

                                }
                                else if (contadorSueldosCobrados == 22)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveinte).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintiuno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintidos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();


                                }
                                else if (contadorSueldosCobrados == 23)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Diciembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveinte).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintiuno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintidos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintitres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();


                                }
                                else if (contadorSueldosCobrados == 24)
                                {
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Enero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 28 de Febrero " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Marzo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Abril " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Mayo " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Junio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Julio " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Agosto " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Septiembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Octubre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 30 de Noviembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 01 al 15 de Diciembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append("Desde 16 al 31 de Diciembre " + DtpDesde.Value.Year.ToString());
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("Sub. Total Bruto ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append("Regalía Acumulada ").Bold();
                                    tableRow.Cells[0].InsertParagraph().Append(" ");
                                    tableRow.Cells[0].InsertParagraph().Append("    TOTAL A PAGAR").Bold();

                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldouno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocinco).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldosiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoocho).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldonueve).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiez).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoonce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodoce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldotrece).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldocatorce).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoquince).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodieciseis).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldodiecisiete).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveinte).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintiuno).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintidos).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveintitres).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("RD$" + sueldoveinticuatro).Bold();
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");
                                    tableRow.Cells[1].InsertParagraph().Append("");

                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + TbTotalBruto.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append("RD$" + RegaliaAcumulada.Text).Bold();
                                    tableRow.Cells[2].InsertParagraph().Append(" ");
                                    tableRow.Cells[2].InsertParagraph().Append(" ");

                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append(" ");
                                    tableRow.Cells[3].InsertParagraph().Append("RD$" + TotalCobrar.Text).Bold();


                                }


                                document.InsertParagraph();
                                document.InsertParagraph("Hecho y firmado en Santo Domingo, Distrito Nacional de la República Dominicana, a los "
                                + "(" + DateTime.Today.Day.ToString() + ")" + " días del mes de " + mes +
                                " del año " + DtpHasta.Value.Year.ToString()).Font(new Xceed.Words.NET.Font("Times New Roman"));
                                document.InsertParagraph();


                                document.InsertParagraph("_________________________________     ___________________________________").Color(Color.Blue);
                                document.InsertParagraph("Sr. " + TbNombre.Text + " " + TbApellidos.Text + "        " + "Sr. José Abraham Cocco Risk")
                                    .Font(new Xceed.Words.NET.Font("Times New Roman"))
                                    .Color(Color.Blue);




                                document.Save();


                                MessageBox.Show("Documento listo!");
                            }
                        }
                        else
                        {

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

                if (TbNombre.Text == "" || TbApellidos.Text == "" || TbCedula.Text == "" ||
                        TbSueldoFijo.Text == "" || TbCuentadeBanco.Text == "" || TbBanco.Text == "" ||
                        TbTotalBruto.Text == "" || RegaliaAcumulada.Text == "" || TotalCobrar.Text == "" ||
                        TbTotalCobrarEscrito.Text == "")
                {
                    MessageBox.Show("Registra el Pago Regalia en Word Primero y intentalo nuevamente!");
                }
                else
                {
                    Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                    MessageBox.Show("Esperar unos segundos Documento en proceso!");
                    WordDocument = appWord.Documents.Open(@"C:\ReporteRegalia\ReporteRegaliaWord.docx");
                    WordDocument.ExportAsFixedFormat(@"C:\ReporteRegalia\ReporteRegaliaPDF.pdf", WdExportFormat.wdExportFormatPDF);
                    WordDocument.Close();
                    appWord.Quit();



                    MessageBox.Show("Documento en PDF Listo!");
                }

                



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
                TbNombre.Text = "";
                TbApellidos.Text = "";
                TbCedula.Text = "";
                TbSueldoFijo.Text = "";
                TbCuentadeBanco.Text = "";
                TbBanco.Text = "";
                TbTotalBruto.Text = "";
                RegaliaAcumulada.Text = "";                
                TotalCobrar.Text = "";
                TbTotalCobrarEscrito.Text = "";


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void RegistrarRegalia_Load(object sender, EventArgs e)
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
