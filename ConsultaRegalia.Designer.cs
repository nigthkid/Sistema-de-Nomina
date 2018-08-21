namespace RHInfosyp
{
    partial class ConsultaRegalia
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
            this.DtgvConsultaRegalias = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnConsultarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvConsultaRegalias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgvConsultaRegalias
            // 
            this.DtgvConsultaRegalias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvConsultaRegalias.Location = new System.Drawing.Point(60, 143);
            this.DtgvConsultaRegalias.Name = "DtgvConsultaRegalias";
            this.DtgvConsultaRegalias.Size = new System.Drawing.Size(549, 145);
            this.DtgvConsultaRegalias.TabIndex = 21;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(202, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 66);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(6, 15);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 35);
            this.BtnBuscar.TabIndex = 13;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(110, 15);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 14;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConsultarEmpleado);
            this.groupBox1.Controls.Add(this.TbCedula);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(60, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 100);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // TbCedula
            // 
            this.TbCedula.Location = new System.Drawing.Point(142, 43);
            this.TbCedula.Name = "TbCedula";
            this.TbCedula.Size = new System.Drawing.Size(126, 20);
            this.TbCedula.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cedula:";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(9, 43);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(126, 20);
            this.TbNombre.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombres:";
            // 
            // BtnConsultarEmpleado
            // 
            this.BtnConsultarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarEmpleado.Location = new System.Drawing.Point(341, 40);
            this.BtnConsultarEmpleado.Name = "BtnConsultarEmpleado";
            this.BtnConsultarEmpleado.Size = new System.Drawing.Size(137, 25);
            this.BtnConsultarEmpleado.TabIndex = 41;
            this.BtnConsultarEmpleado.Text = "&Consultar Empleados";
            this.BtnConsultarEmpleado.UseVisualStyleBackColor = true;
            this.BtnConsultarEmpleado.Click += new System.EventHandler(this.BtnConsultarEmpleado_Click);
            // 
            // ConsultaRegalia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgvConsultaRegalias);
            this.Controls.Add(this.groupBox2);
            this.Name = "ConsultaRegalia";
            this.Text = "Consulta Regalia";
            ((System.ComponentModel.ISupportInitialize)(this.DtgvConsultaRegalias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgvConsultaRegalias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnConsultarEmpleado;
    }
}