namespace W01 //pcakage, library, coverage ode and object location
{

    class Program
    {
        // starting or entry point method/function
        private static int avAlue = 1;

        //Canberk
        int a = 1+3;
        static void Main(string[] args)
        {
            int b = 1 + 3;
            Console.WriteLine("Hello World!!!");//printf in C


            #region Data Types

            #region Value Types/Primitive Types
            #region Predefined Types
            int a1 = 5;
            float f = 5.5f;
            double d1 = 6.5;
            bool b2 = false;
            char c1 = 'a';

            #endregion

            #region User Defined Types
            // structs and enum types
            // see example 1

            #endregion


            #region Pointer Types - not used so much 
            unsafe
            {
                int* p1 = &b;
            }

            #endregion


            #region Reference Types

            #region Predefined Types

            string name = "Canberk Ustaoglu";
            object anyData = new MyData();

            #endregion

            #region User Defined Types
            //classes and user defined everything
            //class Program{}=> user defined reference type
            // see example 2
            #endregion
        }

    }

    //Example 2
    class Student
    {
        private int no;
        private int name;

        void ShowName()
        {

        }
    }

    // User Defined Primitive types/value types

    struct MyData
    {
        int p1 = 1;
        //..
        double d1;


        public MyData()
        {
            //..
        }

    }
    enum DayNames
    {
        Monday,
        Tuesday, 
        Wednesday, 
        Friday,
        Sunday,
    }


}







// Tokens:
// 01- keywords
// 02- identifiers, must be obey the rules of variable definitions
// 03- symbols
// 04- operators
// 05- Literals
//      numerical
//      string