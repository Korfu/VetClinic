using System;
using System.Collections.Generic;
using System.Text;

namespace VetClinic.Models
{
    public class Snake : Animal
    {
        public int Length { get; set; }

        

        public override void Display()
        {
            Console.WriteLine("Displaying snake!");
            base.Display();
            Console.WriteLine($"Length: {this.Length}");
        }
    }
}
