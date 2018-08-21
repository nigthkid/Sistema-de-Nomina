namespace RHInfosyp
{
    partial class FrmBancos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnConsulta = new System.Windows.Forms.Button();
            this.CbEstatusBanco = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbCodigoEmpresa = new System.Windows.Forms.ComboBox();
            this.bancosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet = new RHInfosyp.DBInfosypDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TbNombres = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DtgvBanco = new System.Windows.Forms.DataGridView();
            this.bancosTableAdapter = new RHInfosyp.DBInfosypDataSetTableAdapters.BancosTableAdapter();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.BtnConsulta);
            this.groupBox1.Controls.Add(this.CbEstatusBanco);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbCodigoEmpresa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.BtnBorrar);
            this.groupBox1.Controls.Add(this.TbNombres);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Location = new System.Drawing.Point(65, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 207);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Location = new System.Drawing.Point(311, 120);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(98, 35);
            this.BtnConsulta.TabIndex = 7;
            this.BtnConsulta.Text = "&Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // CbEstatusBanco
            // 
            this.CbEstatusBanco.FormattingEnabled = true;
            this.CbEstatusBanco.Items.AddRange(new object[] {
            "Principal",
            "Otro",
            "Manual"});
            this.CbEstatusBanco.Location = new System.Drawing.Point(19, 87);
            this.CbEstatusBanco.Name = "CbEstatusBanco";
            this.CbEstatusBanco.Size = new System.Drawing.Size(151, 21);
            this.CbEstatusBanco.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Estatus del Banco:";
            // 
            // CbCodigoEmpresa
            // 
            this.CbCodigoEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bancosBindingSource, "Id", true));
            this.CbCodigoEmpresa.DataSource = this.bancosBindingSource;
            this.CbCodigoEmpresa.DisplayMember = "Id";
            this.CbCodigoEmpresa.FormattingEnabled = true;
            this.CbCodigoEmpresa.Location = new System.Drawing.Point(19, 128);
            this.CbCodigoEmpresa.Name = "CbCodigoEmpresa";
            this.CbCodigoEmpresa.Size = new System.Drawing.Size(151, 21);
            this.CbCodigoEmpresa.TabIndex = 2;
            this.CbCodigoEmpresa.ValueMember = "Id";
            // 
            // bancosBindingSource
            // 
            this.bancosBindingSource.DataMember = "Bancos";
            this.bancosBindingSource.DataSource = this.dBInfosypDataSet;
            // 
            // dBInfosypDataSet
            // 
            this.dBInfosypDataSet.DataSetName = "DBInfosypDataSet";
            this.dBInfosypDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Codigo del Banco:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(311, 38);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 35);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Location = new System.Drawing.Point(311, 79);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(98, 35);
            this.BtnBorrar.TabIndex = 5;
            this.BtnBorrar.Text = "&Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // TbNombres
            // 
            this.TbNombres.Location = new System.Drawing.Point(19, 46);
            this.TbNombres.Name = "TbNombres";
            this.TbNombres.Size = new System.Drawing.Size(151, 20);
            this.TbNombres.TabIndex = 0;
            // 
            // BtnEditar
            // 
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Location = new System.Drawing.Point(415, 79);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(98, 35);
            this.BtnEditar.TabIndex = 6;
            this.BtnEditar.Text = "&Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre del Banco:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(415, 38);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 35);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(415, 120);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DtgvBanco
            // 
            this.DtgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvBanco.Location = new System.Drawing.Point(65, 266);
            this.DtgvBanco.Name = "DtgvBanco";
            this.DtgvBanco.Size = new System.Drawing.Size(552, 83);
            this.DtgvBanco.TabIndex = 0;
            this.DtgvBanco.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvBanco_CellContentClick);
            // 
            // bancosTableAdapter
            // 
            this.bancosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(365, 161);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 35);
            this.BtnLimpiar.TabIndex = 39;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 406);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgvBanco);
            this.Name = "FrmBancos";
            this.Text = "Bancos";
            this.Load += new System.EventHandler(this.Bancos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bancosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvBanco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbCodigoEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TbNombres;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DtgvBanco;
        private System.Windows.Forms.ComboBox CbEstatusBanco;
        private System.Windows.Forms.Label label2;
        private DBInfosypDataSet dBInfosypDataSet;
        private System.Windows.Forms.BindingSource bancosBindingSource;
        private DBInfosypDataSetTableAdapters.BancosTableAdapter bancosTableAdapter;
        private System.Windows.Forms.Button BtnConsulta;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}