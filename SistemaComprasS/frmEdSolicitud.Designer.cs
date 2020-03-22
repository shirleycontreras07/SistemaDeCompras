namespace SistemaComprasS
{
    partial class frmEdSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEdSolicitud));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComprasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComprasDataSet = new SistemaComprasS.SistemaComprasDataSet();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.undMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSolicitud = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitudTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.SolicitudTableAdapter();
            this.empleadoTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.EmpleadoTableAdapter();
            this.articuloTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.ArticuloTableAdapter();
            this.undMedidaTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.UndMedidaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(194, 248);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 51);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(91, 248);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 51);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxArticulo);
            this.panel1.Controls.Add(this.cbxEmpleado);
            this.panel1.Controls.Add(this.txtIdSolicitud);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxMedida);
            this.panel1.Controls.Add(this.nudCantidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpSolicitud);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 230);
            this.panel1.TabIndex = 17;
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.articuloBindingSource, "IdArticulo", true));
            this.cbxArticulo.DataSource = this.articuloBindingSource;
            this.cbxArticulo.DisplayMember = "Descripcion";
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(96, 109);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(121, 21);
            this.cbxArticulo.TabIndex = 20;
            this.cbxArticulo.ValueMember = "IdArticulo";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.sistemaComprasDataSetBindingSource;
            // 
            // sistemaComprasDataSetBindingSource
            // 
            this.sistemaComprasDataSetBindingSource.DataSource = this.sistemaComprasDataSet;
            this.sistemaComprasDataSetBindingSource.Position = 0;
            // 
            // sistemaComprasDataSet
            // 
            this.sistemaComprasDataSet.DataSetName = "SistemaComprasDataSet";
            this.sistemaComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.empleadoBindingSource, "IdEmpleado", true));
            this.cbxEmpleado.DataSource = this.empleadoBindingSource;
            this.cbxEmpleado.DisplayMember = "Nombre";
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(96, 54);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbxEmpleado.TabIndex = 19;
            this.cbxEmpleado.ValueMember = "IdEmpleado";
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.sistemaComprasDataSetBindingSource;
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Location = new System.Drawing.Point(96, 27);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(100, 20);
            this.txtIdSolicitud.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID";
            // 
            // cbxMedida
            // 
            this.cbxMedida.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.undMedidaBindingSource, "IdUndMedida", true));
            this.cbxMedida.DataSource = this.undMedidaBindingSource;
            this.cbxMedida.DisplayMember = "Descripcion";
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Location = new System.Drawing.Point(96, 168);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(100, 21);
            this.cbxMedida.TabIndex = 16;
            this.cbxMedida.ValueMember = "IdUndMedida";
            // 
            // undMedidaBindingSource
            // 
            this.undMedidaBindingSource.DataMember = "UndMedida";
            this.undMedidaBindingSource.DataSource = this.sistemaComprasDataSetBindingSource;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(96, 137);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(49, 20);
            this.nudCantidad.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // dtpSolicitud
            // 
            this.dtpSolicitud.CustomFormat = "yyyy/MM/dd HH:mm:ss ";
            this.dtpSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSolicitud.Location = new System.Drawing.Point(96, 80);
            this.dtpSolicitud.Name = "dtpSolicitud";
            this.dtpSolicitud.Size = new System.Drawing.Size(200, 20);
            this.dtpSolicitud.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(96, 203);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empleado";
            // 
            // solicitudBindingSource
            // 
            this.solicitudBindingSource.DataMember = "Solicitud";
            this.solicitudBindingSource.DataSource = this.sistemaComprasDataSetBindingSource;
            // 
            // solicitudTableAdapter
            // 
            this.solicitudTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // undMedidaTableAdapter
            // 
            this.undMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // frmEdSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 305);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "frmEdSolicitud";
            this.Text = "frmEdSolicitud";
            this.Load += new System.EventHandler(this.frmEdSolicitud_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpSolicitud;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.BindingSource sistemaComprasDataSetBindingSource;
        private SistemaComprasDataSet sistemaComprasDataSet;
        private System.Windows.Forms.BindingSource solicitudBindingSource;
        private SistemaComprasDataSetTableAdapters.SolicitudTableAdapter solicitudTableAdapter;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private SistemaComprasDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SistemaComprasDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource undMedidaBindingSource;
        private SistemaComprasDataSetTableAdapters.UndMedidaTableAdapter undMedidaTableAdapter;
    }
}