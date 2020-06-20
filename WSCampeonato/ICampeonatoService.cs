using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WSCampeonato.Dominio;
using WSCampeonato.Errores;

namespace WSCampeonato
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICampeonatoService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICampeonatoService
    {
        [FaultContract(typeof(ErroresExcepciones))]
        [OperationContract]
        Usuario GetUsuario(string username, string Password);
        [OperationContract]
        bool RegistrarEquipo(Equipo oEquipo);
        [OperationContract]
        Integrante RegistrarIntegrante(Integrante oIntegrante);
        //void DoWork();
    }
}
