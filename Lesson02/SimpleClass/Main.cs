using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Properties
{
    static void Main()
    {
        
        Person p1 = new Person();
        p1.Name = "Jane";
        p1.Age = 20;

        Person p2 = new Person();
        p2.Name = "Betty";
        p2.Age = 30;

        Console.WriteLine(p1.Name + " is " + p1.Age + " years old");
        //Console.WriteLine("{0} is {1} years old", p1.Name, p1.Age);
        Console.WriteLine(p2.Name + " is " + p2.Age + " years old");

    }
}


/*
public class SimpleClass
{
    public void ShowInfo()
    {
        Console.WriteLine("This is a simple class");
    }
}

public class SimpleMethod
{
    static void Main()
    {
        SimpleClass cs = new SimpleClass();
        cs.ShowInfo();
    }
}
*/