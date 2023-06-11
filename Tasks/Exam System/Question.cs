namespace ExamSystem
{
     class TrueFalseQuestion : Question
     {
        static int QuestionNumber = 0;
        protected Answer AnswerClassObject; //string Ans  setAns()   getAns()


        public override void SetYourAnswer()
        {
            AnswerClassObject = new Answer(); //for each question create its own answer
            AnswerClassObject.SetAns();
        }
        public override string GetYourAnswer()
        {
            return AnswerClassObject.GetAns();
        }


        //SetBody() method takes "string" represents the path of file it will get the question from.
        public override void SetBody(string str)
        {
            StreamReader sr = new StreamReader(str);

            string[] arr = new string[8]; //array size is fixed because the number of the whole questions are 8 in any file.
            for (int i = 0; i < 8; i++)
            {
                arr[i] = sr.ReadLine();
            }
            sr.Close();


            Body = arr[QuestionNumber]; 
            QuestionNumber++; /*this step to:
            If u create the first object and SetBody(), the body of the first question will store the first line in ur file.
            In the second call, "QuestionNumber" increased by one, so "Body" will store "arr[1]", 
            which means it stores the second value in arr, which represnts the second line in the file. */
        }
     }



     class ChooseQuestion : Question
     {
        protected Answer AnswerClassObject;
        static int QuestionNumber = 4; //I give this variable the value 4 as initial value because "Choose" questions in my file starts from line 5 (4 by zerobased indexing).

        public override void SetYourAnswer()
        {
            AnswerClassObject = new Answer();
            AnswerClassObject.SetAns();
        }
       
        public override string GetYourAnswer()
        {
            return AnswerClassObject.GetAns(); 
        }


        public override void SetBody(string str)
        {
            StreamReader sr = new StreamReader(str); //read the file path that stores in "str" variable
            

            //store all the eight questions in array of string//
            string[] arr = new string[8]; //array size is fixed because the number of the whole questions are 8 in any file.
            for (int i = 0; i < 8; i++)
            {
                arr[i] = sr.ReadLine();
            }
            sr.Close();


            Body = arr[QuestionNumber];
            QuestionNumber++;
        }
     }



     abstract public class Question
     {
        static string Header; //static because the question have only one header, and multible bodies(Q.q, Q.2. Q.3, ...)
        protected string Body;

        public static void SetHeader(string _header) //static: call it only by the method name.
        {
            Header = _header;
        }
        public static string GetHeader()
        {
            return Header;
        }



        abstract public void SetBody(string str);
        public string GetBody() 
        { 
            return Body;
        }



        abstract public void SetYourAnswer();
        abstract public string GetYourAnswer();
     }
}
