internal class Program
{
    //Programe un algoritmo que pida a usuario 2 números por pantalla y que muestre todos los números comprendidos
    //entre ambos números incluyéndolos.
    private static void Main(string[] args)
    {
        int num1, num2, numMayor, numMenor;

        Console.Write("Digite el primer numero: ");
        Console.WriteLine();
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite el segundo numero: ");
        Console.WriteLine();
        num2 = Convert.ToInt32(Console.ReadLine());
        
        if (num1 > num2)
        {
            numMayor = num1;
            numMenor = num2;
        }

        else
        { 
            numMenor = num1;
            numMayor = num2;
        }

        Console.WriteLine(" ");
        for (int i = numMenor; i <= numMayor; i++) Console.Write(i + ", ");

        Console.Write(" \n");
    }
}