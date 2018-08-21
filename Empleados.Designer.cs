namespace RHInfosyp
{
    partial class FrmEmpleados
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
            this.DtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbEdad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CbEmpresa = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet3 = new RHInfosyp.DBInfosypDataSet3();
            this.label10 = new System.Windows.Forms.Label();
            this.CbSeguro = new System.Windows.Forms.ComboBox();
            this.segurosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet4 = new RHInfosyp.DBInfosypDataSet4();
            this.label9 = new System.Windows.Forms.Label();
            this.CbBanco = new System.Windows.Forms.ComboBox();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet5 = new RHInfosyp.DBInfosypDataSet5();
            this.label8 = new System.Windows.Forms.Label();
            this.TbSueldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TbNoCuenta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TbPuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.empresasTableAdapter = new RHInfosyp.DBInfosypDataSet3TableAdapters.EmpresasTableAdapter();
            this.segurosTableAdapter = new RHInfosyp.DBInfosypDataSet4TableAdapters.SegurosTableAdapter();
            this.bancosTableAdapter = new RHInfosyp.DBInfosypDataSet5TableAdapters.BancosTableAdapter();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEmpleados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvEmpleados
            // 
            this.DtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvEmpleados.Location = new System.Drawing.Point(45, 213);
            this.DtgvEmpleados.Name = "DtgvEmpleados";
            this.DtgvEmpleados.Size = new System.Drawing.Size(653, 117);
            this.DtgvEmpleados.TabIndex = 0;
            this.DtgvEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvEmpleados_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnConsulta);
            this.groupBox2.Controls.Add(this.BtnBuscar);
            this.groupBox2.Controls.Add(this.BtnBorrar);
            this.groupBox2.Controls.Add(this.BtnEditar);
            this.groupBox2.Controls.Add(this.BtnAgregar);
            this.groupBox2.Controls.Add(this.BtnSalir);
            this.groupBox2.Location = new System.Drawing.Point(45, 336);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(653, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Location = new System.Drawing.Point(18, 19);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(98, 35);
            this.BtnConsulta.TabIndex = 7;
            this.BtnConsulta.Text = "&Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(228, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 35);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Location = new System.Drawing.Point(436, 19);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(98, 35);
            this.BtnBorrar.TabIndex = 2;
            this.BtnBorrar.Text = "&Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(332, 19);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(98, 35);
            this.BtnEditar.TabIndex = 3;
            this.BtnEditar.Text = "&Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(122, 19);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 35);
            this.BtnAgregar.TabIndex = 0;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(540, 19);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbEdad);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.CbEmpresa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.CbSeguro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CbBanco);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TbSueldo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TbNoCuenta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TbPuesto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TbCedula);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbApellidos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbNombres);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 137);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // TbEdad
            // 
            this.TbEdad.Location = new System.Drawing.Point(336, 46);
            this.TbEdad.Name = "TbEdad";
            this.TbEdad.Size = new System.Drawing.Size(100, 20);
            this.TbEdad.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(335, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Edad:";
            // 
            // CbEmpresa
            // 
            this.CbEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresasBindingSource, "Id", true));
            this.CbEmpresa.DataSource = this.empresasBindingSource;
            this.CbEmpresa.DisplayMember = "Nombre";
            this.CbEmpresa.FormattingEnabled = true;
            this.CbEmpresa.Location = new System.Drawing.Point(473, 44);
            this.CbEmpresa.Name = "CbEmpresa";
            this.CbEmpresa.Size = new System.Drawing.Size(121, 21);
            this.CbEmpresa.TabIndex = 8;
            this.CbEmpresa.ValueMember = "Id";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dBInfosypDataSet3;
            // 
            // dBInfosypDataSet3
            // 
            this.dBInfosypDataSet3.DataSetName = "DBInfosypDataSet3";
            this.dBInfosypDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(470, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Empresa:";
            // 
            // CbSeguro
            // 
            this.CbSeguro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.segurosBindingSource, "Id", true));
            this.CbSeguro.DataSource = this.segurosBindingSource;
            this.CbSeguro.DisplayMember = "Nombre";
            this.CbSeguro.FormattingEnabled = true;
            this.CbSeguro.Location = new System.Drawing.Point(473, 95);
            this.CbSeguro.Name = "CbSeguro";
            this.CbSeguro.Size = new System.Drawing.Size(121, 21);
            this.CbSeguro.TabIndex = 9;
            this.CbSeguro.ValueMember = "Id";
            // 
            // segurosBindingSource
            // 
            this.segurosBindingSource.DataMember = "Seguros";
            this.segurosBindingSource.DataSource = this.dBInfosypDataSet4;
            // 
            // dBInfosypDataSet4
            // 
            this.dBInfosypDataSet4.DataSetName = "DBInfosypDataSet4";
            this.dBInfosypDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Seguro:";
            // 
            // CbBanco
            // 
            this.CbBanco.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bancosBindingSource, "Id", true));
            this.CbBanco.DataSource = this.bancosBindingSource;
            this.CbBanco.DisplayMember = "Nombre";
            this.CbBanco.FormattingEnabled = true;
            this.CbBanco.Location = new System.Drawing.Point(338, 95);
            this.CbBanco.Name = "CbBanco";
            this.CbBanco.Size = new System.Drawing.Size(121, 21);
            this.CbBanco.TabIndex = 7;
            this.CbBanco.ValueMember = "Id";
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.dBInfosypDataSet5;
            // 
            // dBInfosypDataSet5
            // 
            this.dBInfosypDataSet5.DataSetName = "DBInfosypDataSet5";
            this.dBInfosypDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Banco:";
            // 
            // TbSueldo
            // 
            this.TbSueldo.Location = new System.Drawing.Point(14, 95);
            this.TbSueldo.Name = "TbSueldo";
            this.TbSueldo.Size = new System.Drawing.Size(100, 20);
            this.TbSueldo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sueldo:";
            // 
            // TbNoCuenta
            // 
            this.TbNoCuenta.Location = new System.Drawing.Point(230, 95);
            this.TbNoCuenta.Name = "TbNoCuenta";
            this.TbNoCuenta.Size = new System.Drawing.Size(100, 20);
            this.TbNoCuenta.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "No. Cuenta:";
            // 
            // TbPuesto
            // 
            this.TbPuesto.Location = new System.Drawing.Point(122, 95);
            this.TbPuesto.Name = "TbPuesto";
            this.TbPuesto.Size = new System.Drawing.Size(100, 20);
            this.TbPuesto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Puesto:";
            // 
            // TbCedula
            // 
            this.TbCedula.Location = new System.Drawing.Point(229, 46);
            this.TbCedula.Name = "TbCedula";
            this.TbCedula.Size = new System.Drawing.Size(100, 20);
            this.TbCedula.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cedula:";
            // 
            // TbApellidos
            // 
            this.TbApellidos.Location = new System.Drawing.Point(123, 46);
            this.TbApellidos.Name = "TbApellidos";
            this.TbApellidos.Size = new System.Drawing.Size(100, 20);
            this.TbApellidos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellidos:";
            // 
            // TbNombres
            // 
            this.TbNombres.Location = new System.Drawing.Point(16, 46);
            this.TbNombres.Name = "TbNombres";
            this.TbNombres.Size = new System.Drawing.Size(100, 20);
            this.TbNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombres:";
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // segurosTableAdapter
            // 
            this.segurosTableAdapter.ClearBeforeFill = true;
            // 
            // bancosTableAdapter
            // 
            this.bancosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(45, 180);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 27);
            this.BtnLimpiar.TabIndex = 8;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DtgvEmpleados);
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEmpleados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segurosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DtgvEmpleados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbEmpresa;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CbSeguro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbBanco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbSueldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbNoCuenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbPuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbEdad;
        private System.Windows.Forms.Label label11;
        private DBInfosypDataSet3 dBInfosypDataSet3;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private DBInfosypDataSet3TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private DBInfosypDataSet4 dBInfosypDataSet4;
        private System.Windows.Forms.BindingSource segurosBindingSource;
        private DBInfosypDataSet4TableAdapters.SegurosTableAdapter segurosTableAdapter;
        private DBInfosypDataSet5 dBInfosypDataSet5;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private DBInfosypDataSet5TableAdapters.BancosTableAdapter bancosTableAdapter;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}