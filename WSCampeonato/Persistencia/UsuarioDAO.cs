using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WSCampeonato.Dominio;

namespace WSCampeonato.Persistencia
{
    public class UsuarioDAO
    {
        SqlConnection objConnection;
        public UsuarioDAO()
        {
            objConnection = new SqlConnection();
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        }
        public Usuario GetUsuario(string username, string password)
        {
            Usuario oUsuario = null;
            SqlDataReader objReader = null;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    objConnection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = objConnection;
                    cmd.CommandText = "SP_VALIDARUSUARIO";
                    cmd.Parameters.AddWithValue("@VC_USERNAME", username);
                    cmd.Parameters.AddWithValue("@VC_PASSWORD", password);
                    objReader = cmd.ExecuteReader();
                    while (objReader.Read())
                    {
                        oUsuario = new Usuario()
                        {
                            Id = Convert.ToInt32(objReader["IN_ID"]),
                            Usernanme = (objReader["VC_USERNAME"]).ToString(),
                            Password = (objReader["VC_PASSWORD"]).ToString(),
                            Estado =  Convert.ToBoolean(objReader["BT_ESTADO"]),
                        };
                    }
                    objReader.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                objConnection.Close();
            }
            return oUsuario;

        }

    }
}