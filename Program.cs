using System;

namespace Human2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Bobby = new Human ("Bobby");//creating a new instance of Human Class 
            Console.WriteLine(Bobby.Health); //the get accessor is invoked here
            Console.WriteLine("Bobby's health is " + Bobby.Health);//testing 
            Console.WriteLine(Bobby.Attack());//invoking the attack unction
            
        }
    }
}
