using System;

namespace Constructorsandenums
{
    //kordamine eelmisest tunnist 
    
    class Animal
    {
        public string name;
        public int age;
        public int levelOfHappiness;

        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
        
    }

    class Dog : Animal
    {
        public int numberOfBarks = 0;
        
        public void WaveTail()
        {
            levelOfHappiness++;
        }

        public void Bark()
        {
            Console.WriteLine("Wuf!!");
            numberOfBarks++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Koer
            Dog muki=new Dog();
            muki.name = "Muki";
            muki.age = 3;
            muki.levelOfHappiness = 0;

            for (int i = 0; i < 12; i++)
            {
                muki.WaveTail();
                
                if (muki.levelOfHappiness%3== 0)
                {
                    muki.Bark();
                }
                
            }
            
            muki.PrintBasicInfo();
            Console.WriteLine($"The dog {muki.name} has barked {muki.numberOfBarks} times.");
            

        }
    }
}