/*
 * Created by SharpDevelop.
 * User: ALUMNOS
 * Date: 06/10/2014
 * Time: 02:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace factura1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			
				 
			 int cantidad1,cantidad2,cantidad3,precio1,precio3;
			 String desc,desc2,desc3;
			 double precio2,iva=7.20;

			 // TODO: Implement Functionality Here

				 Console.Write("Press any key to continue . . . ");
			 Console.ReadKey(true);
			
				 Console.WriteLine("ingrese cantidad de procucto");
			
				 cantidad1=int.Parse (Console.ReadLine());
			 Console.WriteLine("ingrese descripcion del producto");
			 desc=Console.ReadLine();
			 Console.WriteLine("ingresa precio unitario");
			
				 precio1=int.Parse (Console.ReadLine());
			
				 Console.WriteLine("ingrese cantidad de procucto");
			
				 cantidad2=int.Parse (Console.ReadLine());
			 Console.WriteLine("ingrese descripcion del producto");
			 desc2=Console.ReadLine();
			 Console.WriteLine("ingresa precio unitario");
			
				 precio2=int.Parse (Console.ReadLine());
			 Console.WriteLine("ingrese cantidad de procucto");
			
				 cantidad3=int.Parse (Console.ReadLine());
			 Console.WriteLine("ingrese descripcion del producto");
			 desc3=Console.ReadLine();
			 Console.WriteLine("ingresa precio unitario");
			 precio3=int.Parse (Console.ReadLine());
			
				 double cuenta1,cuenta2,cuenta3;
			 cuenta1=cantidad1*precio1;
			 cuenta2=cantidad2*precio2;
			 cuenta3=cantidad3*precio3;
			double resultado = cuenta1+cuenta2+cuenta3;
				
			Console.WriteLine("el subtotal es"+(cuenta1+cuenta2+cuenta3));
			Console.WriteLine("iva"+iva);
			Console.WriteLine("el total es"+(cuenta1+cuenta2+cuenta3+iva));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
