using System;

class grandParent{
    protected string name;
    protected int age;
    
    public grandParent(string name, int age){
        this.name = name;
        this.age = age;
    }
    
    public void printGrandParent(){
        Console.WriteLine("Name: "+this.name);
        Console.WriteLine("Age: "+this.age);
    }
}
class Parent : grandParent{
    protected string edu;
    
    public Parent(string name, int age, string edu) : base(name,age){
        this.edu = edu;
    }
    public void printParent(){
        printGrandParent();
        Console.WriteLine("Education: "+this.edu);
    }
}
class Child : Parent{
    protected string sts;
    
    public Child(string name, int age, string edu, string sts) : base(name, age, edu){
        this.sts = sts;
    }
    public void printChild(){
        printParent();
        Console.WriteLine("Marital Status: "+this.sts);
    }
}
class HelloWorld {
  static void Main() {
    Child obj = new Child("abc", 34, "B.Tech", "single");
    obj.printChild();
    
    //is keyword is used to check type
    if(obj is Child){
        Console.WriteLine("obj is type of Child");
    }
    
    //as keyword is used for type casting
    Parent obj1 = obj as Parent;
    
    Console.WriteLine("obj1 is casted to parent "+ obj1.GetType().Name);
  }
}
