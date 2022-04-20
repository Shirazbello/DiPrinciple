using System;

namespace DiPrinciple
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Inversion Principle-- Injection");

            //Constructor Passage
            Project project = new Project(new BackEndDeveloper());
            project.callDeveloper();
            //Property Passage
            project.Developer = new FrontEndDeveloper();
            project.callDeveloper();
            //Method Passage
            project.createDeveloper(new BackEndDeveloper());
            project.callDeveloper();
        }
    }
}
