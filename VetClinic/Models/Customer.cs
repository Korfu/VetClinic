using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Attriubte;

namespace VetClinic.Models
{
    [CreatePrompt("Creating Customer... ")]
    public class Customer
    {
        [CreatePrompt("Customer name:")]
        public string Name { get; set; }
        [CreatePrompt("Customer surname:")]
        public string Surname { get; set; }
        [CreatePrompt("Customer age:")]
        public int Age { get; set; }
        [CreatePrompt("Customer city's name:")]
        public string CityName { get; set; }

        public void Display()
        {
            Console.WriteLine("Dsiplaying customer..");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"CityName: {CityName}");
        }
    }
}
