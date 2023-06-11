using ExamSystem;

namespace ExamSystem
{
    class PracticeExam : Exam
    {

        /*Parameterized ctor: put the file of the PracticeExam inside it, 
          so once u call an object from it the exam is setted, but not apear for user yet. 
          there is a method ShowExam() do this. */
        public PracticeExam(string questionsFile, string answersFile) : base(questionsFile, answersFile) 
        {
        }

        public void Finished()
        {
            if(AnswersPath == "")
            {
                Console.WriteLine("Finished() method Need a file path to acces the Answers...");
                return;
            }

            //1- store the user answers in the list "StringAnswers" which exists in AnswerList class
            GetUserAnswers(); //I call it here because SetExamMark() method loops on "StringAnswers", 
                              //so it have to be full first. if i don't call it here, "Mark" will be zero always.


            SetExamMark(); //2- صحح الامتحان.

            Console.WriteLine("\n\n-----------------------------------------------------------------\n\n\n  ***EXAM FINISHED, HERE ARE THE RIGHT ANSWERS OF THE EXAM***\n\n");
            string Answers = File.ReadAllText(AnswersPath); //3-open the file contains the right answers and get the whole answers.
            Console.WriteLine(Answers); //4- print these answers

            Console.WriteLine("\n_______________________\n Your Mark in this Exam is: " + GetExamMark() + " out of 8 "); //5- print the user mark.
        }
    }


    class FinalExam : Exam
    {
        public FinalExam(string questionsFile, string answersFile) : base(questionsFile, answersFile)
        {
        }

        public void Finished()
        {
            Console.WriteLine("\n\n-----------------------------------------------------------------\n\n\n  ***EXAM FINISHED, THE QUESTIONS ARE:***\n");
            ShowList();       //1- show the exam after answering all questions.
            Console.WriteLine("\n  ***YOUR ANSWERS***\n");

            GetUserAnswers(); //2- store the answers in the list "StringAnswers" which exists in AnswerList class. 
            SetExamMark(); //3- صحح الامتحان.
            PrintUserAnswers();//4- print the user answers.
            Console.WriteLine("\n_______________________\n Your Mark in this Exam is: " + GetExamMark() + " out of 8 ");//5- print the user mark.

        }
    }


    abstract internal class Exam : QuestionsList
    {
        /*parameterized ctor: once u create and exame,
          pass the path of the file that its Questions List exixt in, 
          and pass the path of the right answers file too. */
        public Exam(string str1, string str2) : base(str1, str2) { }



        //create the two type of questions( 4 True False , 4 Choose).
        TrueFalseQuestion tr1 = new();
        TrueFalseQuestion tr2 = new();
        TrueFalseQuestion tr3 = new();
        TrueFalseQuestion tr4 = new();
        ChooseQuestion ch1 = new();
        ChooseQuestion ch2 = new();
        ChooseQuestion ch3 = new();
        ChooseQuestion ch4 = new();



        //put each question inside the list of questions "Questionsss" that exist in QuestionsList class.
        public void SetQuestionsInList()
        {
            Add(tr1);
            Add(tr2);
            Add(tr3);
            Add(tr4);
            Add(ch1);
            Add(ch2);
            Add(ch3);
            Add(ch4);
        }
        

        //recive the user answers.
        public void LetUserAnswer()
        {
            tr1.SetYourAnswer();
            tr2.SetYourAnswer();
            tr3.SetYourAnswer();
            tr4.SetYourAnswer();
            ch1.SetYourAnswer();
            ch2.SetYourAnswer();
            ch3.SetYourAnswer();
            ch4.SetYourAnswer();
        }


        //add answers to the list of answers "AnsL" exists in QuestionList class.
        public void GetUserAnswers()
        {
            AnsL.AddAnswerToList(tr1);
            AnsL.AddAnswerToList(tr2);
            AnsL.AddAnswerToList(tr3);
            AnsL.AddAnswerToList(tr4);
            AnsL.AddAnswerToList(ch1);
            AnsL.AddAnswerToList(ch2);
            AnsL.AddAnswerToList(ch3);
            AnsL.AddAnswerToList(ch4);
        }


        //show the user's answers in console.
        public void PrintUserAnswers()
        {
            AnsL.PrintTheWholeAnswers();
        }


        //show the exam in console.
        public void ShowExam()
        {
            SetQuestionsInList(); //set the questions first.
            ShowList();       //show the exam after settin its all questions.
            Console.WriteLine("\n____________________________________________________________\n");
            LetUserAnswer();    //Let the user start answering.
        }
    }
}
