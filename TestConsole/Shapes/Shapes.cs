namespace TestConsole.Shapes;

public abstract class Shapes{
    protected double width {get; set;}

    protected double height{get; set;}

    public virtual double Area()
    {
        return width*height;
    }
}