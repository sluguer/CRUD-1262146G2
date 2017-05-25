using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro oRegistro = new Registro();

            oRegistro.RegistrarUsuario(txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text,
                txtSegundoApellido.Text, cmbTipoIdentificacion.Text, int.Parse(txtIdentificacion.Text),
                dtpFechaNacimento.Text,txtGenero.Text , txtHobiees.Text, cmbRH.Text, cmbEPS.Text,
                cmbEstadoCivil.Text, txtProfesion.Text, txtCorreo.Text, txtDireccion.Text,
                long.Parse(txtTelefonoMovil.Text), long.Parse(txtTelefonoFijo.Text), txtUsuario.Text, txtClave.Text, int.Parse(cmbRol.Text));
        }
    }
}
