using System;

interface GardeCalculator{
     void displayGrade();
}
class Person{
    string name;
    int age;
    
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    
    public void displayPerson(){
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
    }
}
class Student:Person, GardeCalculator{
    int roll;
    int marks;
    
    public Student(string name, int age, int roll, int marks) : base(name,age){
        this.roll = roll;
        this.marks = marks;
    }
    
    public void displayStudent(){
        displayPerson();
        Console.WriteLine("Roll no: "+roll);
        Console.WriteLine("Marks: "+marks);
    }
    public void displayGrade(){
        displayStudent();
        if(marks>=75 && marks<=100)
            Console.WriteLine("Grade A");
        else if(marks>=60 && marks<75)
            Console.WriteLine("Grade B");
        else if(marks>=50 && marks<60)
            Console.WriteLine("Grade C");
        else
            Console.WriteLine("Grade D");
    }
}
class HelloWorld {
  static void Main() {
   Student obj = new Student("abc", 20, 55, 84);
   obj.displayGrade();
  }
}
