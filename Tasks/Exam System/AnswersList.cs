
namespace ExamSystem
{
    internal class AnswersList
    {
         List<string> StringAnswers = new List<string>(); //list of strings because the answers are in string format.


        public void AddAnswerToList(Question q)
        {
            //string _answer = q.GetYourAnswer();
            StringAnswers.Add(q.GetYourAnswer());
        }


        public List<string> GetAnswersL()
        {
            return StringAnswers;
        }


        public void PrintTheWholeAnswers() 
        { 
            foreach (string answer in StringAnswers) {
                Console.WriteLine(answer);
            }
        }
    }
}
