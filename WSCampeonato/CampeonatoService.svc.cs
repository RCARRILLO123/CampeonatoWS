using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using WSCampeonato.Dominio;
using WSCampeonato.Errores;
using WSCampeonato.Persistencia;
namespace WSCampeonato
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "CampeonatoService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione CampeonatoService.svc o CampeonatoService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class CampeonatoService : ICampeonatoService
    {
        private UsuarioDAO Odao = new UsuarioDAO();
        private EquipoDAO OdaoEquipo = new EquipoDAO();
        private IntegranteDAO OdaoIntegrante = new IntegranteDAO();
        public Usuario GetUsuario(string username, string Password)
        {
            return Odao.GetUsuario(username, Password);
        }
        public bool RegistrarEquipo(Equipo oEquipo)
        {
            return OdaoEquipo.RegistrarEquipo(oEquipo);
        }
        public Integrante RegistrarIntegrante(Integrante oIntegrante)
        {
            return OdaoIntegrante.RegistrarIntegrante(oIntegrante);
        }
    }
}
