//Realice un programa que solicite dos números, luego debe pedirse un número que seleccionará alguna operación aritmética desde un menú. 
//Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican
//y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. 
//Además, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación 
//aritmética o digitar cero para finalizar el programaaa.


internal class Program
{
    private static void Main(string[] args)
    {
        int option;
        double suma, resta, producto, cociente, num1, num2;
        // flag para volver o salir
        bool exit = false;

        do
        {
            Console.Clear();         
            Console.Write("Ingrese dos numeros: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n|----MENÚ OÉRACIONES ARITMETICAS----|");
            Console.WriteLine("|Seleccione una operacion aritmetica|");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("|1. Suma                            |");
            Console.WriteLine("|2. Resta                           |");
            Console.WriteLine("|3. Multiplicacion                  |");
            Console.WriteLine("|4. Division                        |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("|Digite 0 para salir                |");
            Console.WriteLine("|-----------------------------------|\n");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)

            {
                case 0:

                default:
                    exit = true;
                    break;

                case 1:
                    suma = num1 + num2;
                    Console.WriteLine(string.Format("{0} + {1}= {2}\n", num1, num2, suma));
                    Console.ReadKey();
                    break;
                case 2:
                    resta = num1 - num2;
                    Console.WriteLine(string.Format("{0} - {1}= {2}\n", num1, num2, resta));
                    Console.ReadKey();
                    break;
                case 3:
                    producto = num1 * num2;
                    Console.WriteLine(string.Format("{0} * {1}= {2}\n", num1, num2, producto));
                    Console.ReadKey();
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        cociente = num1 / num2;
                        Console.WriteLine(string.Format("{0} / {1}= {2}\n", num1, num2, cociente));
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero\n");
                        break;
                    }
                    
            }           
         
        }
        while (exit);
    }
}