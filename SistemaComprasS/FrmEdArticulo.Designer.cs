namespace SistemaComprasS
{
    partial class FrmEdArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdArticulo));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxMedida = new System.Windows.Forms.ComboBox();
            this.undMedidaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComprasDataSet = new SistemaComprasS.SistemaComprasDataSet();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudExistencia = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sistemaComprasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.undMedidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.undMedidaTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.UndMedidaTableAdapter();
            this.sistemaComprasDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.MarcaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(136, 217);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 51);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(41, 217);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 51);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxMedida);
            this.panel1.Controls.Add(this.cbxMarca);
            this.panel1.Controls.Add(this.txtIdArticulo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nudExistencia);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 199);
            this.panel1.TabIndex = 8;
            // 
            // cbxMedida
            // 
            this.cbxMedida.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.undMedidaBindingSource1, "IdUndMedida", true));
            this.cbxMedida.DataSource = this.undMedidaBindingSource1;
            this.cbxMedida.DisplayMember = "Descripcion";
            this.cbxMedida.FormattingEnabled = true;
            this.cbxMedida.Location = new System.Drawing.Point(93, 107);
            this.cbxMedida.Name = "cbxMedida";
            this.cbxMedida.Size = new System.Drawing.Size(100, 21);
            this.cbxMedida.TabIndex = 11;
            this.cbxMedida.ValueMember = "IdUndMedida";
            // 
            // undMedidaBindingSource1
            // 
            this.undMedidaBindingSource1.DataMember = "UndMedida";
            this.undMedidaBindingSource1.DataSource = this.sistemaComprasDataSet;
            // 
            // sistemaComprasDataSet
            // 
            this.sistemaComprasDataSet.DataSetName = "SistemaComprasDataSet";
            this.sistemaComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.marcaBindingSource, "IdMarca", true));
            this.cbxMarca.DataSource = this.marcaBindingSource;
            this.cbxMarca.DisplayMember = "Descripcion";
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(93, 78);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(100, 21);
            this.cbxMarca.TabIndex = 10;
            this.cbxMarca.ValueMember = "IdMarca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(93, 23);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.ReadOnly = true;
            this.txtIdArticulo.Size = new System.Drawing.Size(100, 20);
            this.txtIdArticulo.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // nudExistencia
            // 
            this.nudExistencia.Location = new System.Drawing.Point(93, 134);
            this.nudExistencia.Name = "nudExistencia";
            this.nudExistencia.Size = new System.Drawing.Size(69, 20);
            this.nudExistencia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Existencia";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(93, 166);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(93, 49);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Medida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // sistemaComprasDataSetBindingSource
            // 
            this.sistemaComprasDataSetBindingSource.DataSource = this.sistemaComprasDataSet;
            this.sistemaComprasDataSetBindingSource.Position = 0;
            // 
            // undMedidaBindingSource
            // 
            this.undMedidaBindingSource.DataMember = "UndMedida";
            this.undMedidaBindingSource.DataSource = this.sistemaComprasDataSetBindingSource;
            // 
            // undMedidaTableAdapter
            // 
            this.undMedidaTableAdapter.ClearBeforeFill = true;
            // 
            // sistemaComprasDataSetBindingSource1
            // 
            this.sistemaComprasDataSetBindingSource1.DataSource = this.sistemaComprasDataSet;
            this.sistemaComprasDataSetBindingSource1.Position = 0;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEdArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 289);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdArticulo";
            this.Text = "FrmEdArticulo";
            this.Load += new System.EventHandler(this.FrmEdArticulo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undMedidaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudExistencia;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxMedida;
        private System.Windows.Forms.BindingSource sistemaComprasDataSetBindingSource;
        private SistemaComprasDataSet sistemaComprasDataSet;
        private System.Windows.Forms.BindingSource undMedidaBindingSource;
        private SistemaComprasDataSetTableAdapters.UndMedidaTableAdapter undMedidaTableAdapter;
        private System.Windows.Forms.BindingSource undMedidaBindingSource1;
        private System.Windows.Forms.BindingSource sistemaComprasDataSetBindingSource1;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private SistemaComprasDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}