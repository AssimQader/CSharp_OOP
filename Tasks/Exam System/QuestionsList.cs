
using System.Collections.Generic;  // to use List<T>
using System.Diagnostics.Metrics;

namespace ExamSystem
{
    internal class QuestionsList : List<Question>
    {
        //composition: "part-of" relationship(Questions are part of the Exam) ... (strong/death) relationship, if there is no exam then there are no questions. smae for answers.
        
        protected List<Question> Questionsss = new();
        protected AnswersList AnsL = new(); //put the answers of each question in a list(AnsL is like a file contains all the user answers).
        
        protected string QuestionsPath;
        protected string AnswersPath;
        protected int Marks = 0;

        // parametrize ctor: this ctor is for the practic exam, path1 is the questions file, path2 is the right answers file.
        public QuestionsList( string path1, string path2)
        {
            QuestionsPath = path1;
            AnswersPath = path2;
        }



        //override AddAnswerToList() method in List<T> Generic class to add a new question to the list(QList).
        public new void Add(Question q) //I can pass TrueFalse or Choose Questions, thatnks for the abstract class Question..
        {
            q.SetBody(QuestionsPath); //set the body of the question
            Questionsss.Add(q); //then add the question to the list
        }



        public void SetExamMark()
        {
            //get the file that contain the right answers//
            StreamReader reader = new(AnswersPath);
            string[] rightAnswers = new string[8];

            for (int i = 0; i < 8; i++)
            {
                rightAnswers[i] = reader.ReadLine();
            }
            reader.Close();



            //check the user answers to give him/her a mark//
            int line = 0;
            foreach (string userAnswer in AnsL.GetAnswersL())
            {
                if (Marks == 0)
                {
                    if (userAnswer == rightAnswers[line])
                        Marks++;
                }
                else
                {
                    if (userAnswer == rightAnswers[line])
                        Marks++; 
                }
                line++;
            }
        }

        public int GetExamMark() 
        { 
            return Marks; 
        }


        public void ShowList() 
        {
            int fileLines_counter = 0;

            TrueFalseQuestion.SetHeader("    [True Of False Question]\n");
            Console.WriteLine(TrueFalseQuestion.GetHeader());

            foreach (Question q in Questionsss)
            {
                if(fileLines_counter == 4) 
                {
                    ChooseQuestion.SetHeader("\n    [Choose the Correct Answer]\n");
                    Console.WriteLine(ChooseQuestion.GetHeader());
                }
                Console.WriteLine(q.GetBody());
                fileLines_counter++;
            }
        }
    }

}
