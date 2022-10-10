
namespace HW6;

class Professor
{
  public string profName;

  public string classTeach;
  private double salary;
  public void SetSalary(double salary_amount)
  {
    salary = salary_amount;
  }
  public double GetSalary()
  {
    return salary;
  }
}

class Student
{
  public string studentName;

  public string classEnroll;
  private double studentGrade;
  public void SetGrade(double newGrade)
  {
    studentGrade = newGrade;
  }
  public double GetGrade()
  {
    return studentGrade;
  }
}

class Program
{
    static void Main(string[] args)
    {
        Professor Mary = new Professor();
        Mary.profName = "Mary";
        Mary.classTeach = "Java";
        Mary.SetSalary(9000);
        double MS = Mary.GetSalary();
        Console.WriteLine("Professor " + Mary.profName + " teaches " + Mary.classTeach + ", and the salary is: " + MS);

         Professor Tod = new Professor();
        Tod.profName = "Tod";
        Tod.classTeach = "Math";
        Tod.SetSalary(8000);
        double TS = Tod.GetSalary();
        Console.WriteLine("Professor " + Tod.profName + " teaches " + Tod.classTeach + ", and the salary is: " + TS);

        Student Cary = new Student();
        Cary.studentName = "Cary";
        Cary.classEnroll = "Java";
        Cary.SetGrade(90);
        double CG = Cary.GetGrade();
        Console.WriteLine("Student " + Cary.studentName + " enrolls " + Cary.classEnroll + ", and the grade is: " + CG);

        Student Jon = new Student();
        Jon.studentName = "Jon";
        Jon.classEnroll = "Math";
        Jon.SetGrade(80);
        double JG = Jon.GetGrade();
        Console.WriteLine("Student " + Jon.studentName + " enrolls " + Jon.classEnroll + ", and the grade is: " + JG);

        Console.WriteLine("The salary difference between "+ Mary.profName + " and " + Tod.profName + " is: " + (MS - TS));
        Console.WriteLine("The total grade between "+ Cary.studentName + " and "+ Jon.studentName + " is: " + (CG + JG));
  }
}
    
