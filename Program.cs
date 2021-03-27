using System;

namespace A133590.Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 17.");
            Console.WriteLine("Programa que solicita dos números y presenta distintas operaciones entre ellos.");

            double primerNumero, segundoNumero;

            Console.Write("Por favor ingrese un número: ");
            bool exito = Double.TryParse(Console.ReadLine(), out primerNumero);
            if(!exito)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }

            Console.Write("Por favor ingrese otro número: ");
            exito = Double.TryParse(Console.ReadLine(), out segundoNumero);
            if (!exito)
            {
                Console.WriteLine("Ingreso inválido, no puede ser interpretado como numérico.");
                return;
            }

            Console.WriteLine($"Suma: {primerNumero + segundoNumero}");
            Console.WriteLine($"Resta: {primerNumero - segundoNumero}");
            Console.WriteLine($"Mutiplicación: {primerNumero * segundoNumero}");
            if(segundoNumero != 0)
            {
                Console.WriteLine($"División: {primerNumero / segundoNumero}");
                Console.WriteLine($"Modulo: {primerNumero % segundoNumero}");
            }
            else
            {
                Console.WriteLine("División y módulo no son posibles porque el segundo ingreso es 0.");
            }

            Console.WriteLine($"Potencia: {Math.Pow(primerNumero, segundoNumero)}");

            Console.WriteLine("Presione cualquier tecla para continuar..");
            Console.ReadKey();
        }
    }
}
