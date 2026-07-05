// 🏆 Ejercicio:
// Implementar un programa que recorra los números del 1 al 100.
// Consideraciones:
// Aplicar la lógica de FizzBuzz:
// - Si un número es divisible por 3, imprimir "Fizz".
// - Si un número es divisible por 5, imprimir "Buzz".
// - Si un número es divisible por 3 y 5, imprimir "FizzBuzz".
// - En cualquier otro caso, imprimir el número.
// 💡 Pista:
// - El orden de las condiciones es clave.
// Piensa en cómo asegurarte de que "FizzBuzz" se imprima antes que "Fizz" o "Buzz".

partial class Program
{
    static void FizzBuzz()
    {
        int numero = 0;
        while (numero <= 100)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                WriteLine("FizzBuzz");
            }
            else if (numero % 3 == 0)
            {
                WriteLine("Fizz");
            }
            else if (numero % 5 == 0)
            {
                WriteLine("Buzz");
            }
            else
            {
                WriteLine(numero);
            }
            numero++;
        }

    }
}