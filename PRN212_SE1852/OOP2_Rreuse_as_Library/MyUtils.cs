using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Rreuse_as_Library
{
    public static class MyUtils
    {
        public static int TinhTuoi(this Employee employee)
        {
            if (employee == null)
            {
                return 0;
            }
            else
            {
                DateTime today = DateTime.Now;
                int age = today.Year - employee.Birthday.Year;
                if (today.Month < employee.Birthday.Month || (today.Month == employee.Birthday.Month && today.Day < employee.Birthday.Day))
                {
                    age--;
                }
                return age;
            }
        }
    }
}
