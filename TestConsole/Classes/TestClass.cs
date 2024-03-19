using System.Diagnostics.Contracts;

namespace TestConsole.Classes;


public class TestClass{

//Parametric Constructor
    public TestClass(int z){
        square = z;
    }

//Default Constructor
// public TestClass(){
//    // square = -1;
// }

    public int square{get; set;}
}
