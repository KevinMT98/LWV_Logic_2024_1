/*Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoría:

- Si el IMC del paciente es menor a 18,5, entonces tiene peso insuficiente.

- Si el IMC está entre 18,5 y 24,9 se encuentre en la categoría de Peso Saludable

- Si el IMC está entre 25,0 y 29,9 entonces tiene sobrepeso

- Si el IMC es mayor de 29.9 entonces tiene obesidad.*/
internal class Program
{
    private static void Main(string[] args)

    {
        string? respuesta;
        do
        {
            double peso, altura, IMC;
            string? nombre, aux;

            Console.Write("Ingrese nombre del paciente: ");
            Console.WriteLine();
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            while (true)
            {
                try
                {
                    Console.Write("Ingrese el peso del paciente: ");
                    Console.WriteLine();
                    aux = Console.ReadLine();
                    peso = Convert.ToInt32(aux);
                    Console.WriteLine();
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo debe ingresar valores numerico: ");
                    Console.WriteLine();
                }
            }

            Console.Write("Ingrese la altura del paciente: ");
            Console.WriteLine();
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            IMC = (peso / Math.Pow(2, altura));

            if (IMC < 18.5)
                Console.WriteLine($"El IMC del paciente {nombre} es: {IMC.ToString("N4")} Y cuenta con un peso insuficiente. ");
            else if (IMC >= 18.5 && IMC <= 24.9)
                Console.WriteLine($"El IMC del paciente {nombre} es: {IMC.ToString("N4")} Y se encuentre en la categoría de Peso Saludable. ");
            else if (IMC >= 25.5 && IMC < 29.9)
                Console.WriteLine($"El IMC del paciente {nombre} es: {IMC.ToString("N4")} Y cuenta con sobrepeso. ");
            else
                Console.WriteLine($"El IMC del paciente {nombre} es: {IMC.ToString("N4")} Y cuenta con obesidad. ");
                Console.WriteLine();


            Console.Write("¿Desea ingresar otro paciente? (S/N): ");
            Console.WriteLine();

            respuesta = Console.ReadLine();
        } while (respuesta.ToLower() == "s");
           
    }
}

    


