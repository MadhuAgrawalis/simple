﻿using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == FULL_TIME)
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
