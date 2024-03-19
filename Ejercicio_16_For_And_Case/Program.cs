internal class Program
{
    private static void Main(string[] args)
    {
        int acumuladorPar = 0, acumuladorImpar = 0;

        for(int i = 1; i <= 100; i++) 
        {
            Console.WriteLine(i);
            if(i % 2 == 0) acumuladorPar += i;
            else acumuladorImpar += i;
          
        }
        Console.WriteLine($"La suma de los pares es {acumuladorPar}");
        Console.WriteLine($"La suma de los impares es {acumuladorImpar}");
    }
}