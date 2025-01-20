namespace OOPS.Encapsulation;

public class NonEncapsulation
{
    // This class is violating the concept of Encapsulation.
    // Here, this fields 'Age' and 'Name' are public and off-guard.
    // Any class can create the object of this class and access/change the values of these fields.
    public int Age = 20;
    public string Name = "John";
}