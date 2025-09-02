Conta c1 = new Conta(1, "Leonardo");
Conta c2 = new Conta(2, "Maria Fernanda");

Console.WriteLine("Dados iniciais das contas:");
Console.WriteLine(c1);
Console.WriteLine(c2);

Console.WriteLine("\nDepositando nas contas:");
c1.Depositar(5000, 1);
c2.Depositar(2000, 2);
Console.WriteLine(c1);
Console.WriteLine(c2);

Console.WriteLine("\nSacando nas contas:");
c1.Sacar(3000, 1);
c2.Sacar(1000, 2);
Console.WriteLine(c1);
Console.WriteLine(c2);