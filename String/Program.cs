﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escribe tu ciudad: ");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " Bienvenido a " + ciudad);
            Console.WriteLine("Presione cualquier tecla para finalizar "); 
            Console.ReadKey();

        }
    }
}
