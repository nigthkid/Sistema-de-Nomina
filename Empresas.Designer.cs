﻿namespace RHInfosyp
{
    partial class FrmEmpresas
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
            this.CbCodigoEmpresa = new System.Windows.Forms.ComboBox();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBInfosypDataSet1 = new RHInfosyp.DBInfosypDataSet1();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.TbNombres = new System.Windows.Forms.TextBox();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.DtgvEmpresas = new System.Windows.Forms.DataGridView();
            this.empresasTableAdapter = new RHInfosyp.DBInfosypDataSet1TableAdapters.EmpresasTableAdapter();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEmpresas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLimpiar);
            this.groupBox1.Controls.Add(this.BtnConsulta);
            this.groupBox1.Controls.Add(this.CbCodigoEmpresa);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BtnBuscar);
            this.groupBox1.Controls.Add(this.BtnBorrar);
            this.groupBox1.Controls.Add(this.TbNombres);
            this.groupBox1.Controls.Add(this.BtnEditar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnAgregar);
            this.groupBox1.Controls.Add(this.BtnSalir);
            this.groupBox1.Location = new System.Drawing.Point(74, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 188);
            this.groupBox1.TabIndex = 25;
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
            // CbCodigoEmpresa
            // 
            this.CbCodigoEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empresasBindingSource, "Id", true));
            this.CbCodigoEmpresa.DataSource = this.empresasBindingSource;
            this.CbCodigoEmpresa.DisplayMember = "Id";
            this.CbCodigoEmpresa.FormattingEnabled = true;
            this.CbCodigoEmpresa.Location = new System.Drawing.Point(19, 101);
            this.CbCodigoEmpresa.Name = "CbCodigoEmpresa";
            this.CbCodigoEmpresa.Size = new System.Drawing.Size(151, 21);
            this.CbCodigoEmpresa.TabIndex = 1;
            this.CbCodigoEmpresa.ValueMember = "Id";
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.dBInfosypDataSet1;
            // 
            // dBInfosypDataSet1
            // 
            this.dBInfosypDataSet1.DataSetName = "DBInfosypDataSet1";
            this.dBInfosypDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Codigo de la Empresa:";
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
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nombre de la Empresa:";
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
            // DtgvEmpresas
            // 
            this.DtgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvEmpresas.Location = new System.Drawing.Point(74, 238);
            this.DtgvEmpresas.Name = "DtgvEmpresas";
            this.DtgvEmpresas.Size = new System.Drawing.Size(552, 83);
            this.DtgvEmpresas.TabIndex = 0;
            this.DtgvEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvEmpresas_CellContentClick);
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Location = new System.Drawing.Point(363, 142);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(98, 35);
            this.BtnLimpiar.TabIndex = 37;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // FrmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 383);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DtgvEmpresas);
            this.Name = "FrmEmpresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.Empresas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBInfosypDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEmpresas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DtgvEmpresas;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CbCodigoEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnConsulta;
        private DBInfosypDataSet1 dBInfosypDataSet1;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private DBInfosypDataSet1TableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private System.Windows.Forms.Button BtnLimpiar;
    }
}