using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WSCampeonato.Dominio
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Usernanme { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int IdPersona { get; set; }
        [DataMember]
        public bool Estado { get; set; }
    }
}