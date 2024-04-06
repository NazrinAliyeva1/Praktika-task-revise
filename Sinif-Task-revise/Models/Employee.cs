using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Task_revise.Models
{
    internal class Employee:Person
    {
        decimal _salary;
        private double _experience;

        public override int Age
        {
            get { return base.Age; }
            set
            {
                if(value >= 18 && value<65)
                {
                    base.Age = value;
                }
            }
        }
        public decimal Salary
        {
            get { return _salary; }
            set 
            {  
                if (value >= 350)
                    _salary = value;
            }
        }
        public double Experience
        {
            get { return _experience; }
            set
            { 
                if (value >= 0)
                    value = _experience;
            }
        }
        public Employee(decimal salary, int experience, string name, string surname, int age) : base(name, surname, age) 
        {
            _salary = salary;
            _experience = experience;

        }
        public override void GetInfo()
        {
            Console.WriteLine($"Employee : {Name} {Surname} , Age: {Age}, Salary: {Salary}, Experience: {Experience}");
        }


    }
}
