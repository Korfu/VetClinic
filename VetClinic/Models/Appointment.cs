using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Events;

namespace VetClinic.Models
{
    public class Appointment
    {
        public string DateTime { get; set; }
        public Animal Animal { get; set; }
        public Customer Owner { get; set; }

        public static AppointmentCreatedEventHandler AppointmentCreatedEvent;
                       
        public void Display()
        {
         Console.WriteLine("Displaying appointment");
        Console.WriteLine($"Time of appointment: {DateTime}");
        Animal.Display();
        Owner.Display();
        }
    }
}
