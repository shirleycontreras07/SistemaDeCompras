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
    public partial class frmEdMedida : Form
    {
        public int estadoValue = 0;
        public SqlConnection con { get; set; }
        public int IdUndMedida { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }

        public frmEdMedida()
        {
            InitializeComponent();
        }

        private void frmEdMedida_Load(object sender, EventArgs e)
        {
            if (!Modo.Equals("C"))
            {
                txtIdMedida.Text = IdUndMedida.ToString();
                txtNombreMedida.Text = Descripcion;

                
                if (cbEstado.Checked == true)
                {
                    Estado = true;
                    estadoValue = 1;
                }
                else
                {
                    Estado = false;
                }

                this.Text += " : Editando";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (Modo.Equals("C"))
            {
                sql = "insert into UndMedida values ('";
                sql += txtNombreMedida.Text + "', '" + estadoValue + "')";
            }
            else
            {
                sql += "update UndMedida set ";

                sql += "Descripcion = '" + txtNombreMedida.Text + "',";
                sql += "Estado = '" + estadoValue + "' ";
                sql += "where IdUndMedida = '" + txtIdMedida.Text + "'";

            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro ha sido guardado con exito.");
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Delete from UndMedida where IdUndMedida = '" + txtIdMedida.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro ha sido eliminado con exito.");
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show("Hubo un error a eliminar, asegure que la unidad de medida no este en uso.");
            }
           
        }
    }
}
