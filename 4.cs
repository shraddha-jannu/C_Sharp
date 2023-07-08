using System;

class University{
    protected string uni_name;
    protected int total_stud;
    
    public University(string uni_name, int total_stud){
        this.uni_name = uni_name;
        this.total_stud = total_stud;
    }
    public void printUniversity(){
        Console.WriteLine("University name: "+this.uni_name);
        Console.WriteLine("Total students: "+this.total_stud);
    }
}
class College : University{
    protected string clg_name;
    protected int total_enroll;
    
    public College(string uni_name, int total_stud, string clg_name, int total_enroll) : base(uni_name, total_stud){
        this.clg_name = clg_name;
        this.total_enroll = total_enroll;
    }
    
    public void printCollege(){
        base.printUniversity();
        Console.WriteLine("College name: "+this.clg_name);
        Console.WriteLine("Total enrollment: "+this.total_enroll);
    }
}
class HelloWorld {
  static void Main() {
    College obj = new College("pashu", 100, "WIT", 500);
    obj.printUniversity();
    obj.printCollege();
  }
}
