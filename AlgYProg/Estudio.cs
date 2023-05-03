using System.Collections;
using System;

namespace AlgYProg
{
	public class Estudio
	{
				/*ATRIBUTOS*/
		private string nombre;
		private ArrayList listaAbog;
		private ArrayList listaExpediente;
		
				/*CONSTRUCTOR*/
		public Estudio(string nombre)
		{
			listaExpediente = new ArrayList();
			listaAbog = new ArrayList();
		}
		
				/*PROPIEDADES*/
		public string Nombre 
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public ArrayList ListaExpediente
		{
			get{return listaExpediente;}
		}
		public ArrayList ListaAbog
		{
			get{return listaAbog;}
		}
		
		public void agregarAbog(Abogado abog1)
		{
			listaAbog.Add(abog1);
		}
		public void eliminarAbog(Abogado unAbog)
		{
			listaAbog.Remove(unAbog);
		}
		public ArrayList mostrarAbog()
		{
			return listaAbog;
		}		
		public void agregarExp(Expediente exp1)
		{
			listaExpediente.Add(exp1);
		}
		public ArrayList mostrarExp()
		{
			return listaExpediente;
		}
		public void eliminarExp(Expediente unExp)
		{
			listaExpediente.Remove(unExp);
		}
		public void reasignarEliminar(Estudio e1)
		{
			
		}
	}
}
