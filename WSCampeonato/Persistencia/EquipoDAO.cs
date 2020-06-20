using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WSCampeonato.Dominio;
namespace WSCampeonato.Persistencia
{
    public class EquipoDAO
    {
        SqlConnection objConnection;
        public EquipoDAO()
        {
            objConnection = new SqlConnection();
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        }

        public bool RegistrarEquipo(Equipo oEquipo)
        {

            var response = true;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    objConnection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = objConnection;
                    cmd.CommandText = "SP_CREATE_EQUIPO";
                    cmd.Parameters.AddWithValue("@NOMBRE", oEquipo.Nombre);
                    cmd.Parameters.AddWithValue("@VC_ID_MODALIDAD", oEquipo.Modalidad);
                    cmd.Parameters.AddWithValue("@BT_ESTADO", oEquipo.Estado);
                    // cmd.Parameters.AddWithValue("@CODPROCESOM", oLogArchivo.CodigoMotores).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();

                }
                response = true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                objConnection.Close();
            }

            return response;

        }
    }
}