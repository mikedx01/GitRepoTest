using System;

namespace GitRepoTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            TestClass c = new TestClass();
            c.x = 20;
            c.y = 21;

            Console.WriteLine(c.x + c.y);
            Console.ReadLine();
        }
    }
}
