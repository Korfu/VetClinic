using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic.Models
{
    public abstract class Animal
    {
        public int Age { get; set; }

        private string _name;

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if(!value.Any(x => char.IsDigit(x)))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Age: {this.Age}");
        }

    }
}
