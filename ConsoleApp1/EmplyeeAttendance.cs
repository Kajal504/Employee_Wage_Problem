﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmplyeeAttendance
    {
        public static void EmployeeAttendance()
        {
            
            Random obj = new Random();
            int num = obj.Next(0, 2);
            if (num == 1)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
