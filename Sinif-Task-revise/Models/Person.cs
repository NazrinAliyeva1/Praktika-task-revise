using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Task_revise.Models
{
    internal abstract class Person
    {
        string _name;
        string _surname;
        int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
           
            set{_surname = value; }
        }
        public virtual int Age
        {
            get { return _age; }
            set
            {
                if(value > 0 && value < 200)
                {
                    _age = value;
                }
            }
        }

        public Person ( string name, string surname, int age)
        {
            Name = _name;
            Surname = _surname;
            Age = _age;
            Console.WriteLine("Person ctor ise dushdu");
        }

        public abstract void GetInfo();
    }
}
