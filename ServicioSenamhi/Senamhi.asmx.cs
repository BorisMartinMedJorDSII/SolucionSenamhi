using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data;//BUFFER MEMORIA SQL
using System.Data.SqlClient;//SQL SERVER
using System.Configuration;//CADENA CONEXION


namespace ServicioSenamhi
{
    /// <summary>
    /// Descripción breve de Senamhi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Senamhi : System.Web.Services.WebService
    {
        ///ACCEDER A LA CADENA DE CONEXION
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;

        [WebMethod(Description ="Mostrar las Temperaturas")]
        public DataSet ListarCiudades()
        {
            using (SqlConnection conexion = new SqlConnection(cadena)) //ENTRAR Y DEVOLVER DATOS
            {
                string consulta = "select * from TTIEMPO";    //CONSULTA A LA BASE DE DATOS 
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);  //EXTREA LA CONSULTA Y DATA

                DataSet data = new DataSet();
                adapter.Fill(data);  // LLENA 
                return data; //RETORNA EL SERVICIO

            }
        }

        [WebMethod(Description = "Listar Temperatura filtrado por Ciudad")]
         public DataSet ListarxCiudad(string ciudad)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select * from TTiempo where Lugar = @Ciudad"; //Trae dtos
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Ciudad", ciudad);
                SqlDataAdapter adapter = new SqlDataAdapter(comando);
                DataSet data = new DataSet();
                adapter.Fill(data);
                return data;
            }
        }

    }
}
