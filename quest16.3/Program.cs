public class MyClass
{
    public string change;
}

public struct MyStruct
{
    public string change;
}

class Program
{
    static void ClassTaker(MyClass myClass)
    {
        myClass.change = "изменено";
    }

    static void StruktTaker(MyStruct myStruct)
    {
        myStruct.change = "изменено";
    }

    static void Main(string[] args)
    {
        MyClass myClass = new MyClass();
        MyStruct myStruct = new MyStruct();

        myClass.change = "не изменено";
        myStruct.change = "не изменено";

        ClassTaker(myClass);
        StruktTaker(myStruct);

        Console.WriteLine($"Значение поля change для класса: {myClass.change}");
        Console.WriteLine($"Значение поля change для класса: {myStruct.change}");
        Console.ReadKey();
    }
}