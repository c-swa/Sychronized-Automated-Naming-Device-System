using System;

namespace NameGenerator
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Thank you for using my name generator application!\n");
            Console.WriteLine("Feel free to modify the source code in any way, and to make" +
                " the name generator customized to fit your own themes or choices.");

            Device MacBookPro = new Device("MacBook Pro", "laptop", Core.i5, 2015, 8);
            Generator generator = new Generator();
            

            Console.WriteLine(generator.createName(MacBookPro));
            Console.ReadKey();
        }
    }
}
