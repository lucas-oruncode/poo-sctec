namespace DesafioBank

{
    public abstract class User
    {
        
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string AddName()
        {
            Console.WriteLine("Digite o nome:"); 
            Name = Console.ReadLine();
            return Name;
        }

        public string AddCPF()
        {
            Console.WriteLine("Digite o CPF:");
            CPF = Console.ReadLine();
            return CPF;
        }

        public string AddEmail()
        {
            Console.WriteLine("Digite o email:");
            Email = Console.ReadLine();
            return Email;
        }

        public string AddPhone()
        {
            Console.WriteLine("Digite o telefone:");
            Phone = Console.ReadLine();
            return Phone;
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
    }
}