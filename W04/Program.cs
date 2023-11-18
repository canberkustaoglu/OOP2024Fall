namespace W04
{

    class Program
    {
        static void Main(string[] args)
        {
            //datatype objectName/object/instance/ = objectCreatorKeyword dataType( ()=defaultConstructorMethod/object reator method )   
            Person person1 = new Person(); //default call
            //class object = createNew class(creatorMehod);



            //person.name = "Canberk";
            //Console.WriteLine(person.getName());
            //person.age = 22;

            //person.Age = 12;//setter
            //Console.WriteLine(person.Age);//getter

            ////method member call
            //person.IntroduceYourself();

            Person person2 = new Person("muhallebi"); //overloaded call

            Person person3 = new Person("Ayşe", "Turunç");//overloaded call

            Person person4 = new Person("Mehmet", "Yılmaz",25);

            person4["name"] = "Fatma";//setter

            Console.WriteLine(person4["name"]);//getter

            Console.WriteLine(person.count);
        }


        //class is definition of any real world object/entity


        //compound definition/coupled definition/inner class hepsini bu class için diyebilirsin peki neden?
        //çünkü class Program içine yazdık bu class Human sınıfını.
        //not frequently used.
        //class Human
        //{

        //}
    }

    //class is definition of any real world object/entity
    class Human
    {

    }



};
