using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace EmployeeDirectory
{
    class Person
    {
        public Person(string name, string title)
        {
            Name = name;
            Title = title;
        }

        public string Name { get; set; }

        public string Title { get; set; }

        public void Show()
        {
            Console.WriteLine("Name: {0} ------- Job Title: {1}", Name, Title);
        }
    }
}
