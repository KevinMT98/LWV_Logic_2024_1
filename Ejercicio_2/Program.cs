public class Program
{
    static void Main(string[] args)
    {
        //Declaracion de variables
        double num1 = 0, num2 = 0, num3 = 0;
        double cua, root2, root3;
        string aux;
        
        while (true)
        {
            try
            {
                Console.Write("Ingrese el primero numero: ");
                aux = Console.ReadLine();
                num1 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
                //error = true;
            }
        }
        //error = true;
        while (true)
        {


            try
            {
                //leer num 2
                Console.Write("Ingrese el segundo numero: ");
                aux = Console.ReadLine();
                num2 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;

            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
            }
        }
        while (true)
        {

            try
            {
                //leer num3
                Console.Write("Ingrese el tercer numero: ");
                aux = Console.ReadLine();
                num3 = Convert.ToInt32(aux);
                Console.WriteLine();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Solo debe ingresar valores numerico: ");
            }

        }

        cua = num1 * num1;
        root2 = Math.Sqrt(num2);
        root3 = Math.Cbrt(num3);

        // imprimer en pantalla
        Console.WriteLine("El cuadrado de.....: " + num1 + " = " + cua);
        Console.WriteLine("La raiz cuadrada de: " + num2 + " = " + root2);
        Console.WriteLine("La raiz cubica de..: " + num3 + " = " + root3);
    }

}

