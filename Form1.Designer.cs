namespace RHInfosyp
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSeguros = new System.Windows.Forms.Button();
            this.BtnBancos = new System.Windows.Forms.Button();
            this.BtnEmpresas = new System.Windows.Forms.Button();
            this.BtnEmpleados = new System.Windows.Forms.Button();
            this.BtnPagos = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSeguros);
            this.groupBox1.Controls.Add(this.BtnBancos);
            this.groupBox1.Controls.Add(this.BtnEmpresas);
            this.groupBox1.Controls.Add(this.BtnEmpleados);
            this.groupBox1.Controls.Add(this.BtnPagos);
            this.groupBox1.Location = new System.Drawing.Point(108, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 295);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menú";
            // 
            // BtnSeguros
            // 
            this.BtnSeguros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeguros.Location = new System.Drawing.Point(308, 158);
            this.BtnSeguros.Name = "BtnSeguros";
            this.BtnSeguros.Size = new System.Drawing.Size(117, 58);
            this.BtnSeguros.TabIndex = 4;
            this.BtnSeguros.Text = "&Seguros";
            this.BtnSeguros.UseVisualStyleBackColor = true;
            this.BtnSeguros.Click += new System.EventHandler(this.BtnSeguros_Click);
            // 
            // BtnBancos
            // 
            this.BtnBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBancos.Location = new System.Drawing.Point(144, 158);
            this.BtnBancos.Name = "BtnBancos";
            this.BtnBancos.Size = new System.Drawing.Size(117, 58);
            this.BtnBancos.TabIndex = 3;
            this.BtnBancos.Text = "&Bancos";
            this.BtnBancos.UseVisualStyleBackColor = true;
            this.BtnBancos.Click += new System.EventHandler(this.BtnBancos_Click);
            // 
            // BtnEmpresas
            // 
            this.BtnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpresas.Location = new System.Drawing.Point(367, 71);
            this.BtnEmpresas.Name = "BtnEmpresas";
            this.BtnEmpresas.Size = new System.Drawing.Size(117, 58);
            this.BtnEmpresas.TabIndex = 2;
            this.BtnEmpresas.Text = "&Empresas";
            this.BtnEmpresas.UseVisualStyleBackColor = true;
            this.BtnEmpresas.Click += new System.EventHandler(this.BtnEmpresas_Click);
            // 
            // BtnEmpleados
            // 
            this.BtnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmpleados.Location = new System.Drawing.Point(222, 71);
            this.BtnEmpleados.Name = "BtnEmpleados";
            this.BtnEmpleados.Size = new System.Drawing.Size(117, 58);
            this.BtnEmpleados.TabIndex = 1;
            this.BtnEmpleados.Text = "&Empleados";
            this.BtnEmpleados.UseVisualStyleBackColor = true;
            this.BtnEmpleados.Click += new System.EventHandler(this.BtnEmpleados_Click);
            // 
            // BtnPagos
            // 
            this.BtnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagos.Location = new System.Drawing.Point(74, 71);
            this.BtnPagos.Name = "BtnPagos";
            this.BtnPagos.Size = new System.Drawing.Size(117, 58);
            this.BtnPagos.TabIndex = 0;
            this.BtnPagos.Text = "&Pagos";
            this.BtnPagos.UseVisualStyleBackColor = true;
            this.BtnPagos.Click += new System.EventHandler(this.BtnPagos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(317, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 66);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(6, 19);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Sistema RH Infosyp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSeguros;
        private System.Windows.Forms.Button BtnBancos;
        private System.Windows.Forms.Button BtnEmpresas;
        private System.Windows.Forms.Button BtnEmpleados;
        private System.Windows.Forms.Button BtnPagos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSalir;
    }
}

