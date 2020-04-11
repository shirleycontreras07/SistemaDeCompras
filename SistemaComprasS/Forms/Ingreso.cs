﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComprasS
{
    public partial class Ingreso : Form
    {
        IngresoEntities db = new IngresoEntities();
        public Ingreso()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = db.Usuarios
                .Where(x => x.Usuario == txtUsuario.Text && x.Clave == txtClave.Text)
                .FirstOrDefault();

            if (usuario == null)
            {
                MessageBox.Show("Credenciales incorrectas");
                txtClave.ResetText();
            }
            else if (!usuario.Estado.Equals(1))
            {
                MessageBox.Show("Credenciales incorrectas");
                txtClave.ResetText();
            }
            else
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text);
                MainView frm = new MainView();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }
    }
}
