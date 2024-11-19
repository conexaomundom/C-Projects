using System;

class Person
{
    //attributs
    public string name = string.Empty;
    public int age;

    // methods
    public void message()
    {
        Console.WriteLine("Hello "+name+" you are "+age+" years old.");
    }

}