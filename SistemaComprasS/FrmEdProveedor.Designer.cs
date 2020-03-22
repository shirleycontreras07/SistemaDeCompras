namespace SistemaComprasS
{
    partial class FrmEdProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdProveedor));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxTipoIdentificacion = new System.Windows.Forms.ComboBox();
            this.sistemaComprasDataSet = new SistemaComprasS.SistemaComprasDataSet();
            this.identificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.identificacionTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.IdentificacionTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(144, 177);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 51);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(59, 177);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 51);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxTipoIdentificacion);
            this.panel1.Controls.Add(this.txtIdProveedor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 159);
            this.panel1.TabIndex = 14;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(130, 25);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtIdProveedor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre comercial";
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(130, 77);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identificacion ";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(131, 128);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de identificacion ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbxTipoIdentificacion
            // 
            this.cbxTipoIdentificacion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.identificacionBindingSource, "IdIdentificacion", true));
            this.cbxTipoIdentificacion.DataSource = this.identificacionBindingSource;
            this.cbxTipoIdentificacion.DisplayMember = "Descripcion";
            this.cbxTipoIdentificacion.FormattingEnabled = true;
            this.cbxTipoIdentificacion.Location = new System.Drawing.Point(130, 51);
            this.cbxTipoIdentificacion.Name = "cbxTipoIdentificacion";
            this.cbxTipoIdentificacion.Size = new System.Drawing.Size(100, 21);
            this.cbxTipoIdentificacion.TabIndex = 12;
            this.cbxTipoIdentificacion.ValueMember = "IdIdentificacion";
            // 
            // sistemaComprasDataSet
            // 
            this.sistemaComprasDataSet.DataSetName = "SistemaComprasDataSet";
            this.sistemaComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // identificacionBindingSource
            // 
            this.identificacionBindingSource.DataMember = "Identificacion";
            this.identificacionBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // identificacionTableAdapter
            // 
            this.identificacionTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 251);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdProveedor";
            this.Text = "FrmEdProveedor";
            this.Load += new System.EventHandler(this.FrmEdProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identificacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxTipoIdentificacion;
        private SistemaComprasDataSet sistemaComprasDataSet;
        private System.Windows.Forms.BindingSource identificacionBindingSource;
        private SistemaComprasDataSetTableAdapters.IdentificacionTableAdapter identificacionTableAdapter;
    }
}