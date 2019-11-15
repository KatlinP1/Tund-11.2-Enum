using System;

namespace DogBreedEnum
{
    enum Breed
    {
        Bulldog,
        Boxer,
        Chihuahua
        
    }
    
    class Dog
    {
        public static int Count = 0;
        
        public string name;
        public int age;
        public Breed dogBreed;

        public Dog(string _name, int _age, Breed _breed)
        {
            name = _name;
            age = _age;
            dogBreed = _breed;
            
            Count++;
        }

        public void PrintDogInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Breed: {dogBreed}");
            
        }
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Dog sass=new Dog("Sass",10,Breed.Chihuahua);
            sass.PrintDogInfo();
            
            Dog muki=new Dog("Muki",5,Breed.Boxer);
            muki.PrintDogInfo();
            
            Console.WriteLine($"{Dog.Count} animal have/has been created");
            
            //Kui ma tahan teada mis numbriga see tõug on-casting
            Console.WriteLine((int)Breed.Boxer);
            
            
            Console.ReadLine();
            
        }
    }
}