using System;

namespace calculadora_fs
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////
            //  CALCULADORA
            ////////////////// 

            try        // Dentro de las llaves del try van las instrucciones que pueden producir errores
            {
                // Variables

                char simbolo;
                string valor_elegido;


                // Desarrollo

                int contador = 1;  // Esta variable será usada para la vuelta del bucle for

                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("*      CALCULADORA FS        *");
                    Console.WriteLine("******************************");
                    Console.WriteLine();

                    Console.WriteLine("¿Desea realizar alguna operación? <S/N>  \n"); // Indica salto de linea --> \n
                    valor_elegido = Console.ReadLine();

                    if (valor_elegido.ToUpper() == "S")  // .ToUpper ==> Para que distinga de mayúsculas a minúsculas y al revés, creo.
                    {
                        Console.WriteLine("Ingresa el signo de la operación a realizar + - / * ");
                        simbolo = Convert.ToChar(Console.ReadLine());

                        Peticion(simbolo);  // Llamamos a la función creada
                        contador++;
                        Console.ReadLine();
                        Console.Clear();        // Propiedad para limpiar la pantalla
                    }
                    else if (valor_elegido.ToUpper() == "N")
                    {
                        Console.WriteLine("Presiona cualquier tecla para salir de la aplicación");
                        Console.ReadKey();  // Para salir de la app con cualquier tecla
                    }
                    else
                    {
                        Console.WriteLine("La opción elegida no es válida. Presione INTRO para volver a seleccionar.");
                        contador++;
                        Console.ReadLine();
                        Console.Clear();        // Propiedad para limpiar la pantalla
                    }
                }

            }
            catch (Exception var_ex)   // Se utiliza para definir un controlador de excepciones 
            {
                Console.WriteLine("La aplicación ha fallado, contacte con Rentasoft.  " + var_ex.Message);
                Console.ReadKey();
            }

        }



        /* - Se declara esta nueva FUNCIÓN para pedir los números al usario. 
           - Esta función la creamos para no reutilizar el mismo código varias veces
           - El void no retorna nada, de forma que no se pone ningún return
           - Las variables declaradas en la otra función se declaran aquí también
           - Es Static porque lo vamos a usar dentro de esta clase
        */
        public static void Peticion(char simbolo)
        {
            decimal num1;
            decimal num2;
            decimal resultado;

            switch (simbolo)
            {
                case '+':
                    Console.WriteLine("Ingresa un número: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Ingresa un otro número: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    resultado = num1 + num2;
                    Console.WriteLine("Tu resultado es: " + resultado);
                    break;
                case '-':
                    Console.WriteLine("Ingresa un número: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Ingresa un otro número: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    resultado = num1 - num2;
                    Console.WriteLine("Tu resultado es: " + resultado);
                    break;
                case '/':
                    Console.WriteLine("Ingresa un número: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Ingresa un otro número: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    if (num2 == 0)
                    {
                        throw new ArgumentException("Se ha intentado dividir entre 0");  // Aquí esta el error que hemos capturado
                        /* Este mensaje se va a guardar en la variable creada 'var_ex' de tipo
                           Exception que se encuentra dentro del 'catch' */
                    }

                    resultado = num1 / num2;
                    Console.WriteLine("Tu resultado es: " + resultado);
                    break;
                case '*':
                    Console.WriteLine("Ingresa un número: ");
                    num1 = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Ingresa un otro número: ");
                    num2 = Convert.ToDecimal(Console.ReadLine());

                    resultado = num1 * num2;
                    Console.WriteLine("Tu resultado es: " + resultado);
                    break;
                default:
                    Console.WriteLine("El signo elegido no es válida. Presione INTRO y vuelva a elgir.");
                    break;
            }
        }
    }
}
