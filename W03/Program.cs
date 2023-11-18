using System.Runtime.Intrinsics.Arm;

namespace W03
{
    #region For döngüleri
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Conditional statements
    //        //if

    //        int a = 2; int b = 3;

    //        if (a > b && a==2)
    //        {
    //            if (a == 2)
    //            {
    //                if (1 == b)
    //                {

    //                }
    //                //executed
    //            }
    //        }
    //        //otherwise
    //        else if(b<6) 
    //        { 
    //        //executed
    //        }
    //        //otherwise
    //        else
    //        {
    //            //executed
    //        }


    //        // we have another statement type named switch
    //        //switch
    //        int weekday = 7; // 1 <= ... <= 7

    //        switch(weekday)
    //        {
    //            case 1: Console.WriteLine("Monday"); break;
    //            case 2: Console.WriteLine("Tuesday"); break;
    //            case 3: Console.WriteLine("Wednesday"); break;
    //            case 4: Console.WriteLine("Thursday"); break;
    //            case 5: Console.WriteLine("Friday"); break;
    //            case 6: Console.WriteLine("Saturday"); break;
    //            case 7: Console.WriteLine("Sunday"); break;
    //            default: Console.WriteLine("Error"); break;
    //        }


    //        //conditional if
    //        int gender = 1;
    //        var res = (gender == 0) ? "Lady" : "Man";


    //        //loops/iterations/repetition

    //        for (int i = 0; i < 2; i++)
    //        {
    //            Console.WriteLine(i);
    //        }

    //        //while
    //        int ni = 1;
    //        while (ni <= 5)
    //        {
    //            //operations..


    //            // do not forget ++ yapmayı yoksa donguden cikamaz
    //            ni++;

    //        }


    //        //do while
    //        ni = 1;
    //        do
    //        {
    //            //operations
    //            //do not forget ++ yapmayı
    //            ni++;
    //        }while (ni <= 1);

    //        //foreach
    //        //int[] arr = { 1, 2, 3, 59, 65 };
    //        //foreach (var i in item in arr) //foreach uses iterators
    //        //{
    //        //    Console.WriteLine(item);
    //        //}

    //        //foreach ve for ile yapılan bu array okuma işini karşılaştırırsak, foreach ile yapılan daha makul oluyo

    //        //for (int i = 0;i < arr.Length;i++)
    //        //{
    //        //    Console.WriteLine(arr[i]);
    //        //}

    //        //go to loop
    //        int gt = 1;
    //        comeHereP1: //labeled loop
    //        Console.WriteLine(gt);
    //        gt++;

    //        if (gt<=5)
    //        {
    //            goto comeHereP1;
    //        }
    //        //for (int i = 1; i <= 5; i++)
    //        //{
    //        //    Console.WriteLine(i);
    //        //}

    //        //recursive functions as a loop

    //        Console.WriteLine(Sum((10)));

    //        int n = 10;
    //        int sum = 0;
    //        for (int i = 1; i <= n; i++)
    //        {
    //            sum += i;
    //            //this function and Sum recursive func produces exactly the same result 
    //            //for ile çalışmak böyle bir recursive functiona göre daha recommended bir durum. fonksiyon fonksiyon içinde biraz sakat
    //        }

    //        //infinite loops
    //        //for(; ; )
    //        //{
    //        //    Console.WriteLine("infinite times, will be executed. be careful while using it");
    //        //}

    //        //while (true)
    //        //{
    //        //    Console.WriteLine("infinite times, will be executed. be careful while using it");
    //        //}


    //    }

    //    static int Sum(int n) //1+2+3+..+n = ?...
    //    {
    //        if (n == 1)
    //            return 1;// if you removef (n == 1) return 1;  , this function will be infinite loop

    //        return  n + Sum(n-1);

    //    }

    //}

    #endregion

    #region String
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //int a = 5; //value type / mutable (yani changeable)
    //a = 6;

    //Object b = 1;//reference type / mutable
    //b = "Canbo";

    //string c = "Canberk"; //reference type / Immutable yani not changeable
    //c = "deneme"; //stack heap yapısı üzerinden düşümürsek, bir önceki tutulan değer heap üzerinden removed from memory via Garbage Collector ve yeni değer artık tutuluyor. Immutable işi aslında böyle denebilir.

    ////Console.WriteLine(a);
    ////Console.WriteLine(b);
    ////Console.WriteLine(c);

    ////string interpolation
    //var v = a + " : " + b + c;
    //Console.WriteLine(v);

    //v = $"{a} : {b}{c}"; //interpolator $
    //Console.WriteLine(v);


    //    }
    //}
    #endregion

    #region Method Definition

    class Program
    {
        static void Main(string[] args) 
        {
            //Method1(); //err
            //Method1(5); //err
            Method1(5, 6); //must be provided its parameters

            //Method2(); //err
            Method2(5); //one is mandatory other is optional 
            Method2(5, 6);

            Method3();//optional
            Method3(5);//optional
            Method3(5, 6); //optional
        }


        //parameters 
        //mandatory params  
        static void Method1(int x, int y) 
        {
            //do some jobs
        }

        //optional params
        static void Method2(int x, int y=0)
        {
            //do some jobs
        }

        //optional params
        static void Method3(int x = 0, int y = 0)
        {
            //do some jobs
        }

        //hybrid params
        static void Method3(int x = 0, int y)
        {
            //do some jobs
        }



        //Methods with their signature
        //01-void void (void means there is no any type) => no return type and no params
        static void M1()
        {
            // do operations here
            // no need a return keyword.
        }
        
        //

    }

    //02- void params => no return type and with params
    static void M2(int a, string b, bool c)
    {
        // do operations here
        // no need a return keyword.
    }

    //03-type void => has return type and without params
    static int M3()
    {
        // do operations here
        // must have a return keyword.
        return 1 + 6;
    }
    //03-type type => has return type and with params
    static int M4(int a, int b)
    {
        // do operations here
        // must have a return keyword.
        return 1 + 6;
    }




    #endregion

};