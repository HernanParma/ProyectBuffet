using System;

namespace AlgYProg
{

	public class Abogado
	{
				/*ATRIBUTOS*/
		private string nombre;
		private string apellido;
		private int dni;
		private string especialidad;
		private int cantExp;
		
				/*CONSTRUCTOR*/
		public Abogado(int dni, string apellido, string nombre, string especialidad)
		{
			this.apellido = apellido;
			this.nombre = nombre;
			this.dni = dni;
			this.especialidad = especialidad;
		}
		
				/*PROPIEDADES*/
		public string Nombre
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public string Apellido
		{
			set{apellido = value;}
			get{return apellido;}
		}
		public int DNI
		{
			set{dni = value;}
			get{return dni;}
		}
		public string Especialidad
		{
			set{especialidad = value;}
			get{return especialidad;}
		}
		public int CantExp
		{
			set{cantExp = value;}
			get{return cantExp;}
		}
	}
}