using System;
using System.Threading;
public class MyThread{
    public void Thread1(){
        for(int i=1; i<=10; i++){
            Console.Write(i+" ");
        //    Thread.Sleep(200);
        }
        
    }
    
   
    public void Thread2(){
        for(int i=11; i<=20; i++){
            Console.Write(i+" ");
          //  Thread.Sleep(200);
        }
    }
}
class HelloWorld {
  
  static void Main() {
      MyThread mt = new MyThread();
      Thread t1 = new Thread(new ThreadStart(mt.Thread1));
      t1.Start();
      
      Thread t2 = new Thread(new ThreadStart(mt.Thread2));
      t2.Start();
   
  }
}
