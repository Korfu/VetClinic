using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic.Models
{
    public class Cat : Animal
    {
        public string Race { get; set; }
        public string Color { get; set; }

        public override void Display()
        {
            Console.WriteLine("Displaying cat!");

            base.Display();

            Console.WriteLine($"Race: {this.Race}");
            Console.WriteLine($"Color: {this.Color}");
        }
    }
}
