/*using System;



class Obj
{
    private string name;
    private string owner;
    private int length;
    private int count;

    public Obj(string name, string ownerName, int objLength, int count)
    {
        this.name = name;
        owner = ownerName;
        length = objLength;
        this.count = count;
    }
}*/



/*using System;


class SmartHelper
{
    private string name;

    public SmartHelper(string name)
    {
        this.name = name;
    }

    public void Greetings(string name)
    {
        Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SmartHelper helper = new SmartHelper("Олег");
        helper.Greetings("Грег");

        Console.ReadKey();
    }

}*/


/*using System;



class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;


    public DerivedClass(string name, string description) : base(name)
    {
        Description = description;

    }


    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }

}*/



/*using System;
class Car
{
    public int Mileage;

    public Car()
    {
        Mileage = 0;
    }

    public virtual void Move()
    {
        Console.WriteLine("Вызван метод Move класса Car");
        Mileage++;
    }
}

enum FuelType
{
    Gas = 0,
    Electricity
}

class HybridCar : Car
{
    public FuelType FuelType;

    public double Gas;

    public double Electricity;

    public HybridCar()
    {
        Electricity = 50;
        Gas = 50;
    }

    public override void Move()
    {
        Console.WriteLine("Вызван метод Move класса HybridCar");
        Mileage++;

        switch (FuelType)
        {
            case FuelType.Gas:
                Gas -= 0.5;
                break;
            case FuelType.Electricity:
                Electricity -= 0.5;
                break;
        }
    }

    public void ChangeFuelType(FuelType type)
    {
        FuelType = type;
    }
}*/




/*using System;



class BaseClass
{
    public virtual void Display()
        {
        Console.WriteLine("Вызван метод Display класса BaseClass");
    } 

}

class DerivedClass: BaseClass 
{

    public override void Display()
    {
    Console.WriteLine("Вызван метод Display класса DerivedClass");
    }
}*/





//Наследование с переопределением свойства
/*class Citizen
{
    public virtual double Age
    {
        get;
        set;
    }

    public void SayYourAge()
    {
        Console.WriteLine("Мне {0} лет", Age);
    }
}

class CivilServant : Citizen
{
    private double age;
    public override double Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
            }
            else
            {
                age = value;
            }
        }
    }
}*/



//Наследование с переопределением свойства
/*class Citizen
{
    public virtual double Age
    {
        get;
        set;
    }

    public void SayYourAge()
    {
        Console.WriteLine("Мне {0} лет", Age);
    }
}

class CivilServant : Citizen
{
    private double age;
    public override double Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Для работы госслужащим гражданин должен быть не младше 18 лет");
            }
            else
            {
                age = value;
            }
        }
    }
}

class President : CivilServant
{
    private double age;
    public override double Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 35)
            {
                Console.WriteLine("Для работы президентом гражданин должен быть не младше 35 лет");
            }
            else
            {
                age = value;
            }
        }
    }
}
*/



/*using System;


class BaseClass
{
    public virtual int Counter
    {
        get;
        set;
    }
}

class DerivedClass : BaseClass
{
    private int counter;
    public override int Counter
    {
        get
        {
            return counter;
        }

        set
        {
            if (value < 0)
            {
                Console.WriteLine("Значение счетчика не может быть отрицательным");

            }

            else
            {
                counter = value;
            }
        }
    }
}*/


/*using System;




class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Вызван метод Display класса BaseClass");
    }

}

class DerivedClass : BaseClass
{

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Вызван метод Display класса DerivedClass");
    }
}*/




/*using System;


class A
{
    public virtual void Display()
    {
        Console.WriteLine("Вызван метод класса A");
    }
}
class B : A
{
    public override void Display()
    {
        Console.WriteLine("Вызван метод класса B");
    }
}
class C : B
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса C");
    }
}


class Program
{
    

    static void Main(string[] args)
    {
        A a = new A();
        B b = new B();
        C c = new C();
        a.Display();    // метод класса A
        b.Display();    // метод класса B
        ((A)b).Display();   // метод класса B

        c.Display();    // метод класса C
        ((A)c).Display();   // метод класса B
        ((B)c).Display();	// метод класса B
    }
}*/




/*class A
{
    public virtual void Display()
    {
        Console.WriteLine("Вызван метод класса A");
    }
}

class B : A
{
       public new void Display()
    {
        Console.WriteLine("Вызван метод класса B");
    }
}


class C : A
{
    public override void Display()
    {
        Console.WriteLine("Вызван метод класса C");
    }
}


class D : B
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса D");
    }

}

class E : D
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса E");
    }
}



class Program
{
    static void Main(string[] args)
    {

        D d = new D();
        E e = new E();

        d.Display();
        ((A)e).Display();
        ((B)d).Display();
        ((A)d).Display();
    }
}*/





/*internal class Program
{
    static void Main(string[] args)
    {
        Vector a = new Vector { X = 3, Y = 5 };
        Vector b = new Vector { X = 7, Y = 13 };

        Vector c = a.Add(b);

        Console.WriteLine($"{c.X}, {c.Y}");
    }
}

class Vector
{
    public int X;
    public int Y;

    public Vector Add(Vector second)
    {
        return new Vector
        {
            X = this.X + second.X,
            Y = this.Y + second.Y
        };
    }
}*/





/*class Obj
{
    public int Value;

    public static Obj operator +(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value + b.Value
        }
    }

    public static Obj operator -(Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value - b.Value
        };
    }
}*/


