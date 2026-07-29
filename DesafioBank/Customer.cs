namespace DesafioBank

{
    public class Customer
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customer()
        {
            
        }

        public string AddName()
        {
            Console.WriteLine("Digite o nome do cliente:"); 
            Name = Console.ReadLine();
            return Name;
        }

        public string AddCPF()
        {
            Console.WriteLine("Digite o CPF do cliente:");
            CPF = Console.ReadLine();
            return CPF;
        }

        public string AddEmail()
        {
            Console.WriteLine("Digite o email do cliente:");
            Email = Console.ReadLine();
            return Email;
        }

        public string AddPhone()
        {
            Console.WriteLine("Digite o telefone do cliente:");
            Phone = Console.ReadLine();
            return Phone;
        }

        public string AddAddress()
        {
            Console.WriteLine("Digite o endereço do cliente:");
            Address = Console.ReadLine();
            return Address;
        }

        public bool ValidateCPF(string cpf)
        {
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        public bool ValidateEmail(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                return false;
            }
            return true;
        }        
        public void DisplayCustomer()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("Nome: " + Name);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefone: " + Phone);
            Console.WriteLine("Endereço: " + Address);
            Console.WriteLine("-------------------------------\n");
        }

        public void FillCustomer()
        {
            AddName();

            do
            {
                AddCPF();
                if (!ValidateCPF(CPF))
                {
                    Console.WriteLine("CPF inválido. Digite novamente.");
                }
            }
            while (!ValidateCPF(CPF));

            do
            {
                AddEmail();
                if (!ValidateEmail(Email))
                {
                    Console.WriteLine("Email inválido. Digite novamente.");
                }
            }
            while (!ValidateEmail(Email));

            AddPhone();
            AddAddress();
            Console.WriteLine("Cliente cadastrado com sucesso!");
            DisplayCustomer();
        }



    }
}