/* Reglas
El programa debe calcular un bono según el salario:
Salario	Bono
Menor a $15,000	15%
Entre $15,000 y $25,000	10%
Mayor a $25,000	5%
Además, al finalizar debe mostrar:
El empleado con el salario más alto.
Cuánto dinero total pagará la empresa en bonos.
Cuántos empleados recibieron bono del 15%.
 */
partial class Program
{
    static void Exercise09()
    {
        List<string> empleados = new List<string> { "Ana", "Carlos", "María", "José", "Laura" };
        List<decimal> salarios = new List<decimal> { 15000m, 22000m, 18000m, 30000m, 12000m };
        decimal salarioAlto = 0;
        int posicionSalarioAlto = 0;
        decimal bono5 = 0;
        decimal bono10 = 0;
        decimal bono15 = 0;
        int cantidadBono15 = 0;
        decimal totalBonos = 0;

        for (int i = 0; i < salarios.Count; i++)
        {
            if (salarios[i] < 15000)
            {
                bono15 = salarios[i] * 0.15m;
                decimal suma = salarios[i] + bono15;
                totalBonos += bono15;
                cantidadBono15++;
                WriteLine($"{empleados[i]}");
                WriteLine($"Salario: {salarios[i]:C2}");
                WriteLine($"Bono: {bono15:C2}");
                WriteLine($"Total: {suma:C2}");
                WriteLine("---------------------------");
            }

            else if (salarios[i] <= 25000)
            {
                bono10 = salarios[i] * 0.10m;
                decimal suma = salarios[i] + bono10;
                totalBonos += bono10;
                WriteLine($"{empleados[i]}");
                WriteLine($"Salario: {salarios[i]:C2}");
                WriteLine($"Bono: {bono10:C2}");
                WriteLine($"Total: {suma:C2}");
                WriteLine("---------------------------");
            }

            else
            {
                bono5 = salarios[i] * 0.05m;
                decimal suma = salarios[i] + bono5;
                totalBonos += bono5;
                WriteLine($"{empleados[i]}");
                WriteLine($"Salario: {salarios[i]:C2}");
                WriteLine($"Bono: {bono5:C2}");
                WriteLine($"Total: {suma:C2}");
                WriteLine("---------------------------");
            }

            if (salarios[i] > salarioAlto)
            {
                salarioAlto = salarios[i];
                posicionSalarioAlto = i;
            }
        }
        WriteLine($"Empleado con mayor salario: {empleados[posicionSalarioAlto]} - {salarios[posicionSalarioAlto]:C2}");
        WriteLine($"Total de bonos a pagar: {totalBonos:C2}");
        WriteLine($"Número de empleados que reciben 15% de bonos: {cantidadBono15}");
    }
}