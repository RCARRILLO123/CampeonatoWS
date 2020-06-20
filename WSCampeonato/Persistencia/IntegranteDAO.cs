using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using WSCampeonato.Dominio;
using System.Data;

namespace WSCampeonato.Persistencia
{
    public class IntegranteDAO
    {
        SqlConnection objConnection;
        public IntegranteDAO()
        {
            objConnection = new SqlConnection();
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        }

        public Integrante RegistrarIntegrante(Integrante oIntegrante)
        {
            Integrante obj = new Integrante();
            int codintegrante = 0;
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    objConnection.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Connection = objConnection;
                    cmd.CommandText = "SP_CREATE_INTEGRANTE";
                    cmd.Parameters.AddWithValue("@VC_NOMBRE", oIntegrante.Nombre);
                    cmd.Parameters.AddWithValue("@VC_APELLIDOS", oIntegrante.Apellidos);
                    cmd.Parameters.AddWithValue("@VC_SEXO", oIntegrante.Sexo);
                    cmd.Parameters.AddWithValue("@VC_CORREO", oIntegrante.Correo);
                    cmd.Parameters.AddWithValue("@BT_ESTADO", oIntegrante.Estado);      
                    cmd.Parameters.AddWithValue("@IN_ID", oIntegrante.Id).Direction = ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    obj.Id = Convert.ToInt32(cmd.Parameters["@IN_ID"].Value);

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

            return obj;

        }

    }
}