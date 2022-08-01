using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class VideoJuegoAccesoDatos
    {
        static string conectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static VideoJuegoAccesoDatos()
        {
            conectionString = @"Data Source=.;Initial Catalog=LISTA_VIDEOJUEGOS;Integrated Security=true";
            command = new SqlCommand();
            connection = new SqlConnection(conectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// Lee la base de datos de VideoJuegos
        /// </summary>
        /// <returns>Retorna una lista con la base de datos de VideoJuegos</returns>
        /// <exception cref="Exception"></exception>
        public static List<VideoJuego> Leer()
        {
            List<VideoJuego> lista = new List<VideoJuego>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM VideoJuegos";

                using (SqlDataReader dataReader = command.ExecuteReader()) 
                {
                    while (dataReader.Read())
                    {
                        lista.Add(new VideoJuego(dataReader["NombreVideoJuego"].ToString(), (ENombreVideoConsola)Enum.Parse(typeof(ENombreVideoConsola),(string)dataReader["NombreVideoConsola"]), Convert.ToInt64(dataReader["Precio"]), Convert.ToInt32(dataReader["Stock"])));
                        
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al leer la Base de Datos", ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
