using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_v2
{
    internal class Estanteria
    {
        private Peliculas[] _pelis;
        private int _limite;

        private int _numPelis;

        public Estanteria(int limite)
        {
            this._pelis = new Peliculas[limite];
            _limite = limite; 
            _numPelis = 0; // Valores en el constructor (por paradigma)
        }

        public void anadirPelicula(Peliculas c)
        {
            if (c != null && _numPelis < _pelis.Length)
            {
                _pelis[_numPelis] = c;
                _numPelis++;
            }
        }
        // Mostrar 'info' de las peliculas (para especificar )
        public void mostrarPelicula()
        {
            for (int i=0; i < _numPelis; i++)
            {
                Console.WriteLine(_pelis[i].ToString());
            }
        }
        public void vaciarPeliculas()
        {
            this._pelis = new Peliculas[_limite];
            _numPelis = 0;
        }
        public void eliminarPeliculas(Peliculas c)
        {
            if (c!= null && _numPelis != 0)
            {
                int posicion = -1;
                for (int i = 0; i < _numPelis; i++)
                {
                    if(c.id == _pelis[i].id)
                    {
                        posicion = i;
                    }
                }
                if (posicion == -1)
                {
                    Console.WriteLine("No Existe la pelicula");
                }
                else
                {
                    _pelis[posicion] = null;

                    for (int i = posicion; i < _numPelis; i++)
                    {
                        _pelis[i] = _pelis[i + 1];
                    }

                    _numPelis--;
                }
            }
        }
    }
}
