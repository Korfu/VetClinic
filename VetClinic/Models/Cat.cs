using System;
using System.Collections.Generic;
using System.Text;
using VetClinic.Attriubte;

namespace VetClinic.Models
{
    [CreatePrompt("Creating a cat: ")]
    public class Cat : Animal
    {
        [CreatePrompt("Cat's race: ")]
        public string Race { get; set; }
        [CreatePrompt("Cat's color: ")]
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
