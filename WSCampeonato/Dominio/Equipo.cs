using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WSCampeonato.Dominio
{
    [DataContract]
    public class Equipo
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Modalidad { get; set; }
        [DataMember]
        public bool Estado { get; set; }
  }
    
}