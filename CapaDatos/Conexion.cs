using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class Conexion
    {
        private string con = @"Data Source=ING-SLUGUER;Initial Catalog=Ejercicio1;Integrated Security=True";
        //Data Source = ING - SLUGUER; Initial Catalog = PruebaLoginRol; Integrated Security = True
        //encapsular la variable privada (con)// 
        public string Cnn
        {
            get { return con; }
            set { value = con; }
        }

        //crear la variable para la conexion con sql server 
        public SqlConnection conec;

        //crear el metodo para la conexion 
        public SqlConnection conecte()
        {
            try
            {
                //instancia de la clase sqlconnection 
                conec = new SqlConnection(Cnn);
                conec.Open();
                return conec;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al conectar " + ex);
                conec.Close();
                return conec;
            }
        }
    }
}
