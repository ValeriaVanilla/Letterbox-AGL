using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAlgoritmos
{
    class Review
    {        
        private double calificacion;
        private string review;
        private string usuario;
        public Review(double calificacion, string review, string usuario) 
        {
            this.calificacion = calificacion;
            this.review = review;
            this.usuario = usuario;
        }

        public double GetCalificacion()
        {
            return calificacion;
        }

        public void SetCalificacion(double calificacion)
        {
            this.calificacion = calificacion;
        }

        public string GetReview()
        {
            return review;
        }

        public void SetReview(string review)
        {
            this.review = review;
        }

        public string GetUsuario()
        {
            return usuario;
        }

        public void SetUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        override
            public string ToString(){
            return usuario + "\nCalificación: " + "\nReseña:\n" + review;
            }

    }
}
