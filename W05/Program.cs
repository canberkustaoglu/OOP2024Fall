//same assembly/inside assembly
namespace w05
{
    //...
    class Program//same assembly and different/other class
    {
        static void Main1(string[] args)
        {
            A a1 = new A();


            //public
            a1.x2 = 1; // is reachable
            a1.m2();   // is reachable

            //private
            // a1.x1 = 1;//err. is not reachable
            // a1.m1();//err. is not reachable

            //protected
            //a1.x3 = 1;//err. is not reachable
            //a1.m3();//err. is not reachable

            //internal
            a1.x4 = 1;// is reachable
            a1.m4();// is reachable

            //protected internal
            a1.x5 = 1;// is reachable
            a1.m5();// is reachable
        }
    }

    public class A
    {
        #region
        public int x2  = 1; //private keywords




        public A()
        {
            m1();//within class itself, it is reachable
        }

        #region 01-Public Members

        


        #endregion



        #region without keywords

        #endregion

        #region Private Members

        //void m1() //without keywords
        //{
        //    x1 = 5;//within class, it is reachable
        //}

        #endregion

        #endregion
    }


    class B : A //burada B subclass, A superclass oluyor demek oluyor
    {
        public B() 
        {
            //public members of A class are not reachable
            x1 = 1;
            m2(); 


            //private members of A class are not reachable
            //x1 = 1;//err
            //mb1(); //err
            //!!!private members cannot be reached derived class.

        }

        private int b1 = 1;
        private void mb1(int x)
        {

        }

    }





//Encapsulation
//01-public => can be seen everywhere
//02-private => can be seen only in classes
//03-protected => can be seen the members only inside of subclasses, used in derived classes
//04-internal => can only be seen in same assembly.
//05-protected internal => can only be seen in same assembly and in subclasses.

//without keywords => behave like private, sometime behave like internal

//classes,Interfaces, structs and enums may be internal, public and without keyword