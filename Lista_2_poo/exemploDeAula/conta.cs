public class Conta
{
    // Atributos
    public int Numero;
    public double Saldo;
    public string Titular;
    // atributos

    // Construtor
    public Conta(int numero, string titular)
    {
        Numero = numero;
        Saldo = 0.0; // Inicializa o saldo como zero
        Titular = titular;
    }

    // Métodos
    public bool Depositar(double valor, int numero)
    {
        if (Numero != numero)
        {
            return false; // Conta não encontrada
        }
        Saldo += valor;
        return true; // Depósito realizado com sucesso
    }
    public bool Sacar(double valor, int numero)
    {
         if (Numero != numero || Saldo < valor)
        {
            return false; // Conta não encontrada ou saldo insuficiente
        }
        Saldo -= valor;
        return true; // Saque realizado com sucesso
    }
}