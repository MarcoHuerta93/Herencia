using System;

namespace Herencia
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Primer Objeto
            Publicacion post1 = new Publicacion("Gracias por los saludos", true, "Antonio Huerta");
            Console.WriteLine(post1.ToString());

            PublicacionImagen imagen1 = new PublicacionImagen("Mira el nuevo perro", "Marco Huerta", "https://imagen.com/perro,", true);
            Console.WriteLine(imagen1.ToString());

            PublicacionVideo video1 = new PublicacionVideo("Ufc highlights", "Marco Huerta", "https://ufctv.com/mexico", true, 23);
            Console.WriteLine(video1.ToString());
            video1.Play();
            Console.WriteLine("Presione cualquier tecla para detener");
            Console.ReadKey();
            video1.Stop();
            Console.Read();
        }
    }
}
