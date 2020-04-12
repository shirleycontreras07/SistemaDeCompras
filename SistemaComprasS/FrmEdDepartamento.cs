using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComprasS
{
    public partial class FrmEdDepartamento : Form
    {
        public SqlConnection con { get; set; }
        public int IdDepartamento { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }

        public FrmEdDepartamento()
        {
            InitializeComponent();
        }

        private void FrmEdDepartamento_Load(object sender, EventArgs e)
        {
            if (!Modo.Equals("C"))
            {
                txtIdDepartamento.Text = IdDepartamento.ToString();
                txtNombreDepartamento.Text = Descripcion;
                cbEstado.Checked = Estado;

                //if (cbEstado.Checked == true)
                //{
                //    Estado = true;
                //}
                //else
                //{
                //    Estado = false;
                //}

                this.Text += " : Editando";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             string sql = "";
            if (Modo.Equals("C"))
            {
                sql = "insert into Departamento values ('";
                sql += txtNombreDepartamento.Text + "', '" + cbEstado.Checked + "')";
            }
            else
            {
                sql += "update Departamento set ";

                sql += "Descripcion = '" + txtNombreDepartamento.Text + "',";
                sql += "Estado = '" + cbEstado.Checked + "'";
                sql += " where IdDepartamento = " + txtIdDepartamento.Text;

            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro ha sido guardado con exito.");
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                string sql = "Delete from Departamento where IdDepartamento = '" + txtIdDepartamento.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro ha sido eliminado con exito.");
                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Hubo un error a eliminar, asegure que el departamento no tenga ningun empleado dependiente.");
            }
            
        }
    }
}
