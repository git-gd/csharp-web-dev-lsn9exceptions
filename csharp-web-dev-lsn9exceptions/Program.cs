using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0) throw new ArgumentOutOfRangeException("Cannot divide by 0.");

            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (String.IsNullOrEmpty(fileName)) throw new ArgumentNullException("fileName cannot be null or empty.");

            return fileName.EndsWith(".cs") ? 1 : 0;
        }
        //If a student’s submitted file ends in .cs, they get 1 point. If a student’s submitted file doesn’t end in .cs, they get 0 points. If the file submitted is null or an empty string, an exception should be thrown. What kind of exception is up to you!

        static void Main(string[] args)
        {
            // Test out your Divide() function here!
            try
            {
                Divide(1, 0);
            } catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            students.Add("Charles", "ReadMe.txt");
            students.Add("Ben", null);

            foreach (string student in students.Keys)
            {
                try
                {
                    Console.WriteLine($"{student} submitted {students[student]} for a score of {CheckFileExtension(students[student])}.");
                } catch (ArgumentNullException e)
                {
                    Console.WriteLine(student + "'s assignment could not be graded: " + e.Message);
                }
            }
        }
    }
}
