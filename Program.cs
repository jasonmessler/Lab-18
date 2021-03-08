using System;

namespace Lab_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var list = new List(10);

            list.Insert("Bart");
            list.Insert("Milhouse");
            list.Insert("Martin");
            list.Insert("Sherry");
            list.Insert("Wendell");
            list.Insert("Louis");
            list.Insert("Terry");
                                            
           // remove at - comment/uncomment to test
            list.RemoveAt(2);

            Object myObj = new Object();
            myObj = "Nelson";
           
            // insert at - comment/uncomment to test
            list.InsertAt(3, myObj);

            // insert at out of range - comment/uncomment to test
           list.InsertAt(11, myObj);

            list.PrintReverse();

            Console.ReadLine();
        }
    }
}
