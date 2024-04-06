using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinif_Task_revise.Models
{
    internal class Student : Person
    {
        private string _uniName;
        private int _course;
        private bool _isGraduated;

        public string UniName
        {
            get { return _uniName; }
            set { _uniName = value; }
        }
        public int Course
        {
            get { return _course; }
            set
            {
                if (value > 0 && value < 5)
                {
                    _course = value;
                    if (_course == 4)
                    {
                        _isGraduated = true;
                    }
                    else
                    {
                        _isGraduated = false;
                    }
                }
            }
        }
        public bool IsGraduated { get => _isGraduated; }
        public Student(string uniname, int course, bool isGraduated, string name, string surname, int age) : base(name, surname, age) 
        {
            _uniName = uniname;
            _course = course;
        }

        public override void GetInfo()
        {
            Console.WriteLine($" Student: {Name} {Surname}, Age: {Age}, University: {UniName}, Course: {Course}, Graduated: {IsGraduated}");
        }
    }
}
