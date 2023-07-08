using System;

abstract class Person{
    protected string name;
    protected int age;
    
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    
    public void displayPerson(){
        Console.WriteLine("Name: "+this.name);
        Console.WriteLine("Age: "+this.age);
    }
    
    public abstract void calculateAnnualTax();
}

class Emp : Person{
    private string desi;
    private int sal;
    
    public Emp(string name, int age, string desi, int sal):base(name,age){
        this.desi = desi;
        this.sal = sal;
    }
    
    public void displayEmp(){
        displayPerson();
        Console.WriteLine("Designation: "+this.desi);
        Console.WriteLine("Salary: "+this.sal);
    }
    
    public override void calculateAnnualTax(){
        double tax = 0.15;
        double annualTax = sal*tax;
        Console.WriteLine("Annual Tax: "+annualTax);
    }
}

class Company : Emp{
    private string comp_nm;
    private int total_emp;
    
    public Company(string name, int age, string desi, int sal, string comp_nm, int total_emp) : base(name, age, desi, sal){
        comp_nm = comp_nm;
        total_emp = total_emp;
    }
    
    public void displayCompany(){
        displayEmp();
        Console.WriteLine("Company name: "+this.comp_nm);
        Console.WriteLine("Total emp: "+this.total_emp);
        calculateAnnualTax();
    }
    
}
class HelloWorld {
  static void Main() {
    Company obj = new Company("abc", 34, "Developer", 40000, "TCS", 130) ;
    obj.displayCompany();
  }
}
