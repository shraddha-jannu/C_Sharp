
using System;
class Student{
    int reg_no;
    string name;
    DateTime dob;
    
    public Student(int reg_no, string name, DateTime dob){
        this.reg_no = reg_no;
        this.name = name;
        this.dob = dob;
    }
    public void print(){
        Console.WriteLine("Reg no: "+reg_no);
        Console.WriteLine("Name: "+name);
        Console.WriteLine("DOB: "+dob);
    }
    public void calculateAge(){
        DateTime curDate = DateTime.Now;
        int age = curDate.Year - this.dob.Year;
        Console.WriteLine("Current age: "+age);
    }
}
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter regno, name, dob");
    int reg_no = Convert.ToInt32(Console.ReadLine());
    string name = Console.ReadLine();
    DateTime dob = DateTime.Parse(Console.ReadLine());
    Student s1 = new Student(reg_no, name, dob);
    s1.print();
    s1.calculateAge();
  }
}

