using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Attriubte
{
    public class CreatePromptAttribute : Attribute
    {
        public string Prompt { get; private set; }

        public CreatePromptAttribute(string prompt)
        {
            Prompt = prompt;
        }
    }
}
