using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WSCampeonato.Dominio;
using System.Data.SqlClient;
namespace WSCampeonato.Persistencia
{
    public class PersonaDAO
    {
        SqlConnection objConnection;
        public PersonaDAO()
        {
            objConnection = new SqlConnection();
            objConnection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBConnectionString"].ToString();
        }

        //public Persona ObteneResumenPeriodo(string periodo)
        //{
        //    Persona oLogProceso = null;
        //    SqlDataReader objReader = null;
        //    try
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            objConnection.Open();
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.Connection = objConnection;
        //            cmd.CommandText = "SP_OBTENER_PERIODO_RESUMEN";
        //            cmd.Parameters.AddWithValue("@PERIODO", periodo);
        //            objReader = cmd.ExecuteReader();
        //            while (objReader.Read())
        //            {
        //                oLogProceso = new Persona()
        //                {
        //                    Codigo = Convert.ToInt32(objReader["CODIGO"]),
        //                };
        //            }
        //            objReader.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //    finally
        //    {
        //        objConnection.Close();
        //    }
        //    return oLogProceso;

        //}
    }
}