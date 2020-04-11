using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SistemaComprasS
{
    public partial class MainView : Form
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SistemaCompras"].ToString());
        string consulta = "";

        public MainView()
        {
            InitializeComponent();
        }

        private void BtMantMarca_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Marca";
            ejecutarConsulta();
        }

        private void BtMantEmpleados_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Empleado";
            ejecutarConsulta();
        }
        private void BtMantDepartamentos_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Departamento";
            ejecutarConsulta();
        }

        private void BtMantArticulo_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Articulo";
            ejecutarConsulta();
        }

        private void BtMantMedida_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "UndMedida";
            ejecutarConsulta();
        }

        private void btnMantProveedor_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Proveedor";
            ejecutarConsulta();
        }

        private void BtMantSolicitud_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Solicitud";
            ejecutarConsulta();
        }

        private void BtMantOrden_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Orden";
            ejecutarConsulta();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ejecutarConsultaBD();
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            switch (this.consulta)
            {
                case "Marca":
                {
                    FrmEdMarca frm = new FrmEdMarca();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "Empleado":
                {
                    FrmEdEmpleado frm = new FrmEdEmpleado();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "Departamento":
                {
                    FrmEdDepartamento frm = new FrmEdDepartamento();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "Articulo":
                {
                    FrmEdArticulo frm = new FrmEdArticulo();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "UndMedida":
                {
                    frmEdMedida frm = new frmEdMedida();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "Orden":
                {
                    FrmEdOrden frm = new FrmEdOrden();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "Proveedor":
                {
                    FrmEdProveedor frm = new FrmEdProveedor();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
                case "Solicitud":
                {
                    frmEdSolicitud frm = new frmEdSolicitud();
                    frm.con = con;
                    frm.Modo = "C";
                    frm.ShowDialog();
                    break;
                }
            }
        }


        private void ejecutarConsulta()
        {
            try
            {
                con.Open();
                string sql = $"select * from {this.consulta}";

                if (cbxCriterio.Text.Length > 0)
                {
                    sql += " where " + cbxCriterio.Text + " like '%" + txtBuscar.Text + "%'";
                    sql += " order by " + cbxCriterio.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultado.DataSource = dt;
                dgvResultado.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }
        }

        private void ejecutarConsultaBD()
        {
            try
            {
                string sql = $"select * from {this.consulta}";
                sql += " where " + cbxCriterio.SelectedItem;
                sql += " like '%" + txtBuscar.Text + "%'";
                sql += " order by " + cbxCriterio.SelectedItem;

                con.Open();

                SqlDataAdapter oDa = new SqlDataAdapter(sql, con);
                DataTable oTable = new DataTable();
                oDa.Fill(oTable);
                dgvResultado.DataSource = oTable;
                dgvResultado.Refresh();
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudo ejecutar la consulta.");
            }           
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (this.consulta)
            {
                case "Marca":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    FrmEdMarca frm = new FrmEdMarca();

                    int idMarca = (int)row.Cells[0].Value;
                    frm.IdMarca = idMarca;

                    frm.Descripcion = row.Cells[1].Value.ToString();

                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[2].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "Departamento":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    FrmEdDepartamento frm = new FrmEdDepartamento();

                    int idDepartamento = (int)row.Cells[0].Value;
                    frm.IdDepartamento = idDepartamento;

                    frm.Descripcion = row.Cells[1].Value.ToString();

                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[2].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "UndMedida":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    frmEdMedida frm = new frmEdMedida();

               
                    int idUndMedida = (int)row.Cells[0].Value;
                    frm.IdUndMedida = idUndMedida;

                    frm.Descripcion = row.Cells[1].Value.ToString();

                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[2].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "Empleado":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    FrmEdEmpleado frm = new FrmEdEmpleado();

                    int idEmpleado = (int)row.Cells[0].Value;
                    frm.IdEmpleado = idEmpleado;

                    frm.Cedula = row.Cells[1].Value.ToString();

                    frm.Nombre = row.Cells[2].Value.ToString();

                    int Departamento = frm.Departamento;
                    string DepartamentoS = string.Empty + Departamento;
                    DepartamentoS = row.Cells[3].Value.ToString();

                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[4].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "Articulo":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    FrmEdArticulo frm = new FrmEdArticulo();

                    int idArticulo = (int) row.Cells[0].Value;
                    frm.IdArticulo = idArticulo;

                    frm.Descripcion = row.Cells[1].Value.ToString();

                    int Marca = frm.Marca;
                    string MarcaS = string.Empty + Marca;
                    MarcaS = row.Cells[2].Value.ToString();

                    int Medida = frm.Medida;
                    string MedidaS = string.Empty + Medida;
                    MedidaS = row.Cells[3].Value.ToString();

                    int Existencia = frm.Existencia;
                    string ExistenciaS = string.Empty + Existencia;
                    ExistenciaS = row.Cells[4].Value.ToString();


                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[5].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "Orden":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    FrmEdOrden frm = new FrmEdOrden();

                    int idOrden = (int)row.Cells[0].Value;
                    frm.IdOrden = idOrden;

                    int Solicitud = frm.Solicitud;
                    string SolicitudS = string.Empty + Solicitud;
                    SolicitudS = row.Cells[1].Value.ToString();

                    string Fecha = frm.Fecha;
                    string FechaS = Convert.ToString(Fecha);
                    FechaS = row.Cells[2].Value.ToString();

                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[3].Value.ToString();

                    int Articulo = frm.Articulo;
                    string ArticuloS = string.Empty + Articulo;
                    ArticuloS = row.Cells[4].Value.ToString();

                    int Cantidad = frm.Cantidad;
                    string CantidadS = string.Empty + Cantidad;
                    CantidadS = row.Cells[5].Value.ToString();

                    int Medida = frm.Medida;
                    string MedidaS = string.Empty + Medida;
                    MedidaS = row.Cells[6].Value.ToString();


                    int Marca = frm.Marca;
                    string MarcaS = string.Empty + Marca;
                    MarcaS = row.Cells[7].Value.ToString();

                    decimal Costo = frm.Costo;
                    string CostoS = string.Empty + Costo;
                    CostoS = row.Cells[8].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "Proveedor":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    FrmEdProveedor frm = new FrmEdProveedor();

                    int idProveedor = (int)row.Cells[0].Value;
                    frm.IdProveedor = idProveedor;

                    int Tipo = frm.TipoIdentificacion;
                    string TipoS = string.Empty + Tipo;
                    TipoS = row.Cells[1].Value.ToString();

                    frm.Identificacion = row.Cells[2].Value.ToString();

                    frm.Nombre = row.Cells[3].Value.ToString();
                
                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[4].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
                case "Solicitud":
                {
                    DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                    frmEdSolicitud frm = new frmEdSolicitud();

                    int idSolicitud = (int)row.Cells[0].Value;
                    frm.IdSolicitud = idSolicitud;

                    int Empleado = frm.Empleado;
                    string EmpleadoS = string.Empty + Empleado;
                    EmpleadoS = row.Cells[1].Value.ToString();

                    String Fecha = frm.Fecha;
                    string FechaS = Convert.ToString(Fecha);
                    FechaS = row.Cells[2].Value.ToString();


                    int Articulo = frm.Articulo;
                    string ArticuloS = string.Empty + Articulo;
                    ArticuloS = row.Cells[3].Value.ToString();

                    int Cantidad = frm.Cantidad;
                    string CantidadS = string.Empty + Cantidad;
                    CantidadS = row.Cells[4].Value.ToString();

                    int Medida = frm.Medida;
                    string MedidaS = string.Empty + Medida;
                    MedidaS = row.Cells[5].Value.ToString();

                    string estadoS = Convert.ToString(frm.Estado);
                    estadoS = row.Cells[6].Value.ToString();

                    frm.Modo = "E";
                    frm.con = con;
                    frm.ShowDialog();
                    break;
                }
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.sistemaComprasDataSet.Empleado);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultado.Refresh();
                con.Open();
                string sql = "select * from " + this.consulta;
                if (cbxCriterio.Text.Length > 0)
                {
                    sql += " where " + cbxCriterio.Text + " like '%" + txtBuscar.Text + "%'";
                    sql += " order by " + cbxCriterio.Text;
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvResultado.DataSource = dt;
                dgvResultado.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }

        }
    }
}
