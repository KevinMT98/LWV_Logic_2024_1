//Realizar un algoritmo con C# donde se solucione el siguiente problema: Un vendedor recibe un 
//sueldo base de $XXXX. Además, recibe una comisión del 10% sobre el valor total de cada venta que 
//realiza. El vendedor desea saber:
// ¿Cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el 
//mes?
// ¿Cuál es el total que recibirá en el mes tomando en cuenta su sueldo base y comisiones?
// ¿Cuál fue la venta que le generó la mayor comisión?
// ¿Cuál fue el promedio de las comisiones que recibió por cada venta?
//Además, la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El 
//objetivo es sumar en las 3 ventas como mínimo $1.000.000 en ventas. Mostrar un mensaje donde 
//indique si ganó o no el beneficio.
public class Program
{
    private static void Main(string[] args)
    {
        double salariobase;
        Console.Write("Ingrese salario ");
        Console.WriteLine();
        salariobase = Convert.ToDouble(Console.ReadLine);
                
        {
            ventastotales();
        }
        

        static double ventastotales()

        {
            double venta1, venta2, venta3, totalventas;
            Console.Write("Ingrese valor venta 1: ");
            Console.WriteLine();
            venta1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese valor venta 2: ");
            Console.WriteLine();
            venta2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese valor venta 3: ");
            Console.WriteLine();
            venta3 = Convert.ToDouble(Console.ReadLine());

            totalventas = (venta1 + venta2 + venta3);

            totalventas = Convert.ToDouble(Console.ReadLine());

            return(totalventas);

        }



        static void PerimetroDelCuadrado()
        {
            double lado, perimetro;
            Console.Write("Ingrese un lado del cuadrado ");
            Console.WriteLine();
            lado = Convert.ToDouble(Console.ReadLine());

            perimetro = (lado * 4);

            Console.Write($"El perimetro del cuadrado es {perimetro}");
            Console.WriteLine();
        }

    }
}