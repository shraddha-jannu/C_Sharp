using System;

class HelloWorld {
    public delegate void Operation(int x, int y);
    
    public void Add(int x, int y){
        Console.WriteLine("Add: "+(x+y));
    }
    
    public void Sub(int x, int y){
        Console.WriteLine("Sub: "+(x-y));
    }
    
    public void Mul(int x, int y){
        Console.WriteLine("Mul: "+(x*y));
    }
  
    static void Main() {
        HelloWorld obj = new HelloWorld();
        Operation del1 = new Operation(obj.Add);
        del1 += obj.Sub;
        del1 += obj.Mul;
        del1(10,20);
    }
}
