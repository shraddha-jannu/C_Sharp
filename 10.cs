using System;
class Person{
    protected string name;
    protected int age;
    
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    
    public virtual void DisplayInfo(){
        Console.WriteLine("Name: "+this.name);
        Console.WriteLine("Age: "+this.age);
    }
}

class Adhar_card : Person{
    string num;
    public Adhar_card(string name, int age, string num):base(name,age){
        this.num = num;
    }
    
    public override void DisplayInfo(){
        base.DisplayInfo();
        Console.WriteLine("Security num: "+num);
    }
}

class HelloWorld {
  static void Main() {
    Adhar_card obj = new Adhar_card("abc", 30, "1234 56789 1234");
    obj.DisplayInfo();
  }
}
