using TestConsole.Classes;
using TestConsole.Shapes;


// TestClass x = new TestClass(){square = 5};

// Console.WriteLine(x.square);

// TestClass y = new TestClass(){square = 7};

// Console.WriteLine(y.square);

// y=x;

// Console.WriteLine(y.square);

// x.square++;

// Console.WriteLine(y.square);

//Running using default constructor
// TestClass x = new TestClass());

// Console.WriteLine(x);


  
//Running using parameteric constructor
// TestClass x = new TestClass((int) -3);

// Console.WriteLine(x.square);



Square s = new Square(4);
Console.WriteLine(s.Area());

Rectangle r = new Rectangle(5,6);
Console.WriteLine(r.Area());

List<Shapes> LS = new List<Shapes>();
LS.Add(s);
LS.Add(r);
Console.WriteLine(LS);
