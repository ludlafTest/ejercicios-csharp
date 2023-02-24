using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    internal class Tostadora
    {
        public string Marca { get; set; }

        public int Precio;

        private string color;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == "")
                {
                    color = "Dorado";
                }
                else
                {
                    color = value;
                }
            }

        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo");
        }

        public void Tostar()
        {
            Console.WriteLine("Tostando");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando");
        }


    }
}
