using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.VisitorPattern
{
    public class Simple
    {

    }

    public interface IVistor
    {
        void Visit(Employee employee);
    }

    public class IncreaseIncomeVisitor : IVistor
    {
        public void Visit(Employee employee)
        {
            employee.Income *= 1.10;

            Console.WriteLine("{0} {1}'s new income: {2:C}",
                employee.GetType().Name, employee.Name,
                employee.Income);
        }
    }

    public class VacationVisitor : IVistor
    {
        public void Visit(Employee employee)
        {
            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}",
              employee.GetType().Name, employee.Name,
              employee.VacationDays);
        }
    }

    public abstract class Employee
    {
        public string Name { get; set; }
        public double Income { get; set; }
        public int VacationDays { get; set; }

        public Employee(string name, double income, int vacationDays)
        {
            Name = name;
            Income = income;
            VacationDays = vacationDays;
        }

        public virtual void Accept(IVistor visitor)
        {
            visitor.Visit(this);
        }
    }


}
