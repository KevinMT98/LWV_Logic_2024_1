public class Program
{
    static void Main(string[] args)
    {
        //Declaracion de variables
        double num1, num2, num3;
        double cua, root2, root3;
      

        //leer num 1
        Console.Write("Ingrese el primero numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        //leer num 2
        Console.Write("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        //leer num3
        Console.Write("Ingrese el tercer numero: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        cua = num1 * num1;
        root2 = Math.Sqrt(num2);
        root3 = Math.Cbrt(num3);

        // imprimer en pantalla
        Console.WriteLine("El cuadrado de.....: " + num1 + " = " + cua);
        Console.WriteLine("La raiz cuadrada de: " + num2 + " = " + root2);
        Console.WriteLine("La raiz cubica de..: " + num3 + " = " + root3);
    }
}

