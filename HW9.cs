namespace HW9;
using System.Linq;

class Student{
    public static List<Student> student_list = new List<Student>();
    private int studentID;
    private string studentName;
    public string tryName;
    public void PrintInfo(){
Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
    public Student(int id,string n){
        studentID = id;
        studentName = n;
        tryName = n;
        student_list.Add(this);
    }   
}
class Program
{
    static void Main(string[] args)
    {
        Student Alice = new Student(111,"Alice");
        Student Ben = new Student(222,"Ben");
        Student Kathy = new Student(333,"Kathy");
        Student David = new Student(444,"David");

        Dictionary<string,double> gradebook = new Dictionary<string,double>();
        gradebook.Add("Alice",4.0);
        gradebook.Add("Ben",3.6);
        gradebook.Add("Kathy",2.5);
        gradebook.Add("David",1.8);

         if(gradebook.ContainsKey("Tom")){
            Console.WriteLine("Tom is in the List");
        }
        else{
            gradebook.Add("Tom",3.3);
        }
        Console.WriteLine($"The average GPA is: {gradebook.Values.Average()}");
        foreach(var stu in gradebook){
        if(stu.Value > gradebook.Values.Average()){
            string nn = stu.Key;
            foreach(Student stud in Student.student_list){
           if(stud.tryName == nn){
            stud.PrintInfo();
            }
        }
        }
    }
}
}

public void PrintCusInfo()
{
    Console.WriteLine("Customer: "+cus_id+", name: "+cus_name+", age:"+cus_age);
}
public void CompareAge(Customer objCustomer)
{
    if(objCustomer.cus_age > this.cus_age)
    {
        Console.WriteLine(objCustomer.cus_name + " is older");
    }
    else if(objCustomer.cus_age < this.cus_age)
    {
        Console.WriteLine(this.cus_name + " is older");
    }
    else Console.WriteLine("Same age");
}
}
class Program
{
    static void Main(string[] args)
    {
        Customer A = new Customer(110,"Alice",28);
        A.PrintCusInfo();
        Customer B = new Customer(111,"Ben",30);
        B.PrintCusInfo();
        A.ChangeID(220);
        A.PrintCusInfo();
        B.ChangeID(221);
        B.PrintCusInfo();
        A.CompareAge(B);
    }
}
