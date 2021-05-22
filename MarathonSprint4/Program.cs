using System;

namespace MarathonSprint4
{
    class Person
    {
        public Company Company { get; set; }
    }
    class Company
    {
        public string CompName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Room<Rectangle> room = new Room<Rectangle>();
            //room.Floor = new Rectangle() { Width = 2, Length = 3 };

            //Room<Rectangle> room2 = new Room<Rectangle>();
            //room2.Floor = new Rectangle() { Width = 4, Length = 4 };

            //double r = room.Floor.Area();
            //double r2 =room2.Floor.Area();
            //Console.WriteLine(r);
            //Console.WriteLine(room.CompareTo(room2));
            //room.CompareTo(new Room<Trapezoid>() {Floor = new Trapezoid()});

            //Person person = new Person();
            //person.Company = new Company() { CompName = "234" };
            //Console.WriteLine(person.Company.CompName.CompareTo("234s"));
            Console.WriteLine( "end");

        }
    }
}
