public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Assign a default value in the property declaration

    public ExampleClass()
    {
        MyProperty = 10; // Initialize in constructor
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty.ToString());
    }
}