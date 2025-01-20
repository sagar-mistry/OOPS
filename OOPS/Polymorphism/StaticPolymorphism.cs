namespace OOPS.Polymorphism;

public class StaticPolymorphism
{
    //Polymorphism is one thing, many forms
    //2 types of polymorphism are there
    // Static | Compile-time | Method overloading
    // Dynamic | Run-time | Method overriding


    public double CalculateArea(int radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double CalculateArea(int length, int width, int height)
    {
        return length * width * height;
    }

    public double CalculateArea(int length, int depth)
    {
        return 1 / 2 * (length * depth);    
    }

    public virtual void Drive()
    {
        Console.WriteLine("Driving in Static Polymorphism");
    }
}