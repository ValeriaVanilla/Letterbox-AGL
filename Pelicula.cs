using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAlgoritmos
{
    class Pelicula {
        private int id;
        private string titulo;       
        private string director;
        private DateTime estreno;
        private Stack<Review> reviews;
        private string caratula;
        public Pelicula() {

        }

        public Pelicula(int id, string titulo, string director, DateTime estreno)
        {
            this.id = id;
            this.titulo = titulo;
            this.director = director;
            this.estreno = estreno;
        }

        public Pelicula(int id, string titulo, string director, DateTime estreno, string caratula)
        {
            this.id = id;
            this.titulo = titulo;
            this.director = director;
            this.estreno = estreno;
            this.caratula = caratula;
        }

        public Pelicula(int id, string titulo, string director, DateTime estreno, string caratula, Stack<Review> reviews) {
            this.id = id;
            this.titulo = titulo;
            this.director = director;
            this.estreno = estreno;
            this.caratula = caratula;
            this.reviews = reviews;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string GetDirector()
        {
            return director;
        }

        public void SetDirector(string director)
        {
            this.director = director;
        }

        public DateTime GetEstreno()
        {
            return estreno;
        }

        public void SetEstreno(DateTime estreno)
        {
            this.estreno = estreno;
        }

        public Stack<Review> GetReviews()
        {
            return reviews;
        }

        public void SetReviews(Stack<Review> reviews)
        {
            this.reviews = reviews;
        }

        public string GetCaratula()
        {
            return caratula;
        }

        public void SetCaratula(string caratula)
        {
            this.caratula = caratula;
        }

        override
            public string ToString()
        {
            return "Titulo: " + titulo + "\nDirector: " + director + "\nEstreno: " + estreno;        
        }

        public string VerReviews()
        {
            string aux = "";
            foreach(Review r in reviews)
            {
                aux += r.ToString() + "\n";
            }
            return aux;
        }

    }
}
