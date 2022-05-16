using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Carlos Veloso";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia Central";
conta1.saldo = 100.00;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Alon Mauricio";
conta2.conta = "10124-X";
conta2.numero_agencia = 95;
conta2.nome_agencia = "Agencia Central";
conta2.saldo = 100.00;

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome Agencia: " + conta1.nome_agencia);
//Console.WriteLine("Saldo: " + conta1.saldo);

Console.WriteLine("Saldo do Alon pré-saque: " + conta2.saldo);

bool saque = conta2.Sacar(50);

Console.WriteLine("saque realizado" + saque);

Console.WriteLine("Saldo do Alon pós-saque: " + conta2.saldo);

Console.WriteLine("Saldo do Alon pré-deposito: " + conta2.saldo);
conta2.Depositar(60);
Console.WriteLine("Saldo do Alon pós-deposito: " + conta2.saldo);


Console.ReadKey();
