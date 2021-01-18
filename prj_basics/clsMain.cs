using System;
using prj_basics_type_samples;


namespace prj_basics
{
    class clsMain
    {
        public static int Main(string[] args)
        {

            //sample types
            ProgramType pTypes = new ProgramType();
            pTypes.showVariableType(5, 255, 5000000);
            pTypes.showResultType();

            //sample struct
            SampleStruct ss = new SampleStruct(5);
            ss.Super();


            //sample enumeration
            SampleEnum se = SampleEnum.Item1;
            Console.WriteLine("The enum value is {0}", se);

            //sample reference
            SampleReference sr1 = new SampleReference(100);
            SampleReference sr2;

            Console.WriteLine("First reference is {0}", sr1.initVal);
            sr2 = sr1;
            sr2.initVal = 200;
            Console.WriteLine("Second reference is {0}", sr2.initVal);
            Console.WriteLine("First reference is {0}", sr1.initVal);

            //sample string
            string str1 = "String 1";
            string str2;

            Console.WriteLine("str1 is {0}", str1);

            str2 = str1;
            str1 = "String 2";

            Console.WriteLine("str2 is {0}", str2);
            Console.WriteLine("str1 is {0}", str1);

            //sample array

            string[,] mda =
            {
                {"Allen", "10"},
                {"Emily", "8"},
                {"Johnny", "7"},
                {"Marian", "9"}
            };

            Console.WriteLine("mda first element is {0}, {1}", mda[0, 0], mda[0, 1]);
            Console.WriteLine("mda third element is {0}, {1}", mda[2, 0], mda[2, 1]);

            string[][] activities =
            {
                new string [] {"piano", "basketball", "drawing"},
                new string [] {"piano", "singing"},
                new string [] {"basketball", "football", "swimming"},
                new string [] {"chess"}

            };

            Console.WriteLine("activies first element: {0}, {1}, {2},", activities[0][0], activities[0][1], activities[0][2]);

            return 0;
        }
    }




   

}



