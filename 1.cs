using System;


class HelloWorld {
  public void calculateLen(string s1){
      int len = 0;
      foreach(char i in s1){
          len++;
      }
      Console.WriteLine("Length of String: "+len);
  }
  
  public void ReverseStr(string s1){
      string res="";
      for(int i=s1.Length-1; i>=0; i--){
          res += s1[i];
      }
      Console.WriteLine("Reverse of string: "+res);
  }
  
  public void CheckEqual(string s1, string s2){
     if(s1==s2) 
        Console.WriteLine("strings are equal");
    else
        Console.WriteLine("not wqual");
  }
  static void Main() {
      HelloWorld obj = new HelloWorld();
    String s1 = "hello world";
    String s2 = "hello";
    
    Console.WriteLine("String operations without using bbuild in functions");
    obj.calculateLen(s1);
    obj.ReverseStr(s1);
    obj.CheckEqual(s1, s2);
    
    Console.WriteLine("\n\nString operations using bbuild in functions");
    Console.WriteLine("Length: "+ s1.Length);
    Console.WriteLine("Upper of str1: "+s1.ToUpper());
    Console.WriteLine("equal: "+ s1.Equals(s2));
  }
}
