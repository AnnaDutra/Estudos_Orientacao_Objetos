namespace classes.Banco
{
    public class ContaBancaria
    {
        public int Saldo;
        public int NumeroDaConta;

        public void Depositar(int valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(int valor)
        {
            if (Saldo <= valor)
            {
                Console.WriteLine("Saldo insuficiente ");
            }
            else
            {
                Saldo = Saldo - valor;
            }
        }
    }
}
