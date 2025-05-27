using System;



namespace MyNamespace
{
    public enum Status
    {
        standing,
        walking,
        hiding
    }

    public class Commando
    {
        public string Name { get; }= "papa";
        public string CodeName { get; set; } = "x";
        private string[] Tools = new string[] { "Hammer", "Chisel", "Rope", "Bag", "Watery" };
        private Status Status { get; set; }


        public Commando(string name, string codeName, string[] tools, Status status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Tools = tools;
            this.Status = status;
        }

        public Commando()
        {
           
        }

        public string GetName()
        {
            return this.Name;
        }

        public void SayName(string commanderRank)
        {
            if (commanderRank == "GENERAL")
            {
                Console.WriteLine( this.Name);
               
            }
            else if (commanderRank == "COLONEL")
            {
                Console.WriteLine( this.CodeName); 
            }
            else
            {
                Console.WriteLine("this information is classified");
            }
        }

        public void Walk()
        {
            this.Status = Status.walking;
            Console.WriteLine("The soldier is walking");
        }

        public void Hide()
        {
            this.Status = Status.hiding;
            Console.WriteLine("The soldier is hiding");
        }

        public virtual void Attack(string input)
        {
            if (input == "codename")
            {
                Console.WriteLine($"Commando with code name {this.CodeName} is attacking");
            }
            else if (input == "name")
            {
                Console.WriteLine($"Commando name is {this.Name}");
            }
        }

    }

    public class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, string[] tools, Status status) : base(name, codeName, tools, status)
        {
            
        }
        public AirCommando(){}

        public void print()
        {
            Console.WriteLine("air commandi can parachute");
        }

        public override void Attack(string input)
        {
            if (input == "codename")
            {
                Console.WriteLine($" {this.CodeName} Air commandos attack ");
            }
            else if (input == "name")
            {
                Console.WriteLine($"{this.Name} Air commandos attack");
            }
        }
        
            
    }


    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string[] tools, Status status) : base(name, codeName, tools, status)
        {
            
        }
        public SeaCommando(){}
        
        public void print()
        {
            Console.WriteLine("sea commando can swim");
        }

        public override void Attack(string input)
        {
            if (input == "codename")
            {
                Console.WriteLine($" {this.CodeName} A naval commando attack.");
            }
            else if (input == "name")
            {
                Console.WriteLine($"{this.Name} A naval commando attack.");
            }
        }
    }

    public class Weapon
    {
        private string Name { get; set; } 
        private string Make { get; set; }
        private int Bullets = 12;
        
        public Weapon(string name, string make, int bullets)
        {
            this.Name = name;
            this.Make = make;
            this.Bullets = bullets;
        }

        public Weapon()
        {
            
        }

        public void Shoot()
        {
            this.Bullets -= 1;
            Console.WriteLine("bang!");
        }
        
        
    }
    
    class TestClass
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando();
            Console.WriteLine( commando.GetName());

            Console.WriteLine(commando.CodeName);
            commando.CodeName = "y";
            Console.WriteLine(commando.CodeName);
            
            AirCommando airCommando = new AirCommando();
           
            
            SeaCommando seaCommando = new SeaCommando();
            
            
            
            Commando[] soldiers = new []{commando, airCommando, seaCommando};

            Console.WriteLine(soldiers.Length);

            foreach (var soldier in soldiers)
            {
                soldier.Attack("name");
            }




            // commando.Attack("codename");
            // commando.Hide();
            // commando.Walk();
            //
            //
            //
            // Weapon weapon = new Weapon();
            //
            // weapon.Shoot();
        }
        
        
    }
}