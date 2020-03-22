namespace SistemaComprasS
{
    partial class MainView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtMantOrden = new System.Windows.Forms.Button();
            this.BtMantSolicitud = new System.Windows.Forms.Button();
            this.btnMantProveedor = new System.Windows.Forms.Button();
            this.BtMantMedida = new System.Windows.Forms.Button();
            this.BtMantMarca = new System.Windows.Forms.Button();
            this.BtMantArticulo = new System.Windows.Forms.Button();
            this.BtMantDepartamentos = new System.Windows.Forms.Button();
            this.BtMantEmpleados = new System.Windows.Forms.Button();
            this.Buscador = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.sistemaComprasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComprasDataSet = new SistemaComprasS.SistemaComprasDataSet();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.EmpleadoTableAdapter();
            this.panel1.SuspendLayout();
            this.Buscador.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtMantOrden);
            this.panel1.Controls.Add(this.BtMantSolicitud);
            this.panel1.Controls.Add(this.btnMantProveedor);
            this.panel1.Controls.Add(this.BtMantMedida);
            this.panel1.Controls.Add(this.BtMantMarca);
            this.panel1.Controls.Add(this.BtMantArticulo);
            this.panel1.Controls.Add(this.BtMantDepartamentos);
            this.panel1.Controls.Add(this.BtMantEmpleados);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 67);
            this.panel1.TabIndex = 0;
            // 
            // BtMantOrden
            // 
            this.BtMantOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtMantOrden.Location = new System.Drawing.Point(585, 3);
            this.BtMantOrden.Name = "BtMantOrden";
            this.BtMantOrden.Size = new System.Drawing.Size(75, 56);
            this.BtMantOrden.TabIndex = 7;
            this.BtMantOrden.Text = "Ordenes";
            this.BtMantOrden.UseVisualStyleBackColor = false;
            this.BtMantOrden.Click += new System.EventHandler(this.BtMantOrden_Click);
            // 
            // BtMantSolicitud
            // 
            this.BtMantSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtMantSolicitud.Location = new System.Drawing.Point(504, 3);
            this.BtMantSolicitud.Name = "BtMantSolicitud";
            this.BtMantSolicitud.Size = new System.Drawing.Size(75, 56);
            this.BtMantSolicitud.TabIndex = 6;
            this.BtMantSolicitud.Text = "Solicitudes";
            this.BtMantSolicitud.UseVisualStyleBackColor = false;
            this.BtMantSolicitud.Click += new System.EventHandler(this.BtMantSolicitud_Click);
            // 
            // btnMantProveedor
            // 
            this.btnMantProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMantProveedor.Location = new System.Drawing.Point(423, 3);
            this.btnMantProveedor.Name = "btnMantProveedor";
            this.btnMantProveedor.Size = new System.Drawing.Size(75, 56);
            this.btnMantProveedor.TabIndex = 5;
            this.btnMantProveedor.Text = "Proveedores";
            this.btnMantProveedor.UseVisualStyleBackColor = false;
            this.btnMantProveedor.Click += new System.EventHandler(this.btnMantProveedor_Click);
            // 
            // BtMantMedida
            // 
            this.BtMantMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtMantMedida.Location = new System.Drawing.Point(342, 3);
            this.BtMantMedida.Name = "BtMantMedida";
            this.BtMantMedida.Size = new System.Drawing.Size(75, 56);
            this.BtMantMedida.TabIndex = 4;
            this.BtMantMedida.Text = "Medidas";
            this.BtMantMedida.UseVisualStyleBackColor = false;
            this.BtMantMedida.Click += new System.EventHandler(this.BtMantMedida_Click);
            // 
            // BtMantMarca
            // 
            this.BtMantMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtMantMarca.Location = new System.Drawing.Point(261, 3);
            this.BtMantMarca.Name = "BtMantMarca";
            this.BtMantMarca.Size = new System.Drawing.Size(75, 56);
            this.BtMantMarca.TabIndex = 3;
            this.BtMantMarca.Text = "Marcas";
            this.BtMantMarca.UseVisualStyleBackColor = false;
            this.BtMantMarca.Click += new System.EventHandler(this.BtMantMarca_Click);
            // 
            // BtMantArticulo
            // 
            this.BtMantArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtMantArticulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtMantArticulo.Location = new System.Drawing.Point(180, 3);
            this.BtMantArticulo.Name = "BtMantArticulo";
            this.BtMantArticulo.Size = new System.Drawing.Size(75, 56);
            this.BtMantArticulo.TabIndex = 2;
            this.BtMantArticulo.Text = "Articulos";
            this.BtMantArticulo.UseVisualStyleBackColor = false;
            this.BtMantArticulo.Click += new System.EventHandler(this.BtMantArticulo_Click);
            // 
            // BtMantDepartamentos
            // 
            this.BtMantDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtMantDepartamentos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtMantDepartamentos.Location = new System.Drawing.Point(84, 3);
            this.BtMantDepartamentos.Name = "BtMantDepartamentos";
            this.BtMantDepartamentos.Size = new System.Drawing.Size(90, 56);
            this.BtMantDepartamentos.TabIndex = 1;
            this.BtMantDepartamentos.Text = "Departamentos";
            this.BtMantDepartamentos.UseVisualStyleBackColor = false;
            this.BtMantDepartamentos.Click += new System.EventHandler(this.BtMantDepartamentos_Click);
            // 
            // BtMantEmpleados
            // 
            this.BtMantEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtMantEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtMantEmpleados.Location = new System.Drawing.Point(3, 3);
            this.BtMantEmpleados.Name = "BtMantEmpleados";
            this.BtMantEmpleados.Size = new System.Drawing.Size(75, 56);
            this.BtMantEmpleados.TabIndex = 0;
            this.BtMantEmpleados.Text = "Empleados";
            this.BtMantEmpleados.UseVisualStyleBackColor = false;
            this.BtMantEmpleados.Click += new System.EventHandler(this.BtMantEmpleados_Click);
            // 
            // Buscador
            // 
            this.Buscador.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Buscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Buscador.Controls.Add(this.btnActualizar);
            this.Buscador.Controls.Add(this.btAgregar);
            this.Buscador.Controls.Add(this.btBuscar);
            this.Buscador.Controls.Add(this.txtBuscar);
            this.Buscador.Controls.Add(this.cbxCriterio);
            this.Buscador.Controls.Add(this.label2);
            this.Buscador.Controls.Add(this.txtCriterio);
            this.Buscador.Location = new System.Drawing.Point(12, 85);
            this.Buscador.Name = "Buscador";
            this.Buscador.Size = new System.Drawing.Size(668, 53);
            this.Buscador.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizar.BackgroundImage")));
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizar.Location = new System.Drawing.Point(608, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(51, 44);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btAgregar.BackgroundImage")));
            this.btAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAgregar.Location = new System.Drawing.Point(551, 4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(51, 44);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBuscar.BackgroundImage")));
            this.btBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBuscar.Location = new System.Drawing.Point(496, 4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(49, 44);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(317, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbxCriterio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Items.AddRange(new object[] {
            "Cedula",
            "Nombre",
            "Departamento",
            "Descripcion",
            "Marca",
            "Medida",
            "Existencia",
            "TipoIdentificacion",
            "Identificacion",
            "Empleado",
            "Fecha",
            "Articulo",
            "Cantidad",
            "Solicitud",
            "Costo"});
            this.cbxCriterio.Location = new System.Drawing.Point(71, 17);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cbxCriterio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto a buscar";
            // 
            // txtCriterio
            // 
            this.txtCriterio.AutoSize = true;
            this.txtCriterio.Location = new System.Drawing.Point(26, 20);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(39, 13);
            this.txtCriterio.TabIndex = 0;
            this.txtCriterio.Text = "Criterio";
            this.txtCriterio.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgvResultado);
            this.panel3.Location = new System.Drawing.Point(12, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 286);
            this.panel3.TabIndex = 0;
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(7, 10);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(654, 262);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
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
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataMember = "Empleado";
            this.empleadoBindingSource.DataSource = this.sistemaComprasDataSetBindingSource;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 455);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Buscador);
            this.Controls.Add(this.panel1);
            this.Name = "MainView";
            this.Text = "Vista general";
            this.Activated += new System.EventHandler(this.MainView_Activated);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.panel1.ResumeLayout(false);
            this.Buscador.ResumeLayout(false);
            this.Buscador.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtMantOrden;
        private System.Windows.Forms.Button BtMantSolicitud;
        private System.Windows.Forms.Button btnMantProveedor;
        private System.Windows.Forms.Button BtMantMedida;
        private System.Windows.Forms.Button BtMantMarca;
        private System.Windows.Forms.Button BtMantArticulo;
        private System.Windows.Forms.Button BtMantDepartamentos;
        private System.Windows.Forms.Button BtMantEmpleados;
        private System.Windows.Forms.Panel Buscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCriterio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.BindingSource sistemaComprasDataSetBindingSource;
        private SistemaComprasDataSet sistemaComprasDataSet;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private SistemaComprasDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
    }
}

