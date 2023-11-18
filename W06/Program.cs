using W06.AnimalOperations.Abstract;
using W06.AnimalOperations.Concrete;
using W06.Business;
using W06.Logging.Abstract;
using W06.Logging.Concrete;
using W06.SecurityOperations.Concrete;

namespace W06
{

    /*
 * Abstraction: The IAnimal interface provides an abstract layer. The zoo system doesn't need to know the details of how each animal eats or sleeps, just that they can perform these actions.
 * Interchangeability: Since both Lion and Elephant implement IAnimal, they can be used interchangeably wherever an IAnimal is expected.
 * Extensibility: It’s easy to introduce new animals to the system. As long as the new animal class implements IAnimal, it can be integrated seamlessly.
 * Testability: Interfaces make it easier to unit test your code as you can mock interface implementations.
 * Loose Coupling: Interfaces help in reducing the coupling between different parts of the application.
 *
 */
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //IAnimal animal1 = new IAnimal();//err: /interfaces cannot be created as an object
            //interfaces are not classes and you get an error because WE CANNOT CREATE AN ONJECT FROM INTERFACE


            IAnimal animal1 = new Lion();//it is okay. it is a kind of polymorphism

            EducateAnimal(new Lion());
            EducateAnimal(new Elephant());
            EducateAnimal(new Mouse());
            */

            /*
            //injection of dependency
            SecurityService securityService1 = new SecurityService(new AdvancedUserService());
            //SecurityService securityService2 = new SecurityService(new BasicSecurityService());

            securityService1.Login("Aydın", "123");


            ILogger logger = new DatabaseLogger();
            ILogger logger1 = new FileLogger();
            logger1.LogWrite("error occured during insert op...");


            LoggerService ls = new LoggerService(new FileLogger());


            ls.LogInfo("asd");


            ls.LogWrite("ssdf");
            */



        }


        //static void EducateLion(Lion l)
        //{
        //    l.Eat();
        //    l.MakeSound();
        //    l.Sleep();
        //}
        //static void EducateElephant(Elephant e)
        //{
        //    e.Eat();
        //    e.MakeSound();
        //    e.Sleep();
        //}
        //static void EducateMouse(Mouse m)
        //{
        //    m.Eat();
        //    m.MakeSound();
        //    m.Sleep();
        //}
        //BU KADAR TRİBE GİRMEYE GEREK YOK BAK NASIL BASİTÇE YAPILIYO GÖSTERELİM


        //çok temiz güzel halledildi gördüğün üzere. this is one of the benefit of interface usage
        static void EducateAnimal(IAnimal animal)
        {
            animal.Eat();
            animal.MakeSound();
            animal.Sleep();
        }


    }

    //Without interfaces, abstraction would be very weak 
};