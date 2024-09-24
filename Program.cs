using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark_Sheet_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Roll No");
            string rollNo = Console.ReadLine();

            Console.WriteLine("Enter Your Class");
            string standard = Console.ReadLine();

            Console.WriteLine("Enter Your urdu Marks");
            int u = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your  math Marks");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Physics Marks");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Chemistry Marks");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your English Marks");
            int e = int.Parse(Console.ReadLine());

            int ObtainMarks = u + m + p + c + e;

            int percentage = ObtainMarks * 100 / 500;

            Console.WriteLine("Your Name is {0}", name);
            Console.WriteLine("Your Roll No is {0}", rollNo);
            Console.WriteLine("Your Class is  {0}", standard);
            Console.WriteLine("Your Obtained Marks is  {0}", ObtainMarks);
            Console.WriteLine("Your Percentage is {0}", percentage);


            //For Displaying Grades
            if (percentage >= 90)
            {
                Console.WriteLine("Grade A+");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade C");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade D");
            }
            else if (percentage <= 49)
            {
                Console.WriteLine("Grade F");
            }

            // For Displaying ReMarks

            if (percentage >= 90)
            {
                Console.WriteLine("Outstanding performance! Your dedication, hard work, and enthusiasm for learning are truly commendable. Keep up the exceptional effort!");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Excellent work! You consistently demonstrate a strong understanding of the material and a willingness to engage. Keep striving for excellence!");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Great job! You have shown solid comprehension and effort. With a bit more focus, you can reach even greater heights. Keep it up!");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Good effort! While you have a basic understanding of the concepts, there is room for improvement. I encourage you to ask questions and seek help when needed.");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Your work shows some understanding, but significant improvement is needed to meet the expectations. I believe you can do better with more effort and focus.");
            }
            else if (percentage <= 49)
            {
                Console.WriteLine("Unfortunately, you did not meet the requirements for this grade. I encourage you to reflect on the challenges you faced and seek support to improve. Let’s work together to create a plan for success.");
            }


            //Displaying Supply
            //int ObtainMarks = u + m + p + c + e;

            int supply = 0;

            if (u < 37)
            {
                supply++;
                Console.WriteLine("You have supply in Urdu");
            }
            if (m < 37)
            {
                supply++;
                Console.WriteLine("You have supply in Math");
            }
            if (p < 37)
            {
                supply++;
                Console.WriteLine("You have supply in Physics");
            }
            if (c < 37)
            {
                supply++;
                Console.WriteLine("You have supply in Chemistry");
            }
            if (e < 37)
            {
                supply++;
                Console.WriteLine("You have supply in English");
            }


            Console.WriteLine("You are Failed in {0} Subjects", supply);

            Console.ReadLine();
        }
    }
}
