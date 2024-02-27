using System;

internal class Program //condicionales - rama de condicionales ejercicio 2 
                       // 2.	Lea la longitud de tres segmentos y que muestre si se puede construir un triángulo con estos segmentos.
{ 
    private static void Main(string[] args)
    {
        double seg1, seg2, seg3, suma;
        string mensaje = "Se puede construir un triangulo ";

        // pedir datos
        Console.Write("SEGMENTO POSITIVO \n");
        Console.Write("\n Ingrese primer segmento:  ");
        seg1 = Convert.ToDouble(Console.ReadLine());


        Console.Write("\n Ingrese segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());


        Console.Write("\n Ingrese tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //validar: 

        if (((seg1 + seg2) > seg3) && ((seg1 + seg3) > seg2) && ((seg2 + seg3) > seg1))
        {
            Console.WriteLine(string.Format("\n Si {0}", mensaje));

        }
        else
            Console.WriteLine(string.Format("\n No {0}", mensaje));


    }
}
