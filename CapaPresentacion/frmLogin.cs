using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CapaLogica.Login oLogin = new CapaLogica.Login();
           
            switch (oLogin.ValidarUsuario(txtUsuario.Text, txtClave.Text))
            {
                case "1":
                    
                    this.Hide();
                     Administrador oAdmin = new Administrador();
                     oAdmin.Show();
                break;
                case "2":

                    this.Hide();
                    Empleado oEmpleado = new Empleado();
                    oEmpleado.Show();
                    break;
                case "3":

                    this.Hide();
                    Invitado oInvitado = new Invitado();
                    oInvitado .Show();
                    break;

                default:
                    break;
            }
             //if (loTraidoBd=="1")
             //{
             //    this.Hide();
             //    Administrador oAdmin = new Administrador();
             //    oAdmin.Show();
             //}





        }

    }
}
