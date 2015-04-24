using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaNuevaLiga.Modelos
{
    public class Personajes
    {

        #region "Atributos"
        private abstract string nombre;
        private abstract string genero; 
        private abstract string identidad;
        private abstract string estatura;
        private abstract string contestura;

        
        #endregion

        #region "Propiedades"
        public string Nombres
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Identidad
        {
            get { return identidad; }
            set { identidad = value; }
        }

        public string Disfraz
        {
            get { return disfraz; }
            set { disfraz = value; }
        }


        public string Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }

        public string Contestura
        {
            get { return contestura; }
            set { contestura = value; }
        }
        #endregion

        public Personajes(string nombre, string genero, string identidad, string estatura, string contestura)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.identidad = identidad;
            this.estatura = estatura;
            this.contestura = contestura;
            

        }



        public override string ToString()
        {
            return "\nNombre: " + this.nombre+
                            "\nIdentidad: " + this.identidad+
                            "\nGenero: " + this.genero +
                            "\nestatura: " + this.estatura+
                            "\ncontestura: " + this.contestura +
                            
         
        }


        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}