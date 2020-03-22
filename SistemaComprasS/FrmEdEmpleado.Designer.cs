namespace SistemaComprasS
{
    partial class FrmEdEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEdEmpleado));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaComprasDataSet = new SistemaComprasS.SistemaComprasDataSet();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.CheckBox();
            this.txtCedulaEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.departamentoTableAdapter = new SistemaComprasS.SistemaComprasDataSetTableAdapters.DepartamentoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbxDepartamento);
            this.panel1.Controls.Add(this.txtIdEmpleado);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbEstado);
            this.panel1.Controls.Add(this.txtCedulaEmpleado);
            this.panel1.Controls.Add(this.txtNombreEmpleado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 181);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departamentoBindingSource, "IdDepartamento", true));
            this.cbxDepartamento.DataSource = this.departamentoBindingSource;
            this.cbxDepartamento.DisplayMember = "Descripcion";
            this.cbxDepartamento.FormattingEnabled = true;
            this.cbxDepartamento.Location = new System.Drawing.Point(95, 108);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Size = new System.Drawing.Size(100, 21);
            this.cbxDepartamento.TabIndex = 8;
            this.cbxDepartamento.ValueMember = "IdDepartamento";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "Departamento";
            this.departamentoBindingSource.DataSource = this.sistemaComprasDataSet;
            // 
            // sistemaComprasDataSet
            // 
            this.sistemaComprasDataSet.DataSetName = "SistemaComprasDataSet";
            this.sistemaComprasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(95, 24);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.ReadOnly = true;
            this.txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtIdEmpleado.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ID";
            // 
            // cbEstado
            // 
            this.cbEstado.AutoSize = true;
            this.cbEstado.Location = new System.Drawing.Point(95, 137);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(15, 14);
            this.cbEstado.TabIndex = 5;
            this.cbEstado.UseVisualStyleBackColor = true;
            // 
            // txtCedulaEmpleado
            // 
            this.txtCedulaEmpleado.Location = new System.Drawing.Point(95, 50);
            this.txtCedulaEmpleado.Name = "txtCedulaEmpleado";
            this.txtCedulaEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaEmpleado.TabIndex = 1;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(95, 79);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleado.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(45, 199);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 51);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(135, 199);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 51);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmEdEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 261);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEdEmpleado";
            this.Text = "FrmEdEmpleado";
            this.Load += new System.EventHandler(this.FrmEdEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaComprasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbEstado;
        private System.Windows.Forms.TextBox txtCedulaEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxDepartamento;
        private SistemaComprasDataSet sistemaComprasDataSet;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private SistemaComprasDataSetTableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
    }
}