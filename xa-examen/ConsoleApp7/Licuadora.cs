using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Licuadora
    {
        public string Marca { get; set; }
        public string Color { get; set; }
        private int precio;
        public int Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value > 4000)
                {
                    precio = 3500;
                }
                else
                {
                    precio = value;
                }
            }

        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo");
        }

        public void Licuar()
        {
            Console.WriteLine("Licuando");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando");
        }

        public void Luis()
        {
            Console.WriteLine("Nombre: Luis Lafaurie");
            Console.WriteLine("DNI: ");
            Console.WriteLine("Dirección: Murcia, Murcia");
        }


    }
}
