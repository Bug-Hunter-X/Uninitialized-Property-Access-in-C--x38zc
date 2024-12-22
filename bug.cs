public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        //This will throw an exception if MyProperty is not initialized.
        Console.WriteLine(MyProperty.ToString()); 
    }
}