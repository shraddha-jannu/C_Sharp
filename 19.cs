using System;

class HelloWorld {
    public delegate void Del(int num);
    
    public void MultiplyNumbers(int num){
        for(int i=1; i<=5; i++){
            Console.WriteLine(i+" * "+"2 = "+(i*num));
        }
    }
    static void Main() {
        HelloWorld obj = new HelloWorld();
        Del del = new Del(obj.MultiplyNumbers);
        del(2);
    }
}
