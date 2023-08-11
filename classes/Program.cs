using classes.Banco;

ContaBancaria conta1 = new ContaBancaria();
conta1.Saldo = 1000;

Console.WriteLine(conta1.Saldo);
conta1.Depositar(100);
conta1.Sacar(1200);

Console.WriteLine(conta1.Saldo);



