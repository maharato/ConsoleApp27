using System.Collections;
using System.Threading.Channels;

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

        List<int> easy_marks = new List<int>();
        List<int> medium_marks = new List<int>();
        List<int> hard_marks = new List<int>();



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
        public List<string>examquestypee(int type) {
            if (type==1) { return easyQuestion; }
            if (type == 2) { return mediumQuestion; }
            if (type == 3) { return hardQuestion; }
            else return easyQuestion;

        }
      
        public void addQuestion(string question, int level, string correctAnswer,int marks)
        {

            switch (level)
            {
                case 1:
                    easyQuestion.Add(question);
                    easyQuestion_correct.Add(correctAnswer);
                    easy_marks.Add(marks);
                    break;
                case 2:
                    mediumQuestion.Add(question);
                    mediumQuestion_correct.Add(correctAnswer);
                    medium_marks.Add(marks);

                    break;
                case 3:
                    hardQuestion.Add(question);
                    hardQuestion_correct.Add(correctAnswer);
                    hard_marks.Add(marks);
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
            bool exit = false;
            questions ques = new questions();
            Console.WriteLine(" please chooce your role 1 doctor " +
                "2 student");
            int role = Convert.ToInt32(Console.ReadLine());
            if (role == 1) {
            while (exit==false)
            {
                

                  


                    Console.WriteLine("please enter number of question");
                int numQuestions = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= numQuestions; i++)
                    {
                        while (i==numQuestions)
                        {
                         exit = true;
                        }

                        string question = "";
                        Console.WriteLine("please enter question type (1: True/False, 2: Choose One, 3: Multiple Choice)");
                        int type = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("please enter question level");
                        Console.WriteLine("1: Easy, 2: Medium, 3: Hard");
                        int level = Convert.ToInt32(Console.ReadLine());





                        if (type == 1)
                        {
                            Console.WriteLine("please enter the question");
                            question = Console.ReadLine();
                            Console.WriteLine("please enter the question marks");
                            int questionMarks = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("please enter correct answer");
                            string correctAnswer = Console.ReadLine();
                            ques.addQuestion(question, level, correctAnswer, questionMarks);

                        }
                        else if (type == 2)
                        {
                            Console.WriteLine("please enter the question");
                            for (i = 0; i <= 4; i++)
                            {
                                if (i >= 1) { Console.WriteLine("enter choice " + i); }
                                question = question + "/n" + Console.ReadLine();
                            }
                            Console.WriteLine("please enter the question marks");
                            int questionMarks = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("please enter correct answer number");

                            string correctAnswer = Convert.ToString(Console.ReadLine());
                            ques.addQuestion(question, level, correctAnswer, questionMarks);
                        }
                        else if (type == 3)
                        {
                            for (i = 0; i <= 4; i++)
                            {
                                if (i >= 1) { Console.WriteLine("enter choice " + i); }
                                question = question + "/n" + Console.ReadLine();
                            }


                            Console.WriteLine("please enter the question marks");
                            int questionMarks = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("please enter correct answer");
                            string correctAnswer = Console.ReadLine();
                            ques.addQuestion(question, level, correctAnswer, questionMarks);
                        }
                    }
                 



                }
            }
            else
            {
                Console.WriteLine("please chooce the type of the exam 1 practical 2 final");

                Console.WriteLine("please chooce the type of exam 1 Easy, 2 Medium,3 Hard");
                int type = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < ques.questionTypee(type).Length; i++) {
                    Console.WriteLine(ques.questionTypee(type)[i]);
                }

 



            }
        }
    }
}
