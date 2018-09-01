using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
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


public class Addition
{
    public int AddTwoValues(int x, int y)
    {
        return x + y;
    }

    public int AddThreeValues(int x, int y, int z)
    {
        return x + y + z;
    }
}

public class MethodParameters
{
    static void Main()
    {
        Addition a = new Addition();
        int x = a.AddTwoValues(12, 8);
        int y = a.AddThreeValues(12, 8, 5);
        Console.WriteLine(x + "\n" + y);

    }
}


public class Circle
{
    private int radius;

    public int Radius
    {
        set
        {
            radius = value;
        }
    }

    public double Area()
    {
        return this.radius * this.radius / Math.PI;
    }
}

public class Methods
{
    static void Main()
    {
        Circle c = new Circle();
        c.Radius = 5;

        Console.WriteLine(c.Area());
    }
}


public class Sum
{
    public int GetSum(int x , int y)
    {
        return x + y;
    }

    public int GetSum(int x, int y, int z)
    {
        return x + y + z;
    }
}

public class OverLoading
{
    static void Main()
    {
        Sum s = new Sum();

        Console.WriteLine(s.GetSum(20, 30));
        Console.WriteLine(s.GetSum(20, 30, 40));
    }
}



public class Multiplication
{
    public int GetMultiplication(int x, int y)
    {
        return x * y;
    }

    public double GetMultiplication(double x, double y)
    {
        return x * y;
    }
}

public class OverloadingWithAnEqualNumberOfParmeters
{
    static void Main()
    {
        Multiplication m = new Multiplication();
        int a = 3;
        int b = 4;
        double c = 3.2;
        double d = 1.5;

        Console.WriteLine(m.GetMultiplication(a, b));
        Console.WriteLine(m.GetMultiplication(c, d));
    }
}


public class MyFriend
{
    private DateTime born;
    private string name;
    
    public MyFriend (String name, DateTime born)
    {
        this.name = name;
        this.born = born;
    }

public void Info()
    {
        Console.WriteLine("{0} was born on {1}", this.name, this.born.ToLongDateString());
    }
}
public class constructor
    {
    static void Main()
    {
        string name = "Simon";
        DateTime born = new DateTime(1990, 2, 1);
        MyFriend friend = new MyFriend(name, born);
        friend.Info();
    }
}
*/

class Car
{
    public string Name { get; set; }
    public string Color { get; set; }
    public CarManufacturer Manufacturer { get; set; }
}

public class CarManufacturer
{
    public string Name { get; set; }
    public string Country { get; set; }
}

public class main
{
    static void Main()
    {
        /*
        Car car = new Car();
        car.Name = "Corvette";
        car.Color = "Yellow";
        car.Manufacturer = new CarManufacturer();
        car.Manufacturer.Name = "Chevrolet";
        car.Manufacturer.Country = "USA";
        */

        Car car = new Car
        {
            Name = "Chevrolet Corvette",
            Color = "Yellow",
            Manufacturer = new CarManufacturer
            {
                Name = "Chevrolet",
                Country = "USA"
            }
        };

    }
}