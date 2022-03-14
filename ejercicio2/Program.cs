// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercico2
{

    class Program
    {
        static void Main(string[] args)
        {
            
            int PrecioRopa = 100; 
            int PrecioLicuadora = 900; 
            int PrecioLavadora = 10000; 
            int PrecioMicrondas = 1500; 
            int PrecioComedor = 5600; 

            int sum = 0; 
            int cant = 0; 
            int importe = 0; 
            int importe1 = 0; 
            int importe2 = 0; 
            int importe3 = 0; 
            int importe4 = 0;
            int vamoCalmarno;
            int vamoCalmarno2;
            int vamoCalmarno3;
            int vamoCalmarno4;
            int vamoCalmarno5;


            Console.WriteLine("\tABARROTES MARÍA ");
            Console.WriteLine("\tVentas");

            // Primer Articulo
            Console.WriteLine("\n\nArticulo 1");
            Console.WriteLine("\nRopa:  ");
            Console.WriteLine("Precio Ropa: 100 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            importe = cant * PrecioRopa;
            Console.WriteLine("Importe : {0}", importe);


            // Segundo Articulo
            Console.WriteLine("\n\nArticulo 2");
            Console.WriteLine("\nLicuadora:  ");
            Console.WriteLine("Precio Licuadora: 900 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            importe1 = cant * PrecioLicuadora;
            Console.WriteLine("Importe : {0}", importe1);


            // Tercer Articulo
            Console.WriteLine("\n\nArticulo 3");
            Console.WriteLine("\nLavadora:  ");
            Console.WriteLine("Precio Lavadora: 10000 ");

            Console.WriteLine("Cantidad :  ");
            cant = Int32.Parse(Console.ReadLine());

            importe2 = cant * PrecioLavadora;
            Console.WriteLine("Importe : {0}", importe2);


            // Cuarto Articulo 
            Console.WriteLine("\n\nArticulo 4");
            Console.WriteLine("\nMicrondas:  ");
            Console.WriteLine("Precio Microndas: 1500 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            importe3 = cant * PrecioMicrondas;
            Console.WriteLine("Importe : {0}", importe3);


            // Quinto Articulo
            Console.WriteLine("\n\nArticulo 5");
            Console.WriteLine("\nComedor:  ");
          
            Console.WriteLine("Precio Comedor: 5600 ");

            Console.WriteLine("Cantidad:  ");
            cant = Int32.Parse(Console.ReadLine());

            importe4 = cant * PrecioComedor;
            Console.WriteLine("Importe : {0}", importe4);

            // Ventas totales, basadas en los importes 
            sum = importe + importe1 + importe2 + importe3 + importe4;

            // VamoCalmarno almacena el importe de X articulo y lo divida entre su precio para obtener la cantidad que se ah vendido.
            vamoCalmarno = (importe  / PrecioRopa);
            vamoCalmarno2 = (importe1 / PrecioLicuadora);
            vamoCalmarno3 = (importe2 / PrecioLavadora);
            vamoCalmarno4 = (importe3 / PrecioMicrondas);
            vamoCalmarno5 = (importe4 / PrecioComedor);

            Console.WriteLine("\n\n\tEl Total de ganacias fue de: {0}", sum);
            Console.WriteLine("\n\n\tCantidad de Ropa Vendida: {0}", vamoCalmarno);
            Console.WriteLine("\n\n\tCantidad de Licuadoras Vendidas: {0}", vamoCalmarno2);
            Console.WriteLine("\n\n\tCantidad de Lavadoras Vendidas: {0}", vamoCalmarno3);
            Console.WriteLine("\n\n\tCantidad de Microndas Vendidos: {0}", vamoCalmarno4);
            Console.WriteLine("\n\n\tCantidad de Comedores vendidos: {0}", vamoCalmarno5);
            // Console.WriteLine("Variable cant ", cant); -- Esperaba que se almacenaran, pero al final se reinicia por el ciclo que lleva
            Console.ReadKey();
        }
    }
}
