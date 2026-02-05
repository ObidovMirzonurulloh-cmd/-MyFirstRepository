/*using System;

namespace FirstApp
{
    class Human
    {
        // Поля класса
        public string name;
        public int age;

        // Метод класса
        public void Greetings()
        {
            Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
        }
    }

  struct Animal
    {
        // Поля структуры
        public string type;
        public string name;
        public int age;

        // Метод структуры
        public void Info()
        {
            Console.WriteLine("Это {0} по кличке {1}, ему {2}", type, name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human.name = "Дмитрий";
            human.age = 23;
            human.Greetings();


            Console.ReadKey();
        }
    }
}*/



/*using System;

class Human
{
    // Поля класса
    public string name;
    public int age;

    // Метод класса
    public void Greetings()
    {
        Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
    }

    // Конструктор 1
    public Human()
    {
        name = "Неизвестно";
        age = 20;
    }
    // Конструктор 2
    public Human(string n)
    {
        name = n;
        age = 20;
    }
    // Конструктор 3
    public Human(string n, int a)
    {
        name = n;
        age = a;
    }
}*/



/*class Program
{
    static void Main(string[] args)
    {
        Human human = new Human();
        human.Greetings();

        human = new Human("Дмитрий");
        human.Greetings();

        human = new Human("Дмитрий", 23);
        human.Greetings();

        Console.ReadKey();
    }
}*/



/*class Pen
{
    public string color;
    public int cost;

    public Pen()
    {
        color  = "Черный";
        cost = 100;
    }

    public Pen(string penColor, int penCost)
    {
        color  = penColor;  
        cost = penCost;
    }
}*/





/*using System;

class Human
{
    //Поля класса
    public string name;
    public int age;

    //Метод класса
    public void Greetings()
    {
        Console.WriteLine("Меня зовут {0}, мне {1}", name, age);
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Создание объекта с инициализацией полей
        Human human = new Human { name = "Дмитрий", age = 23 };
        human.Greetings();
    }
}*/




/*using System;


class Rectangle
{
    //Поля класса
    public int a;
    public int b;

    //Конструктор 1
    public Rectangle()
    {
        a = 6;
        b = 4;
    }

    //Конструктор 2
    public Rectangle(int side)
    {
        a = side;
        b = side;
    }

    //Конструктор 3
    public Rectangle(int first, int second)
    {
        a = first;
        b = second;
    }

    //Метод класса
    public int Square()
    {
        return a * b;
    }
}*/



/*using System;


class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}


class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
    }

    static Department GetCurrentDepartment()
    {
        if (department?.Company?.Type == "Банк" && department?.Company?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }
    }
}*/



/*using System;


class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue && Load > 0)
        {
            Console.WriteLine("В автобусе {0} пасажиров", Load.HasValue);
        }
        else
        {
                       Console.WriteLine("Автобус пуст");

        }

    }
}*/





/*class Car
{
    public double Fuel;

    public int Mileage;

    public Car()
    {
        Fuel = 50;
        Mileage = 0;
    }

    public void Move()
    {
        // Move a kilometer
        Mileage++;
        Fuel -= 0.5;
    }

    public void FillTheCar()
    {
        Fuel = 50;
    }
}*/



/*class Circle
{
    public double radius;

    public double Square()
    {
    }

    public double Length()
    {
    }
}

class Triangle
{
    public int a;
    public int b;
    public int c;

    public double Square()
    {
    }

    public double Perimeter()
    {
    }
}

class Square
{
    public int side;

    public double Square()
    {
    }

    public double Perimeter()
    {
    }
}*/





/*sing System;

class TrafficLight
{


    private void ChangeColor(string color)
    {

    }


    public void GetColor()
    {
        
    }

}*/



/*using System;

class User
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            age = value;
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        User user = new User();

        // Setter
        user.Age = 23;

        // Getter
        Console.WriteLine(user.Age);

        Console.ReadKey();
    }
}*/







/*using System;

class User
{

    private string login;


public string Login
{
    get
        {
            return login;
        }

    set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин должен содержать не менее 3 символов");
            }

            else
            {
                login = value;
            }
        }


}

    private string email;


    public string Email
    {
        get
        {
            return email;

        }


        set
        {
            if (! value.Contains("@"))
            {
                Console.WriteLine("Email должен содержать символ @");
            }

            else
            {
                email = value;
            }
        }
    }

}





class Program
{


    public static void Main(string[] args)
    {
        User User = new User();
        Console.WriteLine("Введите свой логин: ");
        User.Login = Console.ReadLine();
}
}*/




/*using System;


class Employee
{
    public string Name;
    public int Age;
    public int Salary;


}


class ProjectManager : Employee
{
    public string ProjectName;
}


class Developer : Employee
{
    private string ProgrammingLanguage;
}*/



/*class Food { }


class Fruit : Food { }

class Vegetable : Food { }

class Apple : Fruit { }
class Banana : Fruit { }

class Pear : Fruit { }

class Potato : Vegetable { }

class Carrot : Vegetable { }
*/