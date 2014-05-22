/*
 * Creado por SharpDevelop.
 * Usuario: Choco
 * Fecha: 05/05/2014
 * Hora: 10:23 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using MySql.Data.MySqlClient;

namespace Practica6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opc=3;
			
				Console.WriteLine(" \tMENU\n");
			    Console.WriteLine(" 1) Agregar\n");
			    Console.WriteLine(" 2) Editar\n");
			    Console.WriteLine(" 3) Eliminar\n");
			    
			    opc= int.Parse(Console.ReadLine());
			Profesores maestro = new  Profesores();
			 
			    switch( opc)
			    {
			    
			    case 1 :
			    	Console.WriteLine(" AGREGAR\n");
			    Console.WriteLine("Dame el Codigo");
			    String codigo=Console.ReadLine();
			    Console.WriteLine("Dame el Nombre");
			    String nombre=Console.ReadLine();
			    maestro.insertarRegistroNuevo(codigo, nombre);
			     break;
			     
			    case 2 :
			     Console.WriteLine(" EDITAR\n");
			    	 Console.WriteLine("Dame el ID del registro");
			    	 string id= Console.ReadLine();
			    	 
			    	 if(maestro.Buscarid(id)){
			    	 	
			                Console.WriteLine(" Codigo");
			                Console.WriteLine(" Nombre");
			                Console.WriteLine("si desea editarlo presione 'S'");
			                string si=Console.ReadLine();
			                if(si == "s"){
			    	
			                    Console.WriteLine("Dame el Codigo");
			                    codigo=Console.ReadLine();
			                    Console.WriteLine("Dame el Nombre");
			                    nombre=Console.ReadLine();
			                    maestro.editarNombreCodigo(id, nombre,codigo);
			     
			      }
			    
			    }
			    
			    break;
			    
			   case 3 :
			    Console.WriteLine(" ELIMINAR\n");
			       Console.WriteLine("Dame el ID de Regisstro");
			       id = Console.ReadLine();
			       if(maestro.Buscarid(id)){
			       	codigo=Console.ReadLine();
			       	nombre=Console.ReadLine();
			       	
			       	 Console.WriteLine("si desea eliminarlo presione 'S'");
			                string si=Console.ReadLine();
			                if(si == "s")
			                	maestro.eliminarRegistroPorId(id);
			       }
			       else{
								Console.WriteLine( "El id no existe presione cualquier tecla para continuar " );
      							 Console.ReadLine();
      							
							}
			       break;
			  
			}
			    Console.WriteLine( "\t***Presione cualquier tecla para continuar*** " );
      			Console.ReadLine();
      			System.Console.Clear();
			}
			  
		}
	}
