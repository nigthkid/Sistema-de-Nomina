namespace RHInfosyp
{
    partial class FrmPagos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRegalia = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnRegistrarPago = new System.Windows.Forms.Button();
            this.BtnConsultaPagos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRegalia);
            this.groupBox1.Controls.Add(this.BtnReportes);
            this.groupBox1.Controls.Add(this.BtnRegistrarPago);
            this.groupBox1.Controls.Add(this.BtnConsultaPagos);
            this.groupBox1.Location = new System.Drawing.Point(44, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 228);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // BtnRegalia
            // 
            this.BtnRegalia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegalia.Location = new System.Drawing.Point(215, 121);
            this.BtnRegalia.Name = "BtnRegalia";
            this.BtnRegalia.Size = new System.Drawing.Size(117, 58);
            this.BtnRegalia.TabIndex = 9;
            this.BtnRegalia.Text = "&Regalias";
            this.BtnRegalia.UseVisualStyleBackColor = true;
            this.BtnRegalia.Click += new System.EventHandler(this.BtnRegalia_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Location = new System.Drawing.Point(67, 121);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(117, 58);
            this.BtnReportes.TabIndex = 8;
            this.BtnReportes.Text = "&Reportes";
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnRegistrarPago
            // 
            this.BtnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarPago.Location = new System.Drawing.Point(215, 38);
            this.BtnRegistrarPago.Name = "BtnRegistrarPago";
            this.BtnRegistrarPago.Size = new System.Drawing.Size(117, 58);
            this.BtnRegistrarPago.TabIndex = 7;
            this.BtnRegistrarPago.Text = "&Registrar Pago";
            this.BtnRegistrarPago.UseVisualStyleBackColor = true;
            this.BtnRegistrarPago.Click += new System.EventHandler(this.BtnRegistrarPago_Click);
            // 
            // BtnConsultaPagos
            // 
            this.BtnConsultaPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaPagos.Location = new System.Drawing.Point(67, 38);
            this.BtnConsultaPagos.Name = "BtnConsultaPagos";
            this.BtnConsultaPagos.Size = new System.Drawing.Size(117, 58);
            this.BtnConsultaPagos.TabIndex = 6;
            this.BtnConsultaPagos.Text = "&Consulta de Pagos";
            this.BtnConsultaPagos.UseVisualStyleBackColor = true;
            this.BtnConsultaPagos.Click += new System.EventHandler(this.BtnConsultaPagos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(173, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 68);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(6, 19);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 376);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPagos";
            this.Text = "Pagos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnRegistrarPago;
        private System.Windows.Forms.Button BtnConsultaPagos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnRegalia;
    }
}