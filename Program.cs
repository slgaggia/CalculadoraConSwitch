using System;
using System.Runtime.CompilerServices;

namespace CalculadoraConSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            
            // Mostramos el menú
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - División");
            Console.WriteLine("4 - Multiplicación");
            Console.Write("Que operación deseas realizar:");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            
            // Pedimos el primer número
            Console.Write("Dame el primer numero:");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
            
            // Pedimos el segundo número
            Console.Write("Dame el segundo numero:");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);
            
            switch (opcion)
            {
                // Verificamos para suma
                case 1:
                    resultado = a + b;
                    break;
                // Verificamos para resta
                case 2:
                    resultado = a - b;
                    break;
                // Verificamos para división
                case 3:
                    if (b != 0) // este if esta anidado
                        resultado = a / b;
                    else // Este else pertenece al segundo if
                        Console.WriteLine("Divisor no valido");
                    break;
                // Verificamos para la multiplicación
                case 4:
                    resultado = a * b;
                    break;
                    // Si no se cumple ninguno de los casos anteriores
               default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
           
            // Mostramos el resultado
           Console.WriteLine($"El resultado es: {resultado}");
        }
    }
}
