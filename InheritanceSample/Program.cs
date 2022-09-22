//Inheritance the tendency of a class to access the properties of another class

//The class being accessed is called the base class or the superclass or parent class

//And the one accessing is called children class

using System;

namespace InheritanceSample
{

    class Vehicle
    {
        public string brand = "Ford";

        public void honk()
        {
            Console.WriteLine("Tuutu Taata");
        }
    }

    //class Car inherited Vehicle class
    class Car : Vehicle
    {
        public string modleName = "Murshag";


    }

    class Program
    {
        static void Main(string[] args)
        {
            Car v = new Car();

            v.honk();

            Console.WriteLine(v.modleName + " " + v.brand); 

        }
    }
}