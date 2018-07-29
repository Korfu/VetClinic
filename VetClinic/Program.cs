using System;
using VetClinic.Models;
using VetClinic.Factories;
using VetClinic.Repositories;

namespace VetClinic
{
    class Program
    {   private static readonly AnimalFactory _animalFactory = new AnimalFactory();
        private static readonly CustomerFactory _customerFactory = new CustomerFactory();
        private static readonly AppointmentFactory _appointmentFactory = new AppointmentFactory();
        private static readonly AppointmentRepository _appointmentRepository = new AppointmentRepository();

        static void Main(string[] args)
        {
            Appointment.AppointmentCreatedEvent += (sender, eventArgs) =>
            {
                ((Appointment)sender).Display();
                Console.WriteLine($"Appointment number {eventArgs.AppointmentNumber}");
            };

            do
            {
                try
                {

                    DisplayMainMenu();

                    var chosenOption = Console.ReadKey(true);

                    switch (chosenOption.Key)
                    {
                        case ConsoleKey.D1:
                            CreateAppointment();
                            break;
                        case ConsoleKey.D2:
                            DisplayAllAppointments();
                            break;
                        default:
                            Console.WriteLine("Wrong option chosen!");
                            break;
                    }
                    Console.WriteLine("Press escape to exit or any other key to go again");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error has occured");
                    Console.WriteLine($"Exception message: {ex.Message}");
                }
                finally //wykonuje się zawsze po try, nie ważne czy bedzie błąd czy nie
                {

                }


            } while (Console.ReadKey().Key != ConsoleKey.Escape);

          

        }

        private static void DisplayAllAppointments()
        {
            Console.WriteLine("Displaying all appointments");
            var appointmentList = _appointmentRepository.GetAll();
            foreach (var appointment in appointmentList)
            {
                appointment.Display();
            }
            
        }

        private static void DisplayMainMenu()
        {
            Console.WriteLine("Hello to VetClinic!");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) Create appointment");
            Console.WriteLine("2) Display all appointments");
        }

        

        public static void CreateAppointment()
        {
            var customer = _customerFactory.CreateCustomer();
            var animal = _animalFactory.CreateAnimal();
            var appointment = _appointmentFactory.CreateAppointment(animal, customer);
            Console.WriteLine(" ");
            //appointment.Display();
        }
    }
}
