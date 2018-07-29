using System;
using System.Collections.Generic;
using System.Text;
using VetClinic.Attriubte;

namespace VetClinic.Models
{
    [CreatePrompt("Creating a snake: ")]
    public class Snake : Animal
    {
        [CreatePrompt("Snake's length: ")]
        public int Length { get; set; }

        

        public override void Display()
        {
            Console.WriteLine("Displaying snake!");
            base.Display();
            Console.WriteLine($"Length: {this.Length}");
        }
    }
}
