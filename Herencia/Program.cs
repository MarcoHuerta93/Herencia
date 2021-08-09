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
            Console.Read();
        }
    }
}
