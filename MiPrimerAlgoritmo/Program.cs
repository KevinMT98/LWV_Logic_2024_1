// using System : sirve para buscar librerias como convertidos de Json o importar datos a excel

public class Program
{
    static void Main(string[] args)
    {
        //Declaracion de variables
        double num1, num2, num3;
        double suma, rest, prod, coc, exp1, exp2;

        //leer num 1
        Console.Write("Ingrese el primero numero ");
        num1 = Convert.ToInt32(Console.ReadLine()); //todo lo que ingrese en esta linea sera tomado como un string
        Console.WriteLine();
        //ler num 2
        Console.Write("Ingrese el primero numero. este numero debe ser diferente de cero ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        //Leer exponente
        Console.Write("Ingrese exponente ");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        // hacer calculos
        suma = num1 + num2;
        rest = num1 - num2;
        prod = num2 * num1;
        coc = num1 / num2;
        exp1 = Math.Pow(num1, num3);
        exp2 = Math.Pow(num2, num3);

        // imprimer en pantalla
        Console.WriteLine("La suma de: " + num1 + " + " + num2 + " = " + suma); // 1ra forma de concatenar texto
        Console.WriteLine("La resta de: " + num1 + " - " + num2 + " = " + rest);
        Console.WriteLine("La multiplicacion de: " + num1 + " * " + num2 + " = " + prod);
        Console.WriteLine("La division de: " + num1 + " / " + num2 + " = " + coc);
        Console.WriteLine("La potencia de: " + num1 + " Elevado a la " + num3 + " = " + exp1);
        Console.WriteLine("La potencia de: " + num2 + " Elevado a la " + num3 + " = " + exp2);
    }
}
