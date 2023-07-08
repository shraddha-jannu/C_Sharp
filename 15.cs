using System;
public static class CustomeException{
    public static int IndexOf(this string str, string search){
        if(search == null){
            throw new ArgumentNullException("search value cannot be null");
        }
        return str.IndexOf(search,0);
    }
}
class HelloWorld {
  static void Main() {
      string str = "Hello world";
      string search = null;
      
      try{
          int temp = str.IndexOf(search);
          Console.WriteLine("present at index: "+temp);
      }
      catch(ArgumentNullException ex){
          Console.WriteLine(ex);
      }
  }
}
