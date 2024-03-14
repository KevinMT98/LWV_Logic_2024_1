//Construir un algoritmo que pida N numeros por pantalla, Cuando el usuairo ingrese un numero negativo.
//el programa debe finalizar y mostrar en consola la cantidad total de numeros
//positivos que ingreso hasta antes de ingresarse el numero negativo.
internal class Program
{
    private static void Main(string[] args)
    {
        int num, contador = 0;
        bool validador = true;

        // creacion ciclo

        while (validador) // flag
        {
            Console.Write("Ingrese un numero..:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0) validador = false;            
            else contador = contador + 1;               
        }

        // forma 2
        // omito la creacion de una variable de estado flag o sea en este caso la variable validador
        // segundo, en el while directamente ingreso la palabra reservada "true"
        // si el true no se acompaña con la palabra reservada "break" se generara un bucle infinito
        // creacion ciclo

        while (true)
        {
            Console.Write("Ingrese un numero..:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                break;
            }
            else
            {
                contador = contador + 1;
            }
        }

        Console.WriteLine(String.Format("El total de numeros ingresados es de: {0}", contador));
    }
}