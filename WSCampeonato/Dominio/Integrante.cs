using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WSCampeonato.Dominio
{
	[DataContract]
	public class Integrante
    {
		[DataMember]
		public int Id { get; set; }
		[DataMember]
		public string Nombre { get; set; }
		[DataMember]
		public string Apellidos { get; set; }
		[DataMember]
		public string Sexo { get; set; }
		[DataMember]
		public string Correo { get; set; }
		[DataMember]
		public bool Estado { get; set; }
		
	}
}