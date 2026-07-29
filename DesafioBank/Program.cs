// Criar um sistema bancário simples com Conta e Transação
// 1. Utilizar conceitos de Abstração e Encapsulamento

using DesafioBank;

var account1 = new Account("João");
account1.Deposit(1000);
account1.Withdraw(500);
account1.PrintExtract();

Console.WriteLine("***********************");

var account2 = new Account("Maria");
account2.Deposit(2000);
account2.Transfer(300, account1);   
account2.PrintExtract();

Console.WriteLine("***********************");

account1.PrintExtract();