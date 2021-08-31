using System;
using System.Collections.Generic;

namespace IComparerDemo
{
    internal class Employee : IComparer<Employee>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public int Compare(Employee x, Employee y)
        {
            return y.Salary - x.Salary;
        }
        public override string ToString()
        {
            //return base.ToString();
            return this.Name + "\t" + this.Salary.ToString();
        }
    }
}