namespace OOPS.Encapsulation;

public class Encapsulation
{
    // Here, fields are private and encapsulated by properties and access modifiers
    // To access the class fields, we need to access the properties which are encapsulated around them
    // Can not be accessed directly
    private int age;
    private string name;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}