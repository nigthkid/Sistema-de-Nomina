namespace RHInfosyp
{
    partial class ReportedePagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DtgvReportePagos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbBancos = new System.Windows.Forms.ComboBox();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet6 = new RHInfosyp.DBInfosypDataSet6();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bancosTableAdapter = new RHInfosyp.DBInfosypDataSet6TableAdapters.BancosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvReportePagos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvReportePagos
            // 
            this.DtgvReportePagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvReportePagos.Location = new System.Drawing.Point(127, 142);
            this.DtgvReportePagos.Name = "DtgvReportePagos";
            this.DtgvReportePagos.Size = new System.Drawing.Size(549, 145);
            this.DtgvReportePagos.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnExcel);
            this.groupBox2.Controls.Add(this.BtnAceptar);
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(255, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 66);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // BtnExcel
            // 
            this.BtnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcel.Location = new System.Drawing.Point(120, 15);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(98, 35);
            this.BtnExcel.TabIndex = 16;
            this.BtnExcel.Text = "&Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Location = new System.Drawing.Point(6, 15);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(98, 35);
            this.BtnAceptar.TabIndex = 13;
            this.BtnAceptar.Text = "&Buscar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(234, 15);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbBancos);
            this.groupBox1.Controls.Add(this.DtpFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(127, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 103);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // CbBancos
            // 
            this.CbBancos.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bancosBindingSource, "Id", true));
            this.CbBancos.DataSource = this.bancosBindingSource;
            this.CbBancos.DisplayMember = "Nombre";
            this.CbBancos.FormattingEnabled = true;
            this.CbBancos.Location = new System.Drawing.Point(207, 67);
            this.CbBancos.Name = "CbBancos";
            this.CbBancos.Size = new System.Drawing.Size(121, 21);
            this.CbBancos.TabIndex = 34;
            this.CbBancos.ValueMember = "Id";
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.dBInfosypDataSet6;
            // 
            // dBInfosypDataSet6
            // 
            this.dBInfosypDataSet6.DataSetName = "DBInfosypDataSet6";
            this.dBInfosypDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(9, 68);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(164, 20);
            this.DtpFecha.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Banco:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Introducir Fecha:";
            // 
            // bancosTableAdapter
            // 
            this.bancosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportedePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgvReportePagos);
            this.Controls.Add(this.groupBox2);
            this.Name = "ReportedePagos";
            this.Text = "Reporte de Pagos";
            this.Load += new System.EventHandler(this.ReportedePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvReportePagos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgvReportePagos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbBancos;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExcel;
        private DBInfosypDataSet6 dBInfosypDataSet6;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private DBInfosypDataSet6TableAdapters.BancosTableAdapter bancosTableAdapter;
    }
}