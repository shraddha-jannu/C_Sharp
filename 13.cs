using System;
class HelloWorld {
  static void Main() {
      int a=10;
      int b=0;
      int res=0;
      
      try{
          res = a/b;
          Console.WriteLine("Result: "+res);
      }
      catch(DivideByZeroException ex){
          Console.WriteLine("Cannot divide by zero");
      }
      catch(ArithmeticException ex){
          Console.WriteLine(ex);
      }
      
      finally{
          Console.WriteLine("Finally block executed");
      }
  }
}
