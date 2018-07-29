using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Helper;
using VetClinic.Models;

namespace VetClinic.Factories
{
    public class CustomerFactory
    {

        //private int _fieldproperty;
        //public int FieldProperty
        //{
        //    get
        //    {
        //        return _fieldproperty;
        //    }
        //    set
        //    {
        //        _fieldproperty = value;
        //    }
        //}


        private readonly InputHelper _inputHelper = new InputHelper();
        public Customer CreateCustomer()
        {
            Console.WriteLine("Creating customer...");
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Surname:");
            var surname = Console.ReadLine();

            var age = _inputHelper.GetIntFromConsole("Age: ");

            Console.WriteLine("City name:");
            var cityName = Console.ReadLine();

            return new Customer
            {
                Name = name,
                Surname = surname,
                Age = age,
                CityName = cityName
            };

        }
    }
}
