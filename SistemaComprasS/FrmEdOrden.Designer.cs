namespace SistemaComprasS
{
    partial class FrmEdOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdOrden));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComprasDataSet = new SistemaComprasS.SistemaComprasDataSet();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSolicitud = new System.Windows.Forms.ComboBox();
            this.solicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdOrden = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.undMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOrden = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.solicitudTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.SolicitudTableAdapter();
            this.articuloTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.ArticuloTableAdapter();
            this.undMedidaTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.UndMedidaTableAdapter();
            this.marcaTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.MarcaTableAdapter();
            this.nudCosto = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(194, 312);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 51);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(87, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 51);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudCosto);
            this.panel1.Controls.Add(this.cbxMarca);
            this.panel1.Controls.Add(this.cbxArticulo);
            this.panel1.Controls.Add(this.cbxSolicitud);
            this.panel1.Controls.Add(this.txtIdOrden);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxMedida);
            this.panel1.Controls.Add(this.nudCantidad);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpOrden);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 294);
            this.panel1.TabIndex = 20;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.marcaBindingSource, "IdMarca", true));
            this.cbxMarca.DataSource = this.marcaBindingSource;
            this.cbxMarca.DisplayMember = "Descripcion";
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(104, 227);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(100, 21);
            this.cbxMarca.TabIndex = 25;
            this.cbxMarca.ValueMember = "IdMarca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // sistemaComprasDataSet
            // 
            this.sistemaComprasDataSet.DataSetName = "SistemaComprasDataSet";
            this.sistemaComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.articuloBindingSource, "IdArticulo", true));
            this.cbxArticulo.DataSource = this.articuloBindingSource;
            this.cbxArticulo.DisplayMember = "Descripcion";
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(104, 136);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(100, 21);
            this.cbxArticulo.TabIndex = 24;
            this.cbxArticulo.ValueMember = "IdArticulo";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // cbxSolicitud
            // 
            this.cbxSolicitud.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.solicitudBindingSource, "IdSolicitud", true));
            this.cbxSolicitud.DataSource = this.solicitudBindingSource;
            this.cbxSolicitud.DisplayMember = "IdSolicitud";
            this.cbxSolicitud.FormattingEnabled = true;
            this.cbxSolicitud.Location = new System.Drawing.Point(104, 51);
            this.cbxSolicitud.Name = "cbxSolicitud";
            this.cbxSolicitud.Size = new System.Drawing.Size(100, 21);
            this.cbxSolicitud.TabIndex = 23;
            this.cbxSolicitud.ValueMember = "IdSolicitud";
            // 
            // solicitudBindingSource
            // 
            this.solicitudBindingSource.DataMember = "Solicitud";
            this.solicitudBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // txtIdOrden
            // 
            this.txtIdOrden.Location = new System.Drawing.Point(104, 25);
            this.txtIdOrden.Name = "txtIdOrden";
            this.txtIdOrden.ReadOnly = true;
            this.txtIdOrden.Size = new System.Drawing.Size(100, 20);
            this.txtIdOrden.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "ID";
            // 
            // cbxMedida
            // 
            this.cbxMedida.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.undMedidaBindingSource, "IdUndMedida", true));
            this.cbxMedida.DataSource = this.undMedidaBindingSource;
            this.cbxMedida.DisplayMember = "Descripcion";
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Location = new System.Drawing.Point(104, 195);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(100, 21);
            this.cbxMedida.TabIndex = 20;
            this.cbxMedida.ValueMember = "IdUndMedida";
            // 
            // undMedidaBindingSource
            // 
            this.undMedidaBindingSource.DataMember = "UndMedida";
            this.undMedidaBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(104, 164);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(57, 20);
            this.nudCantidad.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Costo unitario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad";
            // 
            // dtpOrden
            // 
            this.dtpOrden.CustomFormat = "yyyy/MM/dd HH:mm:ss ";
            this.dtpOrden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrden.Location = new System.Drawing.Point(104, 78);
            this.dtpOrden.Name = "dtpOrden";
            this.dtpOrden.Size = new System.Drawing.Size(200, 20);
            this.dtpOrden.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(104, 113);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Solicitud";
            // 
            // solicitudTableAdapter
            // 
            this.solicitudTableAdapter.ClearBeforeFill = true;
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // undMedidaTableAdapter
            // 
            this.undMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // nudCosto
            // 
            this.nudCosto.DecimalPlaces = 2;
            this.nudCosto.Location = new System.Drawing.Point(104, 259);
            this.nudCosto.Name = "nudCosto";
            this.nudCosto.Size = new System.Drawing.Size(100, 20);
            this.nudCosto.TabIndex = 26;
            // 
            // FrmEdOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 371);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdOrden";
            this.Text = "FrmEdOrden";
            this.Load += new System.EventHandler(this.FrmEdOrden_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCosto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOrden;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox txtIdOrden;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.ComboBox cbxSolicitud;
        private SistemaComprasDataSet sistemaComprasDataSet;
        private System.Windows.Forms.BindingSource solicitudBindingSource;
        private SistemaComprasDataSetTableAdapters.SolicitudTableAdapter solicitudTableAdapter;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private SistemaComprasDataSetTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.BindingSource undMedidaBindingSource;
        private SistemaComprasDataSetTableAdapters.UndMedidaTableAdapter undMedidaTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private SistemaComprasDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.NumericUpDown nudCosto;
    }
}