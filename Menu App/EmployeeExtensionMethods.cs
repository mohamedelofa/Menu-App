using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menu_Class_Library;

namespace Menu_App
{
    static class  EmployeeExtensionMethods
    {
        public static void Display(this Employee[] employees)
        {
            foreach(var employee in employees)
            {
                employee.Display();
            }
        }
    }
}
