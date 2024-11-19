// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System; // like import of python

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new instance of this object
            Person obj = new Person();
            obj.name = "Marina";
            obj.age = 26;
            obj.message();
        }
    }
}