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

namespace SistemaComprasS
{
    public partial class MainView : Form
    {
        SqlConnection con = null;
        
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtMantEmpleados_Click(object sender, EventArgs e)
        {
            txtBuscar.ResetText();
            cbxCriterio.ResetText();
            this.consulta = "Empleado";
            ejecutarConsulta();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (this.consulta == "Marca")
            {
               
                string sSQL = "select * from Marca ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
            }
            else if (this.consulta == "Empleado")
            {
                
                string sSQL = "select * from Empleado ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
                
            }
            else if (this.consulta == "Departamento")
            {
            
                string sSQL = "select * from Departamento ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
            }
            else if (this.consulta == "Articulo")
            {
                string sSQL = "select * from Articulo ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);

            }
            else if (this.consulta == "UndMedida")
            {
                string sSQL = "select * from UndMedida ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
            }
            else if (this.consulta == "Orden")
            {
                string sSQL = "select * from Orden ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
            }
            else if (this.consulta == "Proveedor")
            {
                string sSQL = "select * from Proveedor ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
            }
            else if (this.consulta == "Solicitud")
            {
                string sSQL = "select * from Solicitud ";
                sSQL += " where " + cbxCriterio.SelectedItem;
                sSQL += " like '%" + txtBuscar.Text + "%'";
                sSQL += " order by " + cbxCriterio.SelectedItem;
                ejecutarConsultaBD(sSQL);
            }
            
        }
        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (this.consulta == "Marca")
            {
                FrmEdMarca frm = new FrmEdMarca();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            }
            else if (this.consulta == "Empleado")
            {
                FrmEdEmpleado frm = new FrmEdEmpleado();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            }
            else if (this.consulta == "Departamento")
            {
                FrmEdDepartamento frm = new FrmEdDepartamento();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            } else if (this.consulta == "Articulo")
            {
                FrmEdArticulo frm = new FrmEdArticulo();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();

            }else if (this.consulta == "UndMedida")
            {
                frmEdMedida frm = new frmEdMedida();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            } else if (this.consulta == "Orden")
            {
                FrmEdOrden frm = new FrmEdOrden();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            }
            else if (this.consulta == "Proveedor")
            {
                FrmEdProveedor frm = new FrmEdProveedor();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            }
            else if (this.consulta == "Solicitud")
            {
                frmEdSolicitud frm = new frmEdSolicitud();
                frm.con = con;
                frm.Modo = "C";
                frm.ShowDialog();
            }
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

        /*private void dgvResultado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (consulta == "Marca") { 
                DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                FrmEdMarca frm = new FrmEdMarca();

                int idMarca = frm.IdMarca;
                string idMarcaS = string.Empty + idMarca;
                idMarcaS = row.Cells[0].Value.ToString();

                frm.Descripcion = row.Cells[1].Value.ToString();

                string estadoS = Convert.ToString(frm.Estado);
                estadoS = row.Cells[2].Value.ToString();

                frm.Modo = "E";
                frm.con = con;
                frm.ShowDialog();
            } else if(consulta == "Departamento")
            {
                DataGridViewRow row = this.dgvResultado.SelectedRows[0];
                FrmEdDepartamento frm = new FrmEdDepartamento();

                int idDepartamento = frm.IdDepartamento;
                string idDepartamentoS = string.Empty + idDepartamento;
                idDepartamentoS = row.Cells[0].Value.ToString();

                frm.Descripcion = row.Cells[1].Value.ToString();

                string estadoS = Convert.ToString(frm.Estado);
                estadoS = row.Cells[2].Value.ToString();

                frm.Modo = "E";
                frm.con = con;
                frm.ShowDialog();
            } 


        }*/

      

        private void ejecutarConsulta()
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-VUC2IM6K\\MSSQLSERVER01;Initial Catalog=SistemaCompras; Integrated Security=True");
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

        private void ejecutarConsultaBD(string pSQL)
        {
            try
            {
                SqlConnection oCon = new SqlConnection("Data Source=LAPTOP-VUC2IM6K\\MSSQLSERVER01;Initial Catalog=SistemaCompras; Integrated Security=True");
                oCon.Open();

                SqlDataAdapter oDa = new SqlDataAdapter(pSQL, oCon);
                DataTable oTable = new DataTable();
                oDa.Fill(oTable);
                dgvResultado.DataSource = oTable;
                dgvResultado.Refresh();
            } catch (Exception ex) { MessageBox.Show("No se pudo ejecutar la consulta."); }
           
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.consulta == "Marca")
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
            }
            else if (this.consulta == "Departamento")
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
            }
            else if (this.consulta == "UndMedida")
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
            }
            else if (this.consulta == "Empleado")
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
            }
            else if (this.consulta == "Articulo")
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
            }
            else if (this.consulta == "Orden")
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
            }
            else if (this.consulta == "Proveedor")
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
            }
            else if (this.consulta == "Solicitud")
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
            }


        }

        private void MainView_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaComprasDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.sistemaComprasDataSet.Empleado);

        }

        private void MainView_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvResultado.Refresh();
                con = new SqlConnection("Data Source=LAPTOP-VUC2IM6K\\MSSQLSERVER01;Initial Catalog=SistemaCompras; Integrated Security=True");
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
