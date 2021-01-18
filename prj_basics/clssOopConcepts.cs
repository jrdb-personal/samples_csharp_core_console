using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prj_basics_oop_concepts
{
    class SampleParentClass
    {
        public void showValue()
        {
            System.Console.WriteLine("Sample Value");
        }
    }

    class SampleChildClass : SampleParentClass
    {

    }

    interface IComputeSalary
    {
        decimal computeSalary();
    }

    interface ISetPromotion
    {
        string checkPromotion();
    }

    class Employee
    {
        public virtual string showTitle()
        {
            return "Sir/Ma'am";
        }
    }

    class Clerk : Employee, IComputeSalary, ISetPromotion
    {
        public decimal computeSalary()
        {
            return 100;
        }

        public string checkPromotion()
        {
            return "for promotion";
        }

        public override string showTitle()
        {
            return "Clerk";
        }
    }

    class Supervisor : Employee, IComputeSalary, ISetPromotion
    {
        public decimal computeSalary()
        {
            return 200;
        }

        public string checkPromotion()
        {
            return "not for promotion";
        }

        public override string showTitle()
        {
            return "Supervisor";
        }
    }




}
