using System; // System: son directivas que permite utilizar funcionalidades que vienen por defecto en el programa, por ej. Clase Console

namespace Calculadora // espacio de nombres definido como nuestro proyecto
{
    class Program  // clase principal del proyecto

    {

               
        static void Main(string[] args) // método principal que viene por defecto para ejecutar el código
        {

        // declarar variable Peticion para pedir los números al usuario
        public static void Peticion(char opcion);
        decimal num1 = 0, num2 = 0, resultado = 0;

            // utilizando atributos de la clase Console
            Console.BackgroundColor = ConsoleColor.White; // fondo del texto
            Console.ForegroundColor = ConsoleColor.Black; // color del texto
                                                          // utilizando métodos de la clase Console
                                                          // Console.WriteLine("Hello World!"); // línea de código que se muestra en pantalla al ejecutar la aplicación

            //Program prog = new Program(); //llamada a la clase Program (instanciar)

            // declarar variables
            //int num1 = 0, num2 = 0, resultado = 0;

            try
            {
                char opcion = '0'; string valorElegido = "";
                int n = 1;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Bienvenido a la calculadora" + "\n"
         + "Desea realizar alguna operación? <S/N> \n"); // \n indica un salto de línea
                    valorElegido = Console.ReadLine();
                    if (valorElegido.ToUpper() == "S")
                    {
                        // interactuar con el usuario
                        Console.WriteLine("Elija una operación: + - * /");
                        opcion = Convert.ToChar(Console.ReadLine());

                        // utilizando condicional switch case
                        switch (opcion)
                        {
                            case '+':
                                //prog.Peticion(num1, num2);
                                Console.WriteLine("Escribe un número");
                                num1 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Escribe otro número");
                                num2 = Convert.ToDecimal(Console.ReadLine());
                                resultado = num1 + num2;
                                Console.WriteLine("El resultado de la suma es: " + resultado);
                                break;
                            case '-':
                                //prog.Peticion(num1, num2);
                                Console.WriteLine("Escribe un número");
                                num1 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Escribe otro número");
                                num2 = Convert.ToDecimal(Console.ReadLine());
                                resultado = num1 - num2;
                                Console.WriteLine("El resultado de la resta es: " + resultado);
                                break;
                            case '*':
                                //prog.Peticion(num1, num2);
                                Console.WriteLine("Escribe un número");
                                num1 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Escribe otro número");
                                num2 = Convert.ToDecimal(Console.ReadLine());
                                resultado = num1 * num2;
                                Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                                break;
                            case '/':
                                //prog.Peticion(num1, num2);
                                Console.WriteLine("Escribe un número");
                                num1 = Convert.ToDecimal(Console.ReadLine());
                                Console.WriteLine("Escribe otro número");
                                num2 = Convert.ToDecimal(Console.ReadLine());
                                if (num2 == 0) ;
                                {
                                    // se provoca una excepción para que vaya directamente al catch y capture el error del argumento
                                    throw new ArgumentException ("Se ha intentado dividir entre 0");
                                }
                                resultado = num1 / num2;
                                Console.WriteLine("El resultado de la división es: " + resultado);
                                break;
                            default:
                                Console.WriteLine("La opción elegida no es válida");
                                break;
                        }
                        n++;
                        Console.ReadLine();

                        // propiedad para borrar en pantalla
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
                        Console.ReadLine();
                        n++;

                        // propiedad para borrar en pantalla
                        Console.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("La aplicación ha fallado, contacte con soporte"+ ex.Message);
                Console.ReadKey();
            }
        }

        // utilizando condicional if else if else
        //if (opcion== '+')
        //{
        //    resultado = num1 + num2;
        //    Console.WriteLine("El resultado de la suma es: " + resultado);
        //}
        //else if (opcion== '-')
        //{
        //    resultado = num1 - num2;
        //    Console.WriteLine("El resultado de la resta es: " + resultado);
        //}
        //else if (opcion== '*')
        //{
        //    resultado = num1 * num2;
        //    Console.WriteLine("El resultado de la multiplicación es: " + resultado);
        //}
        //else if (opcion== '/')
        //{
        //    resultado = num1 / num2;
        //    Console.WriteLine("El resultado de la división es: " + resultado);
        //}
        //else
        //{
        //    Console.WriteLine("La opción elegida no es válida");
        //}

        // utilizando bucle "for"
        //for (int i = 0; i < 2; i++)
        //{
        //    Console.WriteLine("Vuelta número:" + i);
        //}

        //Console.ReadLine(); // paramos el código con el Intro, también sirve para recoger los valores que introduce el usuario
        // Console.ReadKey(); // paramos el código con cualquier tecla

    }
}
