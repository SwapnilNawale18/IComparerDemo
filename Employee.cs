using System;
using System.Collections.Generic;

namespace IComparerDemo
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return this.Name + "\t" + this.Salary.ToString();
        }
    }
}