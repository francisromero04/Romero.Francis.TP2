using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca_Truco
{
    public static class ConexionSQL
    {
        private static SqlConnection conexion;
        private static SqlCommand comandoTexto;
        private static SqlDataReader dataReader;

        /// <summary>
        /// Constructor estático, setea datos de conexión.
        /// </summary>
        static ConexionSQL()
        {
            ConexionSQL.conexion = new SqlConnection("Server=.;Database=Truco_db;Trusted_Connection=True;");
            ConexionSQL.comandoTexto = new SqlCommand();
            ConexionSQL.comandoTexto.CommandType = System.Data.CommandType.Text;
            ConexionSQL.comandoTexto.Connection = conexion;
        }

        public static SqlConnection Conexion
        {
            get
            {
                return ConexionSQL.conexion;
            }
        }

        /// <summary>
        /// Cierra una conexión en caso de estar abierta.
        /// </summary>
        public static void Cerrar()
        {
            if (ConexionSQL.conexion.State == System.Data.ConnectionState.Open)
            {
                ConexionSQL.conexion.Close();
            }
        }

        /// <summary>
        /// Lee todo de la tabla TablaPartidas y lo trae en un SqlDataReader. Posteriormente se debe cerrar la conexión a través del método estático SQL.Cerrar().
        /// </summary>
        /// <returns>Un SqlDataReader con la data leída</returns>
        public static SqlDataReader Leer()
        {
            // El bloque finally con su correspondiente Close está en la llamada
            // ya que si lo cerraba antes, el DataReader que devolvía llegaba trunco. 

            try
            {
                ConexionSQL.comandoTexto.CommandText = "SELECT * FROM TablaPartidas";
                ConexionSQL.conexion.Open();
                ConexionSQL.dataReader = comandoTexto.ExecuteReader();
            }
            catch (Exception)
            {
                throw new ExcepcionConectar();
            }
            return ConexionSQL.dataReader;
        }
    }
}
