using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay2
{
    internal class Cat
    {
        public static string BinomialName { get; } = "Felis Catus";
        public string Name { get; set; } 
        public  char _gender;
        public char Gender
        {
            get => Gender = _gender;
            set
            {
                if (value != 'f' && value != 'M') Console.WriteLine("GENDER MUST BE M OR F");
                else _gender = value;    
            }
        }
        public string Breed { get; set; }

        public int Move()
        {
            Console.WriteLine($"{Name} has moved");
            return new Random().Next();
        }
        public int Move(int distance)
        {
            Console.WriteLine($"{Name} has moved{distance}");
            return new Random().Next();
        }


        public void Sit(int min, string location, string name)
        {
            Console.WriteLine($"{Name} has sat for {min} minutes in {location}");
        }

        public void Mew()
        {
            Console.WriteLine($"{Name} has mew");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} has asleep");
        }

        public string GetName()
        {
            return Name; 
        }

        public void SetName(string name)
        {
            Name = name;   
        }
         
        public Cat(string name, char gender, string breed)
        {
            Name = name;
            Gender = gender;
            Breed = breed;
            PetShop.AddCat(this);
        }

        public Cat(string name)
        {
            Name = name;
            PetShop.AddCat(this);

        }

        public Cat()
        {
            PetShop.AddCat(this);
        }

        public static void PrintBinomialName() 
        {
            Console.WriteLine(BinomialName);
        }
    }
}
