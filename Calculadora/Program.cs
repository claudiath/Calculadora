using System;

namespace CALCULADORA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            try
            {
                char opcion = '0'; string valorElegido = "";
                int n = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("***********************BIENVENIDO A LA CALCULADORA***********************" + "\n"
                   + "¿Desea realizar alguna operación? <S/N> \n");
                    valorElegido = Console.ReadLine();
                    if (valorElegido.ToUpper() == "S")
                    {
                        Console.WriteLine("Elija una operación: + - / * ");
                        opcion = Convert.ToChar(Console.ReadLine());
                        Peticion(opcion);
                        n++;
                        Console.ReadLine();
                        //propiedad para borrar en pantalla
                        Console.Clear();
                    }
                    else if (valorElegido.ToUpper() == "N")
                    {
                        Console.WriteLine("Pulse cualquier tecla para salir de la aplicación");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida.");
                        Console.Clear();
                        n++;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha fallado. Contacte con soporte. " + ex.Message);
                Console.ReadKey();

            }

        }
        public static void Peticion(char opcion)
        {
            decimal num1 = 0, num2 = 0, resultado = 0;
            switch (opcion)
            {
                case '+':
                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                    break;
                case '-':
                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                    break;
                case '*':
                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                    break;
                case '/':

                    Console.WriteLine("Escribe un número:");
                    num1 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Escribe otro número:");
                    num2 = Convert.ToDecimal(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new ArgumentException("Se ha intentado dividir entre 0");
                    }
                    resultado = num1 / num2;
                    Console.WriteLine("El resultado de la división es: " + resultado);
                    break;
                default:
                    Console.WriteLine("La opción elegida no es válida.");
                    break;
            }
        }

    }
}