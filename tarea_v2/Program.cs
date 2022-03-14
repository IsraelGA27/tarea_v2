// See https://aka.ms/new-console-template for more information
// Console.WriteLine("TAREA 2");
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_v2
{
    class Program
    {
        static void Main(String[] args)
        {
            Estanteria peliculas = new Estanteria(10);

            Peliculas c1 = new Peliculas(1, "Terror ", "VIERNES TRECE ", "VIERNES TRECE 5 ");
            Peliculas c2 = new Peliculas(2, "Ciencia Ficcion ", "STAR WARS ", "EL RETORNO DEL JEDAI ");
            Peliculas c3 = new Peliculas(3, "Fantasia ","HARRY POTTER ", "HARRY POTTER Y LA PIEDRA FILOSOFAL ");
            Peliculas c4 = new Peliculas(4, "Terror ", "VIERNES TRECE ", "VIERNES TRECE");
            Peliculas c5 = new Peliculas(5, "Terror ", "VIERNES TRECE ", "VIERNES TRECE 2 ");

            peliculas.anadirPelicula(c1);
            peliculas.anadirPelicula(c2);
            peliculas.anadirPelicula(c3);
            peliculas.anadirPelicula(c4);
            peliculas.anadirPelicula(c5);

            Console.WriteLine("Mostramos las Peliculas: ");
            peliculas.mostrarPelicula();


            //peliculas.eliminarPeliculas(c3);

            //Console.WriteLine("Eliminar una pelicula");
            //peliculas.mostrarPelicula();

            //Console.WriteLine("Vacio");
            //peliculas.vaciarPeliculas();

            //peliculas.mostrarPelicula();
            Console.ReadLine();



        }
    }
}
