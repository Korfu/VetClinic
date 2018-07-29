using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Events
{
    public delegate void AppointmentCreatedEventHandler(object source, AppointmentCreatedEventArgs eventArgs);

    public class AppointmentCreatedEventArgs : EventArgs
    {
        public int AppointmentNumber { get; set; }
    }
}
