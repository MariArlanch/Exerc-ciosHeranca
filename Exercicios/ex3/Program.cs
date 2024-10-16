using ex3;

ContaCorrente contaCorrente1 = new ContaCorrente

{
    Banco = "Bradesco",
    Agente = 4526,
    conta = 8474,
    Saldo = 19.500,
    limite = 50000
};
Console.WriteLine($"Seu banco é: {contaCorrente1.Banco}, seu agente é: {contaCorrente1.Agente}, sua conta é: {contaCorrente1.conta}, seu saldo é de: {contaCorrente1.Saldo} e o seu limite é de: {contaCorrente1.limite}");
contaCorrente1.Depositar();

ContaCorrente contaCorrente2 = new ContaCorrente

{
    Banco = "Santander",
    Agente = 8926,
    conta = 0844,
    Saldo = 11.500,
    limite = 50000
};
Console.WriteLine($"Seu banco é: {contaCorrente2.Banco},seu agente é: {contaCorrente2.Agente}, sua conta é: {contaCorrente2.conta}, seu saldo é de: {contaCorrente2.Saldo} e o seu limite é de: {contaCorrente2.limite}");
contaCorrente2.Depositar();

ContaCorrente contaCorrente3 = new ContaCorrente

{
    Banco = "z1",
    Agente = 4526,
    conta = 2784,
    Saldo = 94.500,
    limite = 50000
};

Console.WriteLine($"Seu banco é: {contaCorrente3.Banco}, seu agente é: {contaCorrente3.Agente}, sua conta é: {contaCorrente3.conta}, seu saldo é de: {contaCorrente3.Saldo} e o seu limite é de: {contaCorrente3.limite}");
contaCorrente3.Depositar();
Console.ReadKey();