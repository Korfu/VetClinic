using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Repositories
{
    public class AppointmentRepository
    {
        private static List<Appointment> _allAppointments = new List<Appointment>();

        public void Add(Appointment appointment)
        {
            _allAppointments.Add(appointment);
        }

        public IEnumerable<Appointment> GetAll()
        {
            return _allAppointments;
        }
    }
}
