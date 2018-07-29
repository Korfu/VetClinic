using System;
using System.Collections.Generic;
using System.Text;
using VetClinic.Attriubte;

namespace VetClinic.Models
{
    [CreatePrompt("Creating a dog: ")]
    public class Dog : Animal
    {
        [CreatePrompt("Dog's race: ")]
        public string Race { get; set; }
        [CreatePrompt("Dog's color: ")]
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
