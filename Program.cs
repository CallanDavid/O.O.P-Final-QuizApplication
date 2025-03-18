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
                1),  // CorrectAnswerIndex

                new Question("What is 2 + 2?",
                new string[] { "3", "5", "6", "4" },
                3),

                new Question("Who wrote the play Hamlet?",
                new string[] { "Robert Downey Junior", "Cyril Ramaphosa", "Shakespear", "Dickens" },
                2)
            };
            
            Quiz myQuiz = new Quiz(questions);
            myQuiz.StartQuiz();

            Console.ReadKey();
        }
    }
}
