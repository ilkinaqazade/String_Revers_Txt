using System;


public class MyClass
{
    public void Space(string str)
    {
        string spacedStr = string.Join("_", str.ToCharArray());
        Console.WriteLine($"Space => {spacedStr}");
    }

    public void Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        string reversedStr = new string(charArray);
        Console.WriteLine($"Reverse => {reversedStr}");
    }
}

public class Run
{
    public void InvokeFunction(Action<string> action, string str)
    {
        action.Invoke(str);
    }
}

public class Program
{
    public delegate void Func(string str);

    public static void Main()
    {
        Console.WriteLine("Enter a string:");
        var str = Console.ReadLine();
        MyClass cls = new MyClass();

        Action<string> spaceAction = cls.Space;
        Action<string> reverseAction = cls.Reverse;

        Run run = new Run();
        run.InvokeFunction(spaceAction, str);
        run.InvokeFunction(reverseAction, str);
    }
}

