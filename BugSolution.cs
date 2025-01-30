public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        // Properly initialize MyProperty in the constructor
        MyProperty = value;
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty);
    }
}