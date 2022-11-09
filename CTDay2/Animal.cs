using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDay2
{
    public abstract class Animal
    {
        public string? Name { get; set; }     
        public char Gender { get; set; }
        protected DateTime InsertionDate { get; set; } = DateTime.MinValue;
        public String Greeting { get; } = "hello from anumal";
        private string Secret = "my secret";

        public void print() {
            Console.WriteLine(Secret);
        }
        public void PrintName()
        {
            Console.WriteLine(Name);  
        }
        public abstract void Eat(int volume);
        

        public Animal() { }
        public Animal(string name, char gender)
        {
            Name = name;
            Gender = gender;
            InsertionDate = DateTime.Now;
        }

        


    }
}
