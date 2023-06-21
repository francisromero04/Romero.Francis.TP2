using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection.PortableExecutable;

namespace Biblioteca_Truco
{
    public static class ConexionSQL
    {
        private static SqlConnection conexion;
        private static SqlCommand comandoTexto;
        private static SqlDataReader? dataReader; //ES NULLEABLE

        static ConexionSQL()
        {
            conexion = new SqlConnection("Server = .;Database = Truco_Simulador;Trusted_Connection = True;");
            comandoTexto = new SqlCommand();
            comandoTexto.CommandType = CommandType.Text;
            comandoTexto.Connection = conexion;
        }

        public static void CerrarConexion()
        {
            if (ConexionSQL.conexion.State == System.Data.ConnectionState.Open)
            {
                ConexionSQL.conexion.Close();
            }
        }

        public static SqlDataReader Leer()
        {          
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

        public static void GuardarPartidaSQL(Partida partida)
        {
            try
            {
                Jugador ganador = partida.CalcularGanador();
                string ganadorNombre = (ganador == null) ? "Empate" : ganador.NombreJugador;

                comandoTexto.CommandText = "INSERT INTO TablaPartidas VALUES (@JugadorUno, @PuntosJugadorUno, @JugadorDos, @PuntosJugadorDos, @Ganador)";
                comandoTexto.Parameters.AddWithValue("@JugadorUno", partida.JugadorUno.NombreJugador);
                comandoTexto.Parameters.AddWithValue("@PuntosJugadorUno", partida.JugadorUno.Puntos);
                comandoTexto.Parameters.AddWithValue("@JugadorDos", partida.JugadorDos.NombreJugador);
                comandoTexto.Parameters.AddWithValue("@PuntosJugadorDos", partida.JugadorDos.Puntos);
                comandoTexto.Parameters.AddWithValue("@Ganador", ganadorNombre);

                conexion.Open();
                comandoTexto.ExecuteNonQuery();
                comandoTexto.Parameters.Clear();
            }
            catch (Exception)
            {
                throw new ExcepcionConectar();
            }
            finally
            {
                CerrarConexion();
            }
        }
    }
}
