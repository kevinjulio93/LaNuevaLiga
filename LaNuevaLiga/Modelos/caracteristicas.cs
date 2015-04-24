using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaNuevaLiga.Modelos
{
    public class caracteristicas
    {


        private abstract string disfraz;
        private abstract string emblema;
        private abstract string capa;
        private abstract string agilidad;
        



        public string Capa
        {
            get { return capa; }
            set { capa = value; }
        }
        public string Agilidad
        
        {
            get { return agilidad; }
            set { agilidad = value; }
        }
        public string Disfraz1
        {
            get { return disfraz; }
            set { disfraz = value; }
        }
        public string Emblema
        {
            get { return emblema; }
            set { emblema = value; }
        }




        public caracteristicas(string disfraz, string emblema, string capa, string agilidad)
        {
            this.disfraz = disfraz;
            this.emblema = emblema;
            this.capa = capa;
            this.agilidad = agilidad;
            

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