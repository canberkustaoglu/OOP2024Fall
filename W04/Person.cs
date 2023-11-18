using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04
{
    //classes are definition of real world object.
    //classes are not object, they are definition of objects.
    class Person
    {

        #region Members


        #endregion
        #region A-Static Members

        //...
        public int count=0;

        #endregion


        #region B-Instance Members

        //01-Field members: Variables, Data//recommended to be defined private
        private string _name;
        private string _lastName;
        private int _age;

        //02-Property Members: can be thought as a method or field
        //02.01-java style getter and setters
        //void void setName(string name)
        //{
        //    this._name = name;

        //}

        //void void getName(string name)
        //{
        //    return this._name;

        //}
        ////02.02c# long style getter and setters
        //public void Name
        //{
        //    get
        //    {
        //        return _lastName;
        //    }
        //    set
        //    {
        //        this._lastName = value;
        //    }
        //}
        //02.03.c3 simple style getter and setters
        public int Age { get; set; }


        //03. Method Members
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello, I'm {_name} and I'm {Age} years old.");
        }

        private int CalculateBirthYear()
        {
            return DateTime.Now.Year - Age;
        }

        //04- Constructor Method Members
        public Person()
        {
            //we can do here some extra modification...
            // _lastName = "No data";
        }

        //overloaded constructor 1 
        public Person(string name) //default constructor
        {
            _name = name;
            //we can do here some extra modification
            // _lastName = "No data";
        }

        //overloaded constructor 2
        public Person(string name, string lastName) //default constructor
        {
            _name = name;
            _lastName = lastName;
            //we can do here some extra modification
            // _lastName = "No data";
        }
        //overloaded constructor 3
        public Person(string name, string lastName, int age) //default constructor
        {
            _name = name;
            _lastName = lastName;
            _age = age;
            //we can do here some extra modification
            // _lastName = "No data";
        }


        //05-Indexer Method Members
        public dynamic this[string param]
        {
            get
            {
                if (param == "name")
                {
                    return _name;
                }
                else if (param == "lastName")
                {
                    return _lastName;
                }
                else if (param == "age")
                {
                    return _age;
                }
                else
                {
                    throw new Exception("Wrong Param...");
                }
            }
            set
            {
                if (param == "name")
                {
                    _name = value;
                }
                else if (param == "lastName")
                {
                    _lastName = value;
                }
                else if (param == "age")
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Wrong Param...");
                }
            }
        }



        //06-Destructor Methods
        ~Person()
        {
            //when deleting object from the memory you can do some extra ops here...
        }

        #endregion

    #endregion

    }
}
