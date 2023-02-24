using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
    
        {
        
            Licuadora licuadora = new Licuadora();
            licuadora.Luis();
            Console.WriteLine(" ");

            Console.WriteLine("Licuadora");
            Console.WriteLine("*********");
            licuadora.Marca = "Oester";
            Console.WriteLine("Marca: " + licuadora.Marca);
            licuadora.Color = "Gris";
            Console.WriteLine("Color: " + licuadora.Color);
            licuadora.Precio = 5000;
            Console.WriteLine("Precio: " + licuadora.Precio);
            Console.WriteLine(" ");
            licuadora.Encender();
            licuadora.Licuar();
            licuadora.Apagar();
            Console.WriteLine(" ");

            Tostadora tostadora = new Tostadora();

            Console.WriteLine("Tostadora");
            Console.WriteLine("**********");
            tostadora.Marca = "Philips";
            Console.Write("Marca: " + tostadora.Marca);
            tostadora.Precio = 3000;
            Console.WriteLine("Precio: " +  tostadora.Precio);
            tostadora.Color = "";
            Console.WriteLine("Color: " + tostadora.Color);
            Console.WriteLine(" ");
            tostadora.Encender();
            tostadora.Tostar();
            tostadora.Apagar();
            Console.WriteLine(" ");

            Nevera nevera = new Nevera();

            Console.WriteLine("Nevera");
            Console.WriteLine("**********");
            nevera.Marca = "Samsung";
            Console.Write("Marca: " + nevera.Marca);
            nevera.Precio = 5550;
            Console.WriteLine("Precio: " + nevera.Precio);
            nevera.Color = "";
            Console.WriteLine("Color: " + nevera.Color);
            Console.WriteLine(" ");
            nevera.Encender();
            nevera.Tostar();
            nevera.Apagar();
            Console.WriteLine(" ");

        }
    }
}
