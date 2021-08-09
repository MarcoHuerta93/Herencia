using System;
namespace Herencia
{
    class Publicacion
    {
        private static int publicacionID;


        //Propiedades

        protected int ID { get; set; }

        protected string Titulo { get; set; }

        protected string Autor { get; set; }

        protected bool EsPublico { get; set; }

        //Constructor por defecto

        public Publicacion()
        {
            ID = 0;
            Titulo = "Mi primera publicación";
            EsPublico = true;
            Autor = "Marco Huerta";
        }


    }
}
