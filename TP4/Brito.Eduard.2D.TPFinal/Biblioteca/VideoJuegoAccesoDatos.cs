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

        public static void Guardar(string nombreVideoJuego, ENombreVideoConsola nombreVideoConsola, float precio, int stock)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO VideoJuegos (NombreVideoJuego) VALUES (@NombreVideoJuego)";
                command.Parameters.AddWithValue("@NombreVideoJuego", nombreVideoJuego);
                command.CommandText = $"INSERT INTO VideoJuegos (NombreVideoConsola) VALUES (@NombreVideoConsola)";
                command.Parameters.AddWithValue("@NombreVideoConsola", nombreVideoConsola);
                command.CommandText = $"INSERT INTO VideoJuegos (Precio) VALUES (@Precio)";
                command.Parameters.AddWithValue("@Precio", precio);
                command.CommandText = $"INSERT INTO VideoJuegos (Stock) VALUES (@Stock)";
                command.Parameters.AddWithValue("@Stock", stock);

                int rows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Guardar la Base de Datos", ex);
            }
            finally 
            {
                connection.Close(); 
            }
        }

    }
}
