using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic.Models
{
    public class Dog : Animal
    {
        public string Race { get; set; }
        public string Color { get; set; }

        public override void Display()
        {
            Console.WriteLine("Displaying dog!");

            base.Display();

            Console.WriteLine($"Race: {this.Race}");
            Console.WriteLine($"Color: {this.Color}");
        }
    }
}
