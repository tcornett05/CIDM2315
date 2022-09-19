namespace HW5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two different numbers:");
        int s = Convert.ToInt32(Console.ReadLine());
        int t = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Largest number is: " + Part1(s,t));

        Console.WriteLine("Enter M:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter right or left:");
        string rl = Console.ReadLine();
        part2(m,rl);
    }
    static int Part1(int c, int d) 
    {
        if(c>d)
        return c;
        else return d;
    }

    static void part2(int m, string s) 
    {
        if (s == "left"){
           for (int i = 1; i <= m; i++)  
         {  
            for (int l = 1; l <= i; l++)  
            {  
               Console.Write("");  
            }  
            for (int o = 1; o <= i; o++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
        }

    else if (s == "right"){
        for (int i = 1; i <= m; i++)  
         {  
            for (int l = 1; l <= m-i; l++)  
            {  
               Console.Write(" ");  
            }  
            for (int o = 1; o <= i; o++)  
            {  
               Console.Write("*");  
            }  
            Console.WriteLine("");  
         }  
    }

    else Console.WriteLine("Try again, entered bad info");
    }
    }