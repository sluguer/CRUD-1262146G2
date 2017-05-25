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
   public class Registro
    {
        public SqlDataReader lector;
        public SqlCommand comando;
        public void RegistrarUsuario(string primerNombre, string segundoNombre, string primerApellido,
            string segundoApellido, string tipoIdentificacion, int identificacion, string fechaNacimiento,
            string genero, string hobbies, string RH, string EPS, string estadoCivil, string profesion,
            string correo, string direccion, Int64 telefonoMovil, Int64 telefonoFijo, string usuario, string clave,int rol)

        {
            Conexion oConexion = new Conexion();
            try
            {
                comando = new SqlCommand(" insert into Usuario values ('"+tipoIdentificacion +"'  ,'"+identificacion + "', '"+primerNombre + "','" + segundoNombre + "','" + primerApellido + "' ,'"+segundoApellido +"', '"+fechaNacimiento +"', '"+genero + "', '" + hobbies + "', '" + RH + "', '" + EPS + "','" + estadoCivil + "','" + profesion + "','" + correo + "','" + direccion + "','" + telefonoMovil + "','" + telefonoFijo + "','" + usuario + "','" + clave + "','" + rol + "'", oConexion.conecte());
                lector = comando.ExecuteReader();
                //if (lector.Read())
                //{
                //    MessageBox.Show("usuario y contraseña validos");

                //    return lector[0].ToString();


                //}
                //else
                //{
                //    MessageBox.Show("Usuario o contraseña Incorrectos");
                //    return "";
                //}
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar " + ex);
                //return "";
            }


        }
        //{
        //    this.primerNombre = primerNombre;
        //    this.segundoNombre = segundoNombre;
        //    this.primerApellido = primerApellido;
        //    this.segundoApellido = segundoApellido;
        //    this.tipoIdentificacion = tipoIdentificacion;
        //    this.identificacion = identificacion;
        //    this.fechaNacimiento = fechaNacimiento;
        //    this.genero = genero;
        //    this.hobbies = hobbies;
        //    this.RH = RH;
        //    this.EPS = EPS;
        //    this.estadoCivil = estadoCivil;
        //    this.profesion = profesion;
        //    this.correo = correo;
        //    this.direccion = direccion;
        //    this.telefonoMovil = telefonoMovil;
        //    this.telefonoFijo = telefonoFijo;
        //    this.usuario = usuario;
        //    this.clave = clave;
        //}

       



            //MessageBox.Show("su Primer Nombre es: "+ primerNombre+ " "+ "y apellido es  "+ primerApellido );
        }
    }

