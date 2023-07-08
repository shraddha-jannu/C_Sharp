using System;
class HelloWorld {
  static void Main() {
      string s1="hello";
      string s2 = null;
      
      if(s1!=null && s2!=null){
          if(s1.Equals(s2)){
              Console.WriteLine("Strings are equal");
          }
          else{
              Console.WriteLine("not equal");
          }
      }
      else{
          Console.WriteLine("strings cannot be null");
      }
  }
}
