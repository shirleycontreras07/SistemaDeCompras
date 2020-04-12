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
    public partial class FrmEdOrden : Form
    {
        public SqlConnection con { get; set; }
        public int IdOrden { get; set; }
        public int Solicitud { get; set; }
        public string Fecha { get; set; }
        public int Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Medida { get; set; }
        public int Marca { get; set; }
        public Decimal Costo { get; set; }
        public bool Estado { get; set; }
        public string Modo { get; set; }
        public FrmEdOrden()
        {
            InitializeComponent();
        }

        private void FrmEdOrden_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Marca' Puede moverla o quitarla según sea necesario.
            this.marcaTableAdapter.Fill(this.sistemaComprasDataSet.Marca);
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.UndMedida' Puede moverla o quitarla según sea necesario.
            this.undMedidaTableAdapter.Fill(this.sistemaComprasDataSet.UndMedida);
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Articulo' Puede moverla o quitarla según sea necesario.
            this.articuloTableAdapter.Fill(this.sistemaComprasDataSet.Articulo);
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Solicitud' Puede moverla o quitarla según sea necesario.
            this.solicitudTableAdapter.Fill(this.sistemaComprasDataSet.Solicitud);

            if (!Modo.Equals("C"))
            {
                txtIdOrden.Text = IdOrden.ToString();
                cbxSolicitud.SelectedIndex = Solicitud;
                dtpOrden.Text = Fecha;
                cbxArticulo.SelectedIndex = Articulo;
                nudCantidad.Value = Cantidad;
                cbxMedida.SelectedIndex = Medida;
                cbxMarca.SelectedIndex = Marca;
                Costo = nudCosto.Value;
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
                sql = "insert into Orden values ('";
                sql += cbxSolicitud.SelectedIndex + "', '" + this.dtpOrden.Text + "', '" + cbEstado.Checked + "', '" + cbxArticulo.SelectedValue + "', '" 
                    + nudCantidad.Value + "', '" + cbxMedida.SelectedValue + "', '" + cbxMarca.SelectedValue + "', '" + Costo + "')";
            }
            else
            {
                sql += "update Orden set ";

                sql += "Solicitud = '" + cbxSolicitud.SelectedValue + "',";
                sql += "Fecha = '" + this.dtpOrden.Text + "',";
                sql += "Estado = '" + cbEstado.Checked + "'";
                sql += "Articulo = '" + cbxArticulo.SelectedValue + "',";
                sql += "Cantidad = '" + nudCantidad.Value + "',";
                sql += "Medida = '" + cbxMedida.SelectedValue + "',";
                sql += "Marca = '" + cbxMarca.SelectedValue+ "'";
                sql += "Costo = '" + Costo + "'";

                sql += " where IdOrden = " + txtIdOrden.Text;

            }

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro ha sido guardado con exito.");
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string sql = "Delete from Orden where IdOrden = " + txtIdOrden.Text;
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Registro ha sido eliminado con exito.");
            this.Close();
        }
    }
}
