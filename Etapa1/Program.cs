using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("ING y SIS", 2020, TiposEscuela.primaria, ciudad: "San Salvador"); 
            escuela.Ciudad="San Salvador";
            escuela.Pais="El Salvador";
            escuela.TiposEscuela = TiposEscuela.secundaria;
            System.Console.WriteLine(escuela);
        }
    }
}
