using System;

class Student
{
    protected string name;
    protected int marks;

    public Student(string name, int marks)
    {
        this.name = name;
        this.marks = marks;
    }

    public virtual void DisplayGrade()
    {
        Console.WriteLine("Student: " + name);
        Console.WriteLine("Marks: " + marks);
    }
}

class UndergraduateStudent : Student
{
    public UndergraduateStudent(string name, int marks)
        : base(name, marks)
    {
    }

    public override void DisplayGrade()
    {
        base.DisplayGrade();
        if (marks >= 70)
        {
            Console.WriteLine("Grade: Distinction");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: First Class");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade: Second Class");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }
    }
}

class PostgraduateStudent : Student
{
    public PostgraduateStudent(string name, int marks)
        : base(name, marks)
    {
    }

    public override void DisplayGrade()
    {
        base.DisplayGrade();
        if (marks >= 80)
        {
            Console.WriteLine("Grade: Distinction");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade: Merit");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: Pass");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }
    }
}

class Program
{
    static void Main()
    {
        Student undergraduate = new UndergraduateStudent("John Doe", 85);
        Student postgraduate = new PostgraduateStudent("Jane Smith", 73);

        undergraduate.DisplayGrade();
        Console.WriteLine();

        postgraduate.DisplayGrade();
    }
}
