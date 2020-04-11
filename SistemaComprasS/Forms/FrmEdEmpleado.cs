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
    public partial class FrmEdEmpleado : Form
    {
        public SqlConnection con { get; set; }
        public int IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Departamento { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }


        public FrmEdEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEdEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.sistemaComprasDataSet.Departamento);
            if (!Modo.Equals("C"))
            {
                txtIdEmpleado.Text = IdEmpleado.ToString();
                txtCedulaEmpleado.Text = Cedula;
               
                txtNombreEmpleado.Text = Nombre;
                cbxDepartamento.SelectedValue = Departamento;

                if (cbEstado.Checked == true)
                {
                    Estado = true;
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
            if (!validaCedula(txtCedulaEmpleado.Text))
            {
                MessageBox.Show("La Cedula no es valida");
            }
            else
            {
                string sql = "";
                if (Modo.Equals("C"))
                {
                    sql = "insert into Empleado values ('";
                    sql += txtCedulaEmpleado.Text + "', '" + txtNombreEmpleado.Text + "', '" + cbxDepartamento.SelectedValue + "', '" + Estado + "')";
                }
                else
                {
                    sql += "update Empleado set ";

                    sql += "Cedula = '" + txtCedulaEmpleado.Text + "',";
                    sql += "Nombre = '" + txtNombreEmpleado.Text + "',";
                    sql += "Departamento = '" + cbxDepartamento.SelectedValue + "',";
                    sql += "Estado = '" + Estado + "'";
                    sql += " where IdEmpleado = " + txtIdEmpleado.Text;

                }

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro ha sido guardado con exito.");
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Delete from Empleado where IdEmpleado = " + txtIdEmpleado.Text;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro ha sido eliminado con exito.");
                this.Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Hubo un error a eliminar, asegure que el empleado no sea parte de una solicitud.");
            }
        }

        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
