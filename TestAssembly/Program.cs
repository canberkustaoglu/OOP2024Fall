using W05; //bunu ver ki W05 içindeki class A ya erişebilsin. reference veriyosun yani

//outside/different assembly
namespace TestAssembly
{
    class Program
    {
        static void Main(string[] args)
        {

            A a1 = new A(); //error veriyo köpek gibi. niye? W05teki class A public değil ki erişemiyom diyo

            //a1.x1 = 1; //err. x1 is not reachable
            //a1.m1();//err. m1() is not reachable

        }
    }

    class C : A
    {
        public C() 
        {
            //x1 = 1;//err
            //mb1();//err
        }

        private int c1 = 1;
        private void mc1(int x)
        {

        }


    }


};

//A PRIVATE MEMBER ONLY AND ONLY CAN BE REACHED INSIDE ITS ORIGINAL CLASS!!!
// THERE IS NO LIMITATION FOR PUBLIC MEMBERS. EVERYBODY CAN SEE PUBLIC MEMBERS EVERYWHERE