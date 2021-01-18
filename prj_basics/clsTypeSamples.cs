using System;
using System.Collections.Generic;
using System.Text;

namespace prj_basics_type_samples
{
    class ProgramType
    {

        public void showVariableType(int a, byte b, long c)
        {
            System.Console.WriteLine("a is {0}, To String returns {1}, Type is {2}", a, a.ToString(), a.GetType());
            System.Console.WriteLine("b is {0}, To String returns {1}, Type is {2}", b, b.ToString(), b.GetType());
            System.Console.WriteLine("c is {0}, To String returns {1}, Type is {2}", c, c.ToString(), c.GetType());
        }

        public void showResultType()
        {
            double d;
            d = Math.Pow(2, 100);
            Console.WriteLine("d is {0}, Type is {1}", d, d.GetType());
            bool b;
            b = true;
            Console.WriteLine("b is {0}, Type is {1}", b, b.GetType());
        }
    }


    struct SampleStruct
    {
        int m_int;
        public SampleStruct(int value)
        {
            m_int = value;
        }

        public void Super()
        {
            Console.WriteLine("SampleStruct type current value is {0}", m_int);
        }
    }

    enum SampleEnum
    {
        Item1,
        Item2,
        Item3,
        Item4
    }

    class SampleReference
    {
        public int initVal;

        public SampleReference(int value)
        {
            initVal = value;
        }
    }
}
