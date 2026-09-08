partial class Program
{
    static void Exercise43()
    {
        CuentaBancaria43 cuenta = new CuentaBancaria43("Aldo", 25000);
        try
        {
            WriteLine($"Titular: {cuenta.Titular}");
            WriteLine($"Saldo: {cuenta.Saldo}");
            cuenta.Retirar(30000);
        }
        catch (Exception ex)
        {
            WriteLine($"Error: {ex.Message}");
        }
    }

    class CuentaBancaria43
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }

        public CuentaBancaria43(string titular, decimal saldo)
        {
            Titular = titular;
            Saldo = saldo;
        }

        public void Retirar(decimal cantidad)
        {

            if (cantidad > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
            Saldo -= cantidad;
        }
    }
}