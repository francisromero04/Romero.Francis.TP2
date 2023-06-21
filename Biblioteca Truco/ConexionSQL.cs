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
                ConexionSQL.comandoTexto.CommandText = "SELECT * FROM Partidas";
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

                comandoTexto.CommandText = "INSERT INTO Partidas VALUES (@Jugador1, @PuntosJugador1, @Jugador2, @PuntosJugador2, @Ganador)";
                comandoTexto.Parameters.AddWithValue("@Jugador1", partida.JugadorUno.NombreJugador);
                comandoTexto.Parameters.AddWithValue("@PuntosJugador1", partida.JugadorUno.Puntos);
                comandoTexto.Parameters.AddWithValue("@Jugador2", partida.JugadorDos.NombreJugador);
                comandoTexto.Parameters.AddWithValue("@PuntosJugador2", partida.JugadorDos.Puntos);
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
