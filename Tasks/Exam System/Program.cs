using System.IO;

namespace ExamSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose the Subject:\n(1) fo Science\n(2) fo Computer Science");
            int SubType = Convert.ToInt32(Console.ReadLine());
            
            if (SubType == 2) 
            {
                Subject CS = new("Computer Science");

                Console.WriteLine("Choose the type of Exam:\n(1) for Practice\n(2) for Final");
                int ExamType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n   $$..." + CS.GetSubName() +" Exam is started NOW...$$\n");
                if (ExamType == 1) 
                {
                    PracticeExam PE = new("C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\CS.txt", "C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\CS_Answers.txt"); 
                    PE.ShowExam();
                    PE.Finished();
                }
                else
                {
                    FinalExam FE = new("C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\CS.txt", "C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\CS_Answers.txt");
                    FE.ShowExam();
                    FE.Finished();
                }
            }
            else
            {
                Subject Scince = new("Science");

                Console.WriteLine("Choose the type of Exam:\n(1) for Practice\n(2) for Final");
                int ExamType = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n   $$..." + Scince.GetSubName() + " Exam is started NOW...$$\n");
                if (ExamType == 1)
                {
                    PracticeExam PE = new("C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\Science.txt", "C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\Science_Answers.txt"); 
                    PE.ShowExam();
                    PE.Finished();
                }
                else
                {
                    FinalExam FE = new("C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\Science.txt", "C:\\Users\\20106\\OneDrive\\Desktop\\C# ITI\\ExamSystem\\CS_Answers.txt");
                    FE.ShowExam();
                    FE.Finished();
                }
            }
        }
    }
}