using System;

namespace Docconstructer
{
    //Dog constructer ehk konstruktori näidis
    //Staticut kasutad klassi puhul

    class Animal
    {
        public static int Count = 0;
        
        public string name;
        public string color;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
        }
    }

    class Dog:Animal
    {
        public string breed;

        public Dog(string _name,string _color, string _breed)
        {
            name = _name;
            color = _color;
            breed = _breed;
            
            Count++;
        }

        public void PrintInfoAboutDog()
        {
            Console.WriteLine($"Dog's name: {name}");
            Console.WriteLine($"Dog's color: {color}");
            Console.WriteLine($"Dog's breed: {breed}");
            
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Dog rex=new Dog("Rex","blue and black","bulldog");
            rex.PrintInfoAboutDog();
            
            Console.WriteLine($"{Animal.Count} animal have/has been created");
            
            Console.ReadLine();
        }
    }
}