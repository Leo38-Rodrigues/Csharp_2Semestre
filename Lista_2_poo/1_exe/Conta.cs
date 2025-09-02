public class Conta
{
    // Atributos
    public int Numero { get; private set; }
    private double Saldo { get; private set; }
    public string Titular;
    // atributos

    // Construtores = inicializa os atributos da classe com algum valor
    public Conta(int numero, string titular) // tem que ser publico e ter o mesmo nome da classe
    {

        Numero = numero;
        Saldo = 0.0; // Inicializa o saldo como zero
        Titular = titular;

    }

    // Métodos
    public bool Depositar(double valor, int numero)
    {
        if (Numero != numero || valor <= 0)
        {
            return false; // Conta não encontrada
        }
        Saldo += valor;
        return true; // Depósito realizado com sucesso
    }
    public bool Sacar(double valor, int numero)
    {
        if (Numero != numero || Saldo < valor || valor <= 0)
        {
            return false; // Conta não encontrada ou saldo insuficiente
        }
        Saldo -= valor;
        return true; // Saque realizado com sucesso
    }
    //------------------------------------------------------------------------------------------------
    //Getters and Setters
    //GET NUMERO
    public int GetNumero()
    {
        return Numero;
    }
    //GET AND SET TITULAR
    public string GetTitular()
    {
        return Titular;
    }
    public void SetTitular(string titular)
    {
        Titular = titular;
    }
    
    //------------------------------------------------------------------------------------------------
    //ToString
    public override string ToString()
    {
        return $"\nConta: {Numero}, \nTitular: {Titular}, \nSaldo: {Saldo}\n";
    }

}


