using System;
class Emp{
    int emp_id;
    string post;
    double salary;
    
    //constructor overloading
    public Emp(){
        
    }
    public Emp(int emp_id, string post, double salary){
        this.emp_id = emp_id;
        this.post = post;
        this.salary = salary;
    }
    
    public void calculateTax(){
        //considder default tax value is 0.20
        double tax = 0.20;
        double annualTax = this.salary*tax;
        Console.WriteLine("Annual Tax: "+annualTax);
    }
}
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter emp id, post, salary");
    int emp_id = Convert.ToInt32(Console.ReadLine());
    string post = Console.ReadLine();
    double salary = Convert.ToDouble(Console.ReadLine());
    Emp e1 = new Emp(emp_id, post, salary);
    e1.calculateTax();
  }
}
