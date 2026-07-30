namespace DesafioBank


{
    public class Employee : User
    {

        public int EmployeeID { get; set; }
        public string Position { get; set; }

        public Employee()
        {
           EmployeeID = new Random().Next(); 
        }

        public string AddPosition()
        {
            Console.WriteLine("Digite o cargo:");
            Position = Console.ReadLine();
            return Position;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine("ID: " + EmployeeID);
            Console.WriteLine("Cargo: " + Position);
            Console.WriteLine("Nome: " + Name);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("Email: " + Email);
            Console.WriteLine("Telefone: " + Phone);
            Console.WriteLine("-------------------------------\n");
        }

        public void FillCustomer()
        {
            Console.WriteLine("Cadastro de Funcionário");

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
            AddPosition();
            Console.WriteLine("Funcionário cadastrado com sucesso!");
            DisplayCustomer();
        }
    }
}