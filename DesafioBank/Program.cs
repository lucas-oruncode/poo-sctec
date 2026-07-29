// Criar um sistema bancário simples com Conta e Transação
// 1. Utilizar conceitos de Abstração e Encapsulamento
// 2. Criar uma classe para clientes e adaptar na classe conta

using DesafioBank;

var customer1 = new Customer();
customer1.FillCustomer();

var customer2 = new Customer();
customer2.FillCustomer();

var account1 = new Account(customer1);
account1.Deposit(1000);
account1.Withdraw(500);
account1.PrintExtract();

Console.WriteLine("***********************");

var account2 = new Account(customer2);
account2.Deposit(2000);
account2.Transfer(300, account1);   
account2.PrintExtract();

Console.WriteLine("***********************");

account1.PrintExtract();