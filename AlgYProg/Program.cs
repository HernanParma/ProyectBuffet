using System;
using System.Collections;

namespace AlgYProg
{
	class Program
	{
		public class otroAbog:Exception{}
		public static void Main(string[] args)
		{
			Estudio estudio1 = new Estudio("estudio1");			/*CREAMOS EL ESTUDIO*/
			bool continuar=true;
			int opcion;
			while (continuar){
				mostrarMenu();			/*LLAMAMOS METODO PARA IMPRIMIR MENU*/
				while (true){                           //ciclo while para el control de errores

					try{opcion = int.Parse(Console.ReadLine());
						break;}
					catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
					}
				switch (opcion){		/*BUCLE PARA DIRIGIR LA OPCION CORRECTA*/
					case 1 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 1 - Agregar Abogado");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						agregarAbog(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 2 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 2 - Eliminar Abogado");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						eliminarAbogado(estudio1);
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 3 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 3 - Listado de Abogados");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						mostrarAbog(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 4 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 4 - Agregar nuevo Expediente");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						agregarExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 5 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 5 - Listado de Expedientes");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						mostrarExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 6 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 6 - Modificar Expediente");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						modificarEstadoExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 7 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 7 - Eliminar Expediente");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						eliminarExpediente(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 8 :
						Console.Clear();
						Console.WriteLine("------------------------------------");
						Console.WriteLine(" 8 - Listado Expedientes/Audiencia");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("");
						listadoExpedientePorMes(estudio1);
						Console.WriteLine("");
						Console.WriteLine("------------------------------------");
						Console.WriteLine("Presione ENTER para volver a menú");
						Console.ReadKey();
						Console.Clear();
						break;
					case 0 :
						continuar = false;		/*CAMBIAMOS LA VARIABLE PARA SALIR DEL BUCLE*/
						break;
					default:				/*EN CASO DE NO SER OPCION VALIDA*/
						Console.WriteLine("Opción incorrecta");
						Console.ReadKey();
						Console.Clear();
						break;
				}
			}
		}
		public static void mostrarMenu()		/*METODO QUE IMPRIME MENU*/
		{
			Console.WriteLine("------------------------------------");
			Console.WriteLine(" Menu ");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("");
			Console.WriteLine(" 1 - Agregar Abogado");
			Console.WriteLine(" 2 - Eliminar Abogado");
			Console.WriteLine(" 3 - Listado de Abogados");
			Console.WriteLine(" 4 - Agregar nuevo Expediente");
			Console.WriteLine(" 5 - Listado de Expedientes");
			Console.WriteLine(" 6 - Modificar Expediente");
			Console.WriteLine(" 7 - Eliminar Expediente");
			Console.WriteLine(" 8 - Listado Expedientes/Audiencia");
			Console.WriteLine("");
			Console.WriteLine(" 0 - Salir");
			Console.WriteLine("------------------------------------");
			Console.WriteLine("Ingrese una opcion: ");
		}
		
		public static void agregarAbog(Estudio e1)		/*METODO PARA AGREGAR ABOGADO, PASAMOS POR PARAMETRO EL ESTUDIO*/
		{
			if(e1.ListaAbog.Count < 5){
				int dni;
				while (true){                           //ciclo while para el control de errores
					Console.WriteLine(" Ingrese DNI de abogado: ");
					try{dni = int.Parse(Console.ReadLine());
						break;}
					catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
					}                                   //termina el ciclo while para el control de errores
				bool saber = false;
				foreach(Abogado abgd in e1.ListaAbog){
					if (abgd.DNI == dni){
						saber = true;
						break;}
						}
						if (saber == false){
							Console.WriteLine("Ingrese Nombre de abogado: ");
							string nombre = Console.ReadLine();
							Console.WriteLine("Ingrese Apellido de abogado: ");		
							string apellido = Console.ReadLine();
							Console.WriteLine("Ingrese Especialidad de abogado: ");
							string especialidad = Console.ReadLine();
							Abogado abog1 = new Abogado(dni, apellido, nombre, especialidad);
							e1.agregarAbog(abog1);}
						else{Console.WriteLine(" DNI de abogado ya existe.");}
			}
			else{Console.WriteLine(" Cupo de abogados completo");}
		}
		
		public static void eliminarAbogado(Estudio e1){
			if (e1.ListaAbog.Count!=0){
				int dni;
					while (true){                           //ciclo while para el control de errores
					Console.Write("Ingrese el DNI del abogado a eliminar: ");
					try{dni = int.Parse(Console.ReadLine());
						break;}
					catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
					}                                   //termina el ciclo while para el control de errores
				bool bandera=false;
				foreach(Abogado aboga in e1.ListaAbog){
					if(aboga.DNI == dni){
						bandera=true;
						if(aboga.CantExp!=0){
							reasignarEliminar(aboga, e1, dni);
							break;}
						else{e1.eliminarAbog(aboga);
							Console.WriteLine(" Abogado eliminado con éxito");
							break;}
										}					
													  }
				if (bandera==false)
					Console.WriteLine(" No existe el abogado con ese DNI.");
   		    }
			else{Console.WriteLine(" No hay abogados asignados en el estudio.");}
		}
		
		public static void mostrarAbog(Estudio e1){
			if(e1.ListaAbog.Count!=0){
				foreach(Abogado elem in e1.ListaAbog){
					Console.WriteLine("DNI: {0}, Nombre: {1}, Apellido: {2}, Especialidad: {3}, Cant. Expedientes: {4}", elem.DNI, elem.Apellido, elem.Nombre, elem.Especialidad, elem.CantExp);
				}
			}
			else{Console.WriteLine(" No hay abogados asignados en el estudio.");}
		}
		
		public static void agregarExpediente(Estudio e1){
			if(e1.ListaAbog.Count!=0){
				int numExp;
				while (true){
					Console.Write(" Ingrese el número del expediente: ");
								try{numExp = int.Parse(Console.ReadLine());
								break;}
								catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
								}
						bool saber = false;
						foreach(Expediente e in e1.ListaExpediente){
							if (e.Numero == numExp){
								saber = true;
								break;}
							}
						if (saber == false){
							Console.Write("Ingrese nombre del titular del expediente: ");
							string titular = Console.ReadLine();
							Console.Write("Ingrese tipo de trámite del expediente: ");
							string tramite = Console.ReadLine();
							Console.Write("Ingrese estado del expediente: ");
							string estado = Console.ReadLine();
							Console.WriteLine("Ingrese fecha solo con números");
							Console.WriteLine("Año:");
							int año,mes,dia;
							while (true){                           //ciclo while para el control de errores
								Console.WriteLine(" Ingrese año: ");
								try{año = int.Parse(Console.ReadLine());
									break;}
								catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
								}
							while (true){
								Console.WriteLine("Ingrese mes:");
								try{mes = int.Parse(Console.ReadLine());
								break;}
								catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
								}
							while (true){
								Console.WriteLine("Día:");
								try{dia = int.Parse(Console.ReadLine());
								break;}
								catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
								}
							DateTime fecha = new DateTime(año, mes, dia);
							while(true){int dni;
								try{
									while (true){Console.Write("Ingrese el DNI del abogado a asignar expediente: ");
										try{dni = int.Parse(Console.ReadLine());
										break;}
										catch (FormatException){Console.WriteLine("Ingrese sólo números.");}
										}									
									bool agregar = false;
									foreach(Abogado elem in e1.ListaAbog){
										if(elem.DNI == dni && elem.CantExp < 6){
											agregar = true;
											Expediente exp = new Expediente(numExp, titular, tramite, estado, fecha, elem);
											e1.agregarExp(exp);
											elem.CantExp = elem.CantExp + 1;}
															}
									if(agregar){Console.WriteLine("Abogado agregado con éxito");}
									else{throw new otroAbog();}
									break;}
								catch(otroAbog){
									Console.WriteLine("Opcion no disponible.");
									Console.WriteLine("\nSeleccione otro abogado.\nDISPONIBLES:");
									int contador = 0;
									foreach(Abogado elem in e1.ListaAbog){
										if(elem.CantExp < 6){
											Console.WriteLine((contador+1)+"----DNI del abogado:{0}", elem.DNI);
											contador++;}
																		}
									if(contador == 0){
										Console.WriteLine("No hay abogados disponibles");
										break;}
												}
									}
							}
							else {Console.WriteLine("El numero de expediente ya existe. \n");}
						}
						else{Console.WriteLine("no hay abogados disponibles, primero ingrese al menos 1 abogado.");}
					}
		
		public static void modificarEstadoExpediente(Estudio e1){
			if(e1.ListaExpediente.Count!=0){
				Console.Write("Ingrese el número de expediente que desea modificar: ");
				int num = int.Parse(Console.ReadLine());
				foreach (Expediente exp in e1.ListaExpediente){
					if(exp.Numero == num){
						Console.WriteLine("El estado actual del expediente NRO {0} es: {1} \n", num, exp.Estado);
						Console.Write("Ingrese el nuevo estado del expediente: ");
						string nuevoEstado = Console.ReadLine();
						exp.Estado = nuevoEstado;
						Console.WriteLine("\r\n Se modificó el expediente correctamente\n");
						break;}
				}
			}
			else{Console.WriteLine("No hay expedientes en el estudio.");}
		}
		
		public static void mostrarExpediente(Estudio e1){
			if (e1.ListaExpediente.Count!=0){
				foreach(Expediente elem in e1.ListaExpediente){
					Console.WriteLine("N° expediente: {0}, Titular: {1}, Tipo: {2}, Estado: {3}, Fecha: {4}, \n Abogado; DNI: {5}, Apellido: {6}, Nombre: {7}", elem.Numero, elem.Titular, elem.TipoTramite, elem.Estado, elem.Fecha, elem.getAbogado.DNI, elem.getAbogado.Apellido, elem.getAbogado.Nombre);
					Console.WriteLine("-------------------------------------------------------------------------");
				}
			}
			else{Console.WriteLine("No hay expedientes en el estudio.");}
		}
		
		public static void eliminarExpediente(Estudio e1){
			if (e1.ListaExpediente.Count!=0){
				int numeroExp;
				Console.WriteLine("Ingrese numero de expediente a eliminar.");
				numeroExp=int.Parse(Console.ReadLine());
				foreach(Expediente exp in e1.ListaExpediente){
					if(numeroExp==exp.Numero){
						Abogado a = exp.getAbogado;
						a.CantExp--;
						e1.eliminarExp(exp);
						Console.WriteLine("¡El expediente se eliminó con exito!");
						break;}
				}
			}
			else{Console.WriteLine("No hay expedientes en el estudio.");}
		}
		
		public static void listadoExpedientePorMes(Estudio e1){
			if (e1.ListaExpediente.Count!=0){
				int mes = 0;
				while(true){
					try{Console.Write("Ingrese un mes a buscar (1 al 12): ");
						mes = int.Parse(Console.ReadLine());
						break;}
					catch (FormatException){Console.WriteLine("Ingrese un mes válido (1 al 12)");}
					}
				Console.WriteLine("");
				bool hay = false;
				foreach (Expediente exp in e1.ListaExpediente){
					if (exp.Fecha.Month == mes && exp.TipoTramite == "audiencia"){
						Console.WriteLine("N° expediente: {0}, Titular: {1}, Tipo: {2}, Estado: {3}, Fecha: {4}, \nAbogado; DNI: {5}, Apellido: {6}, Nombre: {7}", exp.Numero, exp.Titular, exp.TipoTramite, exp.Estado, exp.Fecha, exp.getAbogado.DNI, exp.getAbogado.Apellido, exp.getAbogado.Nombre);
						Console.WriteLine("------------------------------------------------------------------------");
						hay = true;}
				}
				if(!hay){Console.WriteLine("No hay expediente de tipo 'audiencia' en el mes ingresado.");}
			}
			else{Console.WriteLine("No hay expedientes en el estudio.");}
		}
		
		public static void reasignarEliminar(Abogado elem,Estudio e1, int dni){
			ArrayList auxExp=new ArrayList();//CREO ARRAY PARA GUARDAR TODOS LOS EXPEDIENTE A CARGO DEL ABOGADO A ELIMINAR PARA LUEGO REASIGNARLOS.
			bool banderaEliminar=false;
			Console.WriteLine("El abogado "+elem.Apellido+" tiene a su cargo "+elem.CantExp+" expedientes.");
			foreach(Expediente e in e1.ListaExpediente){
				if (e.getAbogado.DNI==dni){
					Console.WriteLine(e);
					auxExp.Add(e);}      }
			Console.WriteLine("¿Desea eliminar (e), los expedientes a cargo o reasignarlos (r), a otro abogado?");
			string condicion=Console.ReadLine();
			if(condicion=="e"){
				int cant=6;
				while(cant!=0){
					foreach(Expediente ep in e1.ListaExpediente){
						if (ep.getAbogado.DNI==dni){
							e1.eliminarExp(ep);
							break;}
						}
					cant--;}
				e1.eliminarAbog(elem);
				Console.WriteLine("El abogado y sus expedientes se eliminaron con exito");
			}
			else{int i=1;
				Console.WriteLine("Abogados disponibles: ");
				foreach(Abogado abo in e1.ListaAbog){
					int comp=6-abo.CantExp;
					if(abo.CantExp < 6 && elem.CantExp<=comp){
						Console.WriteLine(i+"----DNI: "+abo.DNI+" Apellido: "+ abo.Apellido);
						i++;}
				}if(i==1) Console.WriteLine("No hay abogados disponibles para asignar dichos expedientes. Si desea realizar la asignacion primero agregue nuevo abogado.");
				else{
				Console.WriteLine("\nIngrese DNI del abogado elegido: ");
				int opcion=int.Parse(Console.ReadLine());
				foreach(Abogado aboga in e1.ListaAbog){
					if(aboga.DNI == opcion){
						int cant=6;
						while(cant!=0){	
							foreach(Expediente ep in e1.ListaExpediente){
								if(ep.getAbogado.DNI==dni){
									e1.eliminarExp(ep);
									ep.getAbogado=aboga;
									e1.agregarExp(ep);
									aboga.CantExp +=1;
									banderaEliminar=true;
									break;}
							}
							cant--;
					   }
					}
					}
				}
				if(banderaEliminar==true){
				e1.eliminarAbog(elem);
				Console.WriteLine("Abogado eliminado y expediente reasignado.");}
				}
			}
		
		
		
	}
}