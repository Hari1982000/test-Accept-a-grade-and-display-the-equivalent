using System;
class program
{
    public static void Main()
    {
        char grade;
        Console.WriteLine("Enter the Grade in UpperCase \n");
        grade = Convert.ToChar(Console.ReadLine());
        switch (grade)
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;
            case 'V':
                Console.WriteLine("Very Good");
                break;
            case 'G':
                Console.WriteLine("Good");
                break;
            case 'A':
                Console.WriteLine("Average");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("ERROR IN GRADE \n");
                break;
                Console.ReadLine();
        }
    }
}