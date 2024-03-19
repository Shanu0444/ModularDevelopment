using System.Diagnostics.Contracts;

namespace TestConsole.Shapes;

public class Square : Shapes{

 //public double width {get; set;}
public Square(double size){
    width = size;
    height = size;
}
//  public override double Area(){
//     return width*width;
//  }
}