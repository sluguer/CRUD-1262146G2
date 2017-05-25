using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaLogica
{
    public class Login
    {
        public SqlDataReader lector;
        public SqlCommand comando;

        public string ValidarUsuario(string Usuario, string Clave)
        {
            Conexion oConexion = new Conexion();
            try
            {
                comando = new SqlCommand("select idRol from Usuario where nickname = '" + Usuario + "' and clave = '" + Clave + "'",     oConexion.conecte());
                lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    MessageBox.Show("usuario y contraseña validos");

                    return lector[0].ToString();


                }
                else
                {
                    MessageBox.Show("Usuario o contraseña Incorrectos");
                    return "";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar " + ex);
                return "";
            }
        }
    }
}
