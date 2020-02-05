using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {

            int grade;
            Console.WriteLine("To find your grade for the class, enter the integer of your score out of 100.");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 98 && grade <= 100)
            {
                Console.WriteLine("A+");
            }
            else if (grade >= 92 && grade <= 97)
                Console.WriteLine("A");
            else if (grade >= 90 && grade <= 91)
                Console.WriteLine("A-");
            else if (grade >= 88 && grade <= 89)
                Console.Write("B+");
            else if (grade >= 82 && grade <= 87)
                Console.WriteLine("B");
            else if (grade >= 80 && grade <= 81)
                Console.WriteLine("B-");
            else if (grade >= 78 && grade <= 79)
                Console.WriteLine("C+");
            else if (grade >= 72 && grade <= 77)
                Console.WriteLine("C");
            else if (grade >= 70 && grade <= 71)
                Console.WriteLine("C-");
            else if (grade >= 68 && grade <= 69)
                Console.WriteLine("D+");
            else if (grade >= 62 && grade <= 67)
                Console.WriteLine("D");
            else if (grade >= 60 && grade <= 61)
                Console.WriteLine("D-");
            else if (grade < 60)
                Console.WriteLine("F");

            }
        }
    }


