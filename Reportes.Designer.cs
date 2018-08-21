namespace RHInfosyp
{
    partial class Reportes
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnReporteRegalia = new System.Windows.Forms.Button();
            this.BtnReportePagos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(265, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(109, 66);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(6, 19);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReporteRegalia);
            this.groupBox1.Controls.Add(this.BtnReportePagos);
            this.groupBox1.Location = new System.Drawing.Point(117, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 203);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // BtnReporteRegalia
            // 
            this.BtnReporteRegalia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporteRegalia.Location = new System.Drawing.Point(222, 71);
            this.BtnReporteRegalia.Name = "BtnReporteRegalia";
            this.BtnReporteRegalia.Size = new System.Drawing.Size(117, 58);
            this.BtnReporteRegalia.TabIndex = 7;
            this.BtnReporteRegalia.Text = "&Reportes de Regalias";
            this.BtnReporteRegalia.UseVisualStyleBackColor = true;
            this.BtnReporteRegalia.Click += new System.EventHandler(this.BtnReporteRegalia_Click);
            // 
            // BtnReportePagos
            // 
            this.BtnReportePagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportePagos.Location = new System.Drawing.Point(74, 71);
            this.BtnReportePagos.Name = "BtnReportePagos";
            this.BtnReportePagos.Size = new System.Drawing.Size(117, 58);
            this.BtnReportePagos.TabIndex = 6;
            this.BtnReportePagos.Text = "&Reportes de Pagos";
            this.BtnReportePagos.UseVisualStyleBackColor = true;
            this.BtnReportePagos.Click += new System.EventHandler(this.BtnReportePagos_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 384);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReporteRegalia;
        private System.Windows.Forms.Button BtnReportePagos;
    }
}