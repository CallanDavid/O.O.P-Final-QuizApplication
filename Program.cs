using MyQuizApp;
using System.ComponentModel.DataAnnotations;

namespace Adv.QuizAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question[] questions = new Question[]
            {
                new Question("What is the capital of Germany?",  // passing Question Text
                new string[] { "Paris", "Berlin", "London", "Madrid" },     // passing Answers Array
                1)  // CorrectAnswerIndex
            };

            Quiz myQuiz = new Quiz(questions);
            myQuiz.DisplayQuestion(questions[0]);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
