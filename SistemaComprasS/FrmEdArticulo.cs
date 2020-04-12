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
    public partial class FrmEdArticulo : Form
    {
        public int EstadoValue = 0;
        public SqlConnection con { get; set; }
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Marca { get; set; }
        public int Medida { get; set; }
        public int Existencia { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }
        public FrmEdArticulo()
        {
            InitializeComponent();
        }

        
        private void FrmEdArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.sistemaComprasDataSet.Marca);
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.UndMedida' Puede moverla o quitarla según sea necesario.
            this.undMedidaTableAdapter.Fill(this.sistemaComprasDataSet.UndMedida);


            if (!Modo.Equals("C"))
            {
                
                //txtIdArticulo.Enabled = Modo.Equals("C");
                txtIdArticulo.Text = IdArticulo.ToString();
                txtDescripcion.Text = Descripcion;
                cbxMarca.SelectedIndex = Marca;
                cbxMedida.SelectedIndex = Medida;
                nudExistencia.Value = Existencia;
                nudCosto.Value = Costo;
                cbEstado.Checked = Estado;

                this.Text += " : Editando";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (Modo.Equals("C"))
            {
                sql = "insert into Articulo values ('";
                sql += txtDescripcion.Text + "', " + cbxMarca.SelectedValue + " , "
                    + cbxMedida.SelectedValue + ", " + Convert.ToInt32(nudExistencia.Value) + ", " + Convert.ToInt32(nudCosto.Value) + ", '" + cbEstado.Checked + " ')";
            }
            else
            {

                sql += "update Articulo set ";

                sql += "Descripcion = '" + txtDescripcion.Text + "',";
                sql += "Marca = " + cbxMarca.SelectedValue + ",";
                sql += "Medida= " + cbxMedida.SelectedValue + ",";
                sql += "Existencia = " + Convert.ToInt32(nudExistencia.Value) + ",";
                sql += "Costo = " + Convert.ToInt32(nudCosto.Value) + ",";
                sql += "Estado = '" + cbEstado.Checked + "' ";
                sql += " where IdArticulo = " + txtIdArticulo.Text;
                

            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro ha sido guardado con exito.");
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try {

                string sql = "Delete from Articulo where IdArticulo = " + IdArticulo;
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Registro ha sido eliminado con exito.");

                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Hubo un error a eliminar, asegure que el articulo no este en uso.");
            }
            
        }
    }
}
