using System;
using System.Reflection;

class Program
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class MyCustomAttribute : Attribute
    {
        public string Description { get; }

        public MyCustomAttribute(string description)
        {
            Description = description;
        }
    }

    [MyCustom("This is a class attribute")]
    class MyClass
    {
        [MyCustom("This is a method attribute")]
        public void MyMethod()
        {
            // Method implementation
        }
    }

    static void Main()
    {
        // Get the type of MyClass
        Type type = typeof(MyClass);

        // Get class-level attributes
        object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
       
        foreach (MyCustomAttribute attribute in classAttributes)
        {
            Console.WriteLine($"Class Attribute: {attribute.Description}");
        }

        // Get method-level attributes
        MethodInfo methodInfo = type.GetMethod("MyMethod");
        object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
       
        foreach (MyCustomAttribute attribute in methodAttributes)
        {
            Console.WriteLine($"Method Attribute: {attribute.Description}");
        }

        Console.ReadKey();

    }
}