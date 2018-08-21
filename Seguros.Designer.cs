namespace RHInfosyp
{
    partial class FrmSeguros
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
            this.CbCodigoSeguro = new System.Windows.Forms.ComboBox();
            this.segurosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet2 = new RHInfosyp.DBInfosypDataSet2();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TbNombres = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DtgvSeguro = new System.Windows.Forms.DataGridView();
            this.segurosTableAdapter = new RHInfosyp.DBInfosypDataSet2TableAdapters.SegurosTableAdapter();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segurosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvSeguro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.BtnConsulta);
            this.groupBox1.Controls.Add(this.CbCodigoSeguro);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.BtnBorrar);
            this.groupBox1.Controls.Add(this.TbNombres);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Location = new System.Drawing.Point(49, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 185);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Location = new System.Drawing.Point(311, 101);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(98, 35);
            this.BtnConsulta.TabIndex = 6;
            this.BtnConsulta.Text = "&Consulta";
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // CbCodigoSeguro
            // 
            this.CbCodigoSeguro.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.segurosBindingSource, "Id", true));
            this.CbCodigoSeguro.DataSource = this.segurosBindingSource;
            this.CbCodigoSeguro.DisplayMember = "Id";
            this.CbCodigoSeguro.FormattingEnabled = true;
            this.CbCodigoSeguro.Location = new System.Drawing.Point(19, 101);
            this.CbCodigoSeguro.Name = "CbCodigoSeguro";
            this.CbCodigoSeguro.Size = new System.Drawing.Size(151, 21);
            this.CbCodigoSeguro.TabIndex = 1;
            this.CbCodigoSeguro.ValueMember = "Id";
            // 
            // segurosBindingSource
            // 
            this.segurosBindingSource.DataMember = "Seguros";
            this.segurosBindingSource.DataSource = this.dBInfosypDataSet2;
            // 
            // dBInfosypDataSet2
            // 
            this.dBInfosypDataSet2.DataSetName = "DBInfosypDataSet2";
            this.dBInfosypDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Codigo del Seguro:";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Location = new System.Drawing.Point(311, 19);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(98, 35);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "&Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Location = new System.Drawing.Point(311, 60);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(98, 35);
            this.BtnBorrar.TabIndex = 4;
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
            this.BtnEditar.Location = new System.Drawing.Point(415, 60);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(98, 35);
            this.BtnEditar.TabIndex = 5;
            this.BtnEditar.Text = "&Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre del Seguro:";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Location = new System.Drawing.Point(415, 19);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(98, 35);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(415, 101);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(98, 35);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // DtgvSeguro
            // 
            this.DtgvSeguro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvSeguro.Location = new System.Drawing.Point(49, 243);
            this.DtgvSeguro.Name = "DtgvSeguro";
            this.DtgvSeguro.Size = new System.Drawing.Size(552, 83);
            this.DtgvSeguro.TabIndex = 0;
            this.DtgvSeguro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvSeguro_CellContentClick);
            // 
            // segurosTableAdapter
            // 
            this.segurosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(364, 142);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 35);
            this.BtnLimpiar.TabIndex = 38;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmSeguros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgvSeguro);
            this.Name = "FrmSeguros";
            this.Text = "Seguros";
            this.Load += new System.EventHandler(this.Seguros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segurosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvSeguro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbCodigoSeguro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.TextBox TbNombres;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DtgvSeguro;
        private System.Windows.Forms.Button BtnConsulta;
        private DBInfosypDataSet2 dBInfosypDataSet2;
        private System.Windows.Forms.BindingSource segurosBindingSource;
        private DBInfosypDataSet2TableAdapters.SegurosTableAdapter segurosTableAdapter;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}