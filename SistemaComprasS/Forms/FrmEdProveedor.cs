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
   
    public partial class FrmEdProveedor : Form
    {
        public SqlConnection con { get; set; }
        public int IdProveedor { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }

        public FrmEdProveedor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        internal void showdialog()
        {
            throw new NotImplementedException();
        }

        private void FrmEdProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Identificacion' Puede moverla o quitarla según sea necesario.
            this.identificacionTableAdapter.Fill(this.sistemaComprasDataSet.Identificacion);

            if (!Modo.Equals("C"))
            {
                txtIdProveedor.Text = IdProveedor.ToString();
                cbxTipoIdentificacion.SelectedValue = TipoIdentificacion;
                txtIdentificacion.Text = Identificacion;
                txtNombre.Text = Nombre;
                

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
            string Idtipo = cbxTipoIdentificacion.SelectedValue.ToString();
            if (Idtipo == "1")
            {
                if (!validaCedula(txtIdentificacion.Text))
                {
                    MessageBox.Show("La Cedula no es valida");
                }
                else
                {
                    string sql = "";
                    if (Modo.Equals("C"))
                    {
                        sql = "insert into Proveedor values ('";
                        sql += cbxTipoIdentificacion.SelectedValue + "', '" + txtIdentificacion.Text + "', '"
                            + txtNombre.Text + "', '" + Estado + "')";
                    }
                    else
                    {
                        sql += "update Proveedor set ";

                        sql += "TipoIdentificacion = '" + cbxTipoIdentificacion.SelectedValue + "',";
                        sql += "Identificacion = '" + txtIdentificacion.Text + "',";
                        sql += "Nombre = '" + txtNombre.Text + "',";
                        sql += "Estado = '" + Estado + "'";
                        sql += " where IdProveedor = " + txtIdProveedor.Text;

                    }

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro ha sido guardado con exito.");
                    this.Close();
                }
            }
            else
            {
                if (!esUnRNCValido(txtIdentificacion.Text))
                {
                    MessageBox.Show("El RNC no es valido");
                }
                else
                {
                    string sql = "";
                    if (Modo.Equals("C"))
                    {
                        sql = "insert into Proveedor values ('";
                        sql += cbxTipoIdentificacion.SelectedValue + "', '" + txtIdentificacion.Text + "', '"
                            + txtNombre.Text + "', '" + Estado + "')";
                    }
                    else
                    {
                        sql += "update Proveedor set ";

                        sql += "TipoIdentificacion = '" + cbxTipoIdentificacion.SelectedValue + "',";
                        sql += "Identificacion = '" + txtIdentificacion.Text + "',";
                        sql += "Nombre = '" + txtNombre.Text + "',";
                        sql += "Estado = '" + Estado + "'";
                        sql += " where IdProveedor = " + txtIdProveedor.Text;

                    }

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro ha sido guardado con exito.");
                    this.Close();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Delete from Proveedor where IdProveedor = " + txtIdProveedor.Text;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro ha sido eliminado con exito.");
                this.Close();

            } catch (Exception ex)
            { MessageBox.Show("Hubo un error a eliminar, asegure que el proveedor no este en uso.");
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

        private bool esUnRNCValido(string pRNC)

        {

            int vnTotal = 0;

            int[] digitoMult = new int[8] { 7, 9, 8, 6, 5, 4, 3, 2 };

            string vcRNC = pRNC.Replace("-", "").Replace(" ", "");

            string vDigito = vcRNC.Substring(8, 1);

            if (vcRNC.Length.Equals(9))

                if (!"145".Contains(vcRNC.Substring(0, 1)))

                    return false;

            for (int vDig = 1; vDig <= 8; vDig++)

            {

                int vCalculo = Int32.Parse(vcRNC.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];

                vnTotal += vCalculo;

            }

            if (vnTotal % 11 == 0 && vDigito == "1" || vnTotal % 11 == 1 && vDigito == "1" ||

                (11 - (vnTotal % 11)).Equals(vDigito))

                return true;

            else

                return false;

        }
    }
}
