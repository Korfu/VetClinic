using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Attriubte
{
    public class ExampleAttribute : Attribute
    {
        public string ExampleText { get; set; }

        public ExampleAttribute(string exampleText)
        {
            ExampleText = exampleText;
        }

    }
}
