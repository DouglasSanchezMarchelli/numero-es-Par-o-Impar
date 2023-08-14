using System;

namespace NumeroParImpar
{
    class Program
    {
        static void Main(string[] args)
{
Console.WriteLine("Determinar si un numero es Par o Impar");

Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine());

 if (numero % 2 == 0)
 {
 Console.WriteLine($"El número {numero} es par.");
 }
 else
 {
 Console.WriteLine($"El número {numero} es impar.");
   }
  }
 }
}