Conta c1 = new Conta(1, "Leonardo");
Conta c2 = new Conta(2, "Maria Fernanda");


Console.WriteLine("\nDepositando nas contas:");
c1.Depositar(5000, 1);
c2.Depositar(2000, 2);
Console.WriteLine(c1 + "" + c2);

Console.WriteLine(c1.Get);
Console.WriteLine(c1 + "" + c2);