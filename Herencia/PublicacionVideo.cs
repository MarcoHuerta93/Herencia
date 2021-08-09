using System;
using System.Threading;

namespace Herencia
{
    class PublicacionVideo : Publicacion
    {
        //variables
        protected bool seReproduce = false;
        protected int duracionActual = 0;

        Timer reloj;

        //Propiedades
        protected string UrlVideo { get; set; }

        protected int Duracion { get; set; }

        //Constructor por Defecto

        public PublicacionVideo() { }

        //Constructor parametrizado

        public PublicacionVideo(string titulo, string autor, string urlVideo, bool esPublico, int duracion)
        {
            this.ID = CrearID();
            this.Autor = autor;
            this.Titulo = titulo;
            this.UrlVideo = urlVideo;
            this.EsPublico = esPublico;
            this.Duracion = duracion;

        }

        public override string ToString()
        {
            return String.Format(" {0} - {1} - Creado por {2} - {3} - {4}", this.ID, this.Titulo, this.Autor
                , this.UrlVideo, this.Duracion);
        }


        public void Play()
        {
            Console.WriteLine("Reproduciendo");
            reloj = new Timer(Reproduccion, null, 0, 1000);
        }

        public void Stop()
        {

            Console.WriteLine("Detenido en {0}s", duracionActual);

        }

        private void Reproduccion(Object o)
        {
            if(duracionActual < Duracion)
            {
                duracionActual++;
                Console.WriteLine("Video en {0}s", duracionActual);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

    }
}
