using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Events;
using VetClinic.Helper;
using VetClinic.Helpers;
using VetClinic.Models;
using VetClinic.Repositories;

namespace VetClinic.Factories
{
    public class AppointmentFactory
    {
        private readonly AppointmentRepository _appointmentRepository = new AppointmentRepository();
        private static int AppointmentCounter = 0;

        public Appointment CreateAppointment(Animal animal, Customer owner)
        {
            //Console.WriteLine("Creating appointment...");
            //Console.WriteLine("Choose date:");
            //var dateTime = Console.ReadLine();

            var appointment = InstanceHelper.CreateInstance<Appointment>();

            appointment.Owner = owner;
            appointment.Animal = animal;

            //var appointment = new Appointment
            //{
            //    DateTime = dateTime,
            //    Animal = animal,
            //    Owner = owner
            //};
            Appointment.AppointmentCreatedEvent.Invoke(appointment, new AppointmentCreatedEventArgs
            {
                AppointmentNumber = ++AppointmentCounter
            });

            _appointmentRepository.Add(appointment);

            return appointment;
        }
    }
}
