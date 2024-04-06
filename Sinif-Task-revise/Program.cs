using Sinif_Task_revise.Models;

namespace Sinif_Task_revise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an Employee instance
            Employee employee = new Employee(400.43m, 3, "Nazrin", "Aliyeva", 20);
            employee.GetInfo();

            //Create a Student innstance
            Student student = new Student("AzTU", 4, true, "Nazrin", "Aliyeva", 21);
            student.GetInfo();

        }
    }
}
