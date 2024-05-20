using System;

namespace sumadenumeros
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\n"Este programa es para sumar numeros\n");
            int uno, dos, resultado;

            Console.WriteLine("Ingrese el primer numero a sumar: \n");
            uno = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero a sumar: \n");
            dos = int.Parse(Console.ReadLine());

            resultado = uno + dos;

            Console.WriteLine("La suma de los numeros ingresados es:  \n" + resultado);








        }
    }
}

