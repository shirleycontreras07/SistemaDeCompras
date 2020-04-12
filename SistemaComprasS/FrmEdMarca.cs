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
    public partial class FrmEdMarca : Form
    {
        public SqlConnection con { get; set; }
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }


        public FrmEdMarca()
        {
            InitializeComponent();
        }

        private void FrmEdMarca_Load(object sender, EventArgs e)
        {
            if (!Modo.Equals("C"))
            {

                txtIDMarca.Text = IdMarca.ToString();
                txtNombreMarca.Text = Descripcion;
                cbEstado.Checked = Estado;

                //if (cbEstado.Checked == true)
                //{
                //    Estado = true;
                //} else
                //{
                //    Estado = false;
                //}

                this.Text += " : Editando";
            }
        }

        private void cbEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (Modo.Equals("C"))
            {
                sql = "insert into Marca values ('";
                sql += txtNombreMarca.Text + "', '" + cbEstado.Checked + "')";
            }
            else
            {
                sql += "update Marca set ";

                sql += "Descripcion = '" + txtNombreMarca.Text + "',";
                sql += "Estado = '" + cbEstado.Checked + "'";
                sql += " where IdMarca = " + txtIDMarca.Text;

            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro ha sido guardado con exito.");
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {
                string sql = "Delete from Marca where IdMarca = " + txtIDMarca.Text;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro ha sido eliminado con exito.");
                this.Close();
            } catch (Exception ex)
            { MessageBox.Show("Hubo un error a eliminar, asegure que la marca no este en uso.");
            }
            
        }
    }
}
