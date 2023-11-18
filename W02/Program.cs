
namespace W02
{
    //0-Scope Level overall assembly scope
    //can be defined classes, Interfaces, enums, Structs
    //cannot be defined variables,methods of any kind
    //int a =; /mesela impossible


    #region Part 1

    //class Program
    //{
    //    //1-Global Scope
    //    //can be defined inner classes, methods, variables

    //    //class MyClass { } /mesela this usage not recommended.


    //    readonly int _count = 1; //almost similar with const but it may be changed only one time

    //    public Program()
    //    {
    //        _count = 15;
    //        //_count = 16; it is impossible because readonly can be assigned once.
    //    }
    //    static void Main(string[] args /*formal scope*//*, int vb*/)
    //    {
    //        //2-Local Scope-Level
    //        //cannot be defined class, Interfaces, enums, structs
    //        //any kind of variable, but not recommended, we uses especially here, the methods as lambda functions/anonymous methods
    //        // SCOPE IS A KIND OF ENCAPSULATE THINGS 

    //        void a12(int x)
    //        {

    //        }


    //        var test = new Program();

    //        //variable definition
    //        // standard(strongly type) variable definition /evaluated in compile/interpration time
    //        int a = 5;
    //        //a="Canberk";//impossible, because a is not dynamic
    //        string name = "Canberk";
    //        bool b = false;

    //        //definiton of var keyword
    //        var a1 = 1;
    //        //a1 = "Canberk"; //impossible, because a is not dynamic
    //        //string name name2 = "Canberk";
    //        bool b1 = false;

    //        //definition of var keyword /evaluated in compile/interpration time
    //        var a1 = 1;
    //        var name2 = "Canberk";
    //        var b1 = true;

    //        //dynamic keyword(javascript, pythn and some other langs are fully dynamic lang.)
    //        //C# is not dynamic programming language but supports dynamic object definition

    //        dynamic a3 = 1;//evaluated in runtime
    //        a3 = "Canberk";

    //        //constant keyword
    //        const int ac = 1;
    //        //ac = 3; //cannot be changed, cannot be null


    //        //overflow
    //        // left size (bytes) >= right size(bytes)

    //        //int all = 12345676543565435654324532; /it gives simple overflow error

    //        //global scope
    //        {
    //            {
    //                //scopes can be created by curling braces kaç tane istersen o kadar curling braces açabilirsin tutan yok aga
    //            }
    //        }

    //        //comments
    //        /*bool bl = false;
    //        int cl = 1;*/
    //        // you can use single line comment // like that or multi line (block) comment /**/


    //    }
    //}
    #endregion

    #region Part 2

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /*
    //        //input and output operation
    //        int a= Convert.ToInt32(Console.ReadLine()); //scanf in C
    //        Console.WriteLine(a*a);   //printf in C
    //        */

    //        //implicit type conversion
    //        int a = 1234123565;
    //        double b = a;

    //        long c = a;

    //        // a = c; //long int e dönüşmez aga error verir yaparsan


    //        //explicit type conversion

    //        //cast operations
    //        a = (int)c; // we may get overflow problem
    //        Console.WriteLine(a);



    //        //operators
    //        //02-aritmetic operators
    //        var res = 1 + 5 * 9 + 1.5 / 2;

    //        //01-relational <, <=, >, >=, ==, !=
    //        //relational operators produces boolean results. true or false.
    //        var ro = 1 < 2;
    //        ro = 3 >= 5;
    //        ro = 1 == 1;
    //        ro = 1 != 3;

    //        //03-logical &&, ||, !
    //        //logical operators produces boolean results. true or false.
    //        ro = !((1 == 1) && (1 < 3) || (5 >= 100));

    //        //04-bitwise &, |, ~
    //        // not used frequently


    //        //05-assignment operator =, +=, -=, *=, /=, %=
    //        //not used frequently

    //        res = 2;
    //        res += 2; //res = res+2;
    //        res -= 2; //res = res-2;
    //        res *= 2; //res = res*2;
    //        res /= 2; //res = res/2;


    //        //06-Unary Operators ++, --, !
    //        ++res;
    //        res++;
    //        --res;
    //        res--;
    //        !res;

    //        bool bl = !false; //--> true

    //        //07-Binary Operations operand op operand2 --> 1+2
    //        //unary ops unary operand op, op operand1 --> ++res, res++, !bl


    //        //08-termary op : conditional if

    //        var ahmetIsGood = true;

    //        /*if (ahmetIsGood) 
    //        {
    //            Console.WriteLine("Ahmet is good")
    //        }
    //        else 
    //        {
    //            Console.WriteLine("Ahmet is not good")
    //        }*/
    //        // veya aynısını aşağıdaki satır gibi yazabiliriz
    //        //var resText:string = (ahmetIsGood == true) ? "Ahmet is good": "Ahmet is not good";    
    //        //Console.WriteLine(resText);

    //        //var res2 = 1 == 2 ? true: false;
    //        //var res2 = 1 == 2 ? -1 : 0;




    //    }
    //}
    #endregion


    #region Part3

    class Program
    {
        static void Main(string[] args)
        {
            var a = 45;

            Console.WriteLine(sizeof(int));

            Type t = typeof(int);

            Console.WriteLine(t == typeof(int));


            //arrays/ reference types
            char[] name = { 'c', 'a', 'n', 'b', 'e', 'r', 'k' }; //reference type

            Console.WriteLine(name);

            string name2 = "Canberk"; //reference type

            Console.WriteLine(name);
            Console.WriteLine(name2);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[,] numbers2 = { { 1, 2, 3, 4, 5, 6 }, { 1, 2, 3, 4, 5, 6 } };
            int[,,] numbers3 = new int[2, 2, 2];
            numbers3[0, 0, 0] = 3;

            Program[] objectList = new Program[3];
            objectList[0] = new Program();

            //null types

            //as a default values types cannot be null
            //int b = null; //burada error veriyo bak
            //but we can make them nullable with a special operator
            int? c = null;


            //but ref types can be null
            int[] list = null;

            // string is ref type and ca be null 
            string name3 = null;

            //any class type can be null 
            Program p = null;

            //Default or initial values
            int x;
            //Console.WriteLine(x); //error verir

            string name4;
            //Console.WriteLine(name4); //eror verir

        }
    }


    #endregion
}