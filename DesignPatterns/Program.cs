using DesignPatterns.VisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        public static void Main(string[] args)
        {
            TestSimpleVisitor();
        }

        public static void TestSimpleVisitor()
        {
            var director = new Director("Gosho", 3500, 19);
            var increaseSallary = new IncreaseIncomeVisitor();
            director.Accept(increaseSallary);
        }
    }
}
