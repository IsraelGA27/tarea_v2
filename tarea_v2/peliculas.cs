using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_v2
{
    internal class Peliculas
    {
        private int _id;
        private string _genero;
        private string _franquicia;
        private string _titulo;
        private int v1;
        private string v2;
        private object p;

        public Peliculas(int v1, string v2, object p)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.p = p;
        }

        public Peliculas(int id, string genero, string franquicia, string titulo)
        {
            this._id = id;
            this._genero = genero;
            this._franquicia = franquicia;
            this._titulo = titulo;

        }
        public int id { get => _id; set => _id = value; }
        public string genero { get => _genero; set => _genero = value; }
        public string franquicia { get => _franquicia; set => _franquicia = value; }
        public string titulo { get => _titulo; set => _titulo = value; }

        public override string ToString()
        {
            return "ID: " + id + ", Genero: " + genero + ", Franquicia: " + ", Titulo: " + titulo;
        }
    }
}
