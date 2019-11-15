using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Tasklist
{

    class Task
    {
        public static int Count = 0;

        public string description;

        public Task(string _description)
        {
            description = _description;
            Count++;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"/Users/katlinpaju/Demo/watertheplants";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            List<Task> taskList=new List<Task>();


            foreach (string line in lines)
            {
                //Create a task object at each line that we read from the file
                Task newTask= new Task(line);
                //add the object to the tasklist
                taskList.Add(newTask);
            }

            int i = 1;

            foreach (Task task in taskList)
            {
                Console.WriteLine($"Task {i} on your TODO list is to {task.description}");
                i++;
            }
            
            //get a task from User
            Console.WriteLine("Add a new task:");
            //save the task to the userTaskInput variable
            string userTaskInput = Console.ReadLine();
            //creating a new task class object with userTaskInput as a parameter
            Task userTask= new Task(userTaskInput);
            //save the userTask to the list 
            taskList.Add(userTask);
            
            Console.WriteLine("\n Updated task list.");
            foreach (Task task in taskList)
            {
                Console.WriteLine($"Task {i} on your TODO list is to {task.description}");
                i++;
            }
            
            //create a list of strings to write to the file
            List<string>outputToWriteToFile=new List<string>();

            foreach (Task task in taskList)
            {
                outputToWriteToFile.Add($"{task.description}");
            }
            
            Console.WriteLine("Writing to a file......");
            //write to outputToWriteToFile
            File.WriteAllLines(filePath,outputToWriteToFile);
            Console.WriteLine("Your task has been added ");

            Console.ReadLine();


            //Faili sisu mida ta peab maha lugema: walk the dog, water the plants, write some good code 
            
            //Teema- public string description 

        }
    }
}