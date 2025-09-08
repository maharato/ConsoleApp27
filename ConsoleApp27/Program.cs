using System.Collections;

namespace ConsoleApp27
{

    public class questions
    {

        List<string> easyQuestion = new List<string>();
        List<string> mediumQuestion = new List<string>();
        List<string> hardQuestion = new List<string>();

        List<string> easyQuestion_correct = new List<string>();
        List<string> mediumQuestion_correct = new List<string>();
        List<string> hardQuestion_correct = new List<string>();
        int marks = 0;
        public string questionTypee(int type)
        {
            switch (type)
            {
                case 1:
                    return "True/False";
                case 2:
                    return "Choose One";
                case 3:
                    return "Multiple Choice";
                default:
                    return "unknown";
            }
        }
        public string questionLevel(int level)
        {
            switch (level)
            {
                case 1:
                    return "Easy";
                case 2:
                    return "Medium";
                case 3:
                    return "Hard";
                default:
                    return "unknown";
            }
        }
        public void addQuestion(string question, int level, string correctAnswer,int marks)
        {
            switch (level)
            {
                case 1:
                    easyQuestion.Add(question);
                    easyQuestion_correct.Add(correctAnswer);
                    break;
                case 2:
                    mediumQuestion.Add(question);
                    mediumQuestion_correct.Add(correctAnswer);
                    break;
                case 3:
                    hardQuestion.Add(question);
                    hardQuestion_correct.Add(correctAnswer);
                    break;
                default:
                    Console.WriteLine("Invalid level");
                    break;
            }
        }



    }




    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                questions ques = new questions();
                Console.WriteLine("please enter number of question");
                int numQuestions = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < numQuestions; i++)
                {
                    Console.WriteLine("please enter question type (1: True/False, 2: Choose One, 3: Multiple Choice)");
                    int type = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter question level");
                    Console.WriteLine("1: Easy, 2: Medium, 3: Hard");
                    int level = Convert.ToInt32(Console.ReadLine());



                    Console.WriteLine("please enter the question");
                    string question = Console.ReadLine();
                    Console.WriteLine("please enter the question marks");
                    int questionMarks = Convert.ToInt32(Console.ReadLine());
                    if () { 
                    
                    
                    }



                }
            }
        }
    }
}
