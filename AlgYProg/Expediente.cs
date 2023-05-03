using System;

namespace AlgYProg	
{
	public class Expediente
	{
				/*ATRIBUTOS*/
		private int numero;
		private string titular;
		private string tipoTramite;
		private string estado;
		private DateTime fecha;
		private Abogado abogado;
		
				/*CONSTRUCTOR*/
		public Expediente(int numero, string titular, string tipoTramite, string estado, DateTime fecha, Abogado abogado)
		{
			this.numero = numero;
			this.titular = titular;
			this.tipoTramite = tipoTramite;
			this.estado = estado;
			this.fecha = fecha;
			this.abogado = abogado;
		}
		
				/*PROPIEDADES*/
		public int Numero
		{
			set{numero = value;}
			get{return numero;}
		}
		public string Titular
		{
			set{titular = value;}
			get{return titular;}
		}
		public string TipoTramite
		{
			set{tipoTramite = value;}
			get{return tipoTramite;}
		}		
		public string Estado
		{
			set{estado = value;}
			get{return estado;}
		}
		public DateTime Fecha
		{
			set{fecha = value;}
			get{return fecha;}
		}
		public Abogado getAbogado
		{
			set{abogado = value;}
			get{return abogado;}
		}
		public override string ToString(){return "Numero: "+ numero +", Titular: "+ titular+", Tipo de Tramite: "+tipoTramite+", Estado: "+ estado;}
	}
}