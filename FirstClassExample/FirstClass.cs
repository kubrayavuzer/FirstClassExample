using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassExample
{
    public class Person
    {
        //properties
        public string name;
        public string surname;
        public string dateofbirth;

        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public string Dateofbirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                dateofbirth = value;
            }
        }

        //display information
        public void PrintInformation()     
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Date Of Birth: {dateofbirth}");
            Console.WriteLine();

        }
    }
}
