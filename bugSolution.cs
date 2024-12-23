public class MyClass {
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public MyClass() {
        MyProperty = 0; // Initialize with a default value
    }

    public void MyMethod() {
        Console.WriteLine(MyProperty.ToString());
    }
}