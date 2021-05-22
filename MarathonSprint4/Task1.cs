//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MarathonSprint4
//{
//    interface ISwimmable
//    {
//        void Swim() => Console.WriteLine("I can swim!");
//    }
//    interface IFlyable
//    {
//        int MaxHeight { get => 0; }
//        void Fly() => Console.WriteLine($"I can fly at {MaxHeight} meters height!");
//    }
//    interface IRunnable
//    {
//        int MaxSpeed { get => 0; }
//        void Run() => Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
//    }
//    interface IAnimal
//    {
//        int LifeDuration { get => 0; }
//        void Voice() => Console.WriteLine("No voice!");

//        void ShowInfo()
//            => Console.WriteLine($"I am a {this.GetType()} and I live approximately {LifeDuration} years.");

//    }
//    class Cat :IAnimal, IRunnable
//    {
//        public int LifeDuration { get; set; }
//        public int MaxSpeed { get; set; }
//        public void Voice() => Console.WriteLine("Meow!");
//    }
//    class Eagle :IAnimal, IFlyable
//    {
//        public int LifeDuration { get; set; }
//        public int MaxHeight { get; set; }
//    }
//    class Shark :IAnimal, ISwimmable
//    {
//        public int LifeDuration { get; set; }
//    }


//}
