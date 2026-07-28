namespace exercicio01

{
    public class Character
    {
        public string Name { get; set; }
        public string Race{ get; set; }
        public string Class { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }

        public Character(string name, string race, string charClass)
        {
            Name = name;
            Race = race;
            Class = charClass;
            Level = 1;
            Health = 100;
            Strength = 30;
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} está andando.");
            Console.WriteLine($"---------------------");

        }

        public void Attack(Character target)
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} não pode atacar porque está morto.");
                return;
            }

            int damage = Strength;
            Console.WriteLine($"{Name} atacou {target.Name}!");
            Console.WriteLine($"------------------------------");
            target.TakeDamage(damage);

            if (target.Health <= 0)
            {
                LevelUp();
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} tomou {damage} de dano!");
            Console.WriteLine($"-------------------------------");

            if (Health <= 0)
            {
                Console.WriteLine($"xXx {Name} morreu! xXx");
            }

        }

        public void LevelUp()
        {
            Level++;
            Health += Level * 10;
            Strength += Level * 5;
            Console.WriteLine($"**********************************");
            Console.WriteLine($"{Name} subiu para o nível {Level}!");
            Console.WriteLine($"**********************************");

        }
    }
}