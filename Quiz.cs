using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;

        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }

        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the quiz");
            int questionNumber = 1; // display queston numbers

            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}:");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCorrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer was {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResults();
        }

        private void DisplayResults()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                                 Results                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.WriteLine($"Quiz Complete. Your Score: {_score} out of {_questions.Length}");
            double percentage = (double)_score / _questions.Length;
            if (percentage >= 0.8)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent work you passed");
            }
            else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You failed");
            } 
            Console.ResetColor();
        }

        private void DisplayQuestion(Question question)
                {
            Thread.Sleep(1000); // wait for 1 second

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                              Question                                   ║");
                    Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════╝");
                    Console.ResetColor();

            Console.WriteLine(question.QuestionText);

                    for (int i = 0; i < question.Answers.Length; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan; // changes the text color
                        Console.Write("   ");
                        Console.Write(i + 1);
                        Console.ResetColor();   // reset the foreground (text) color
                        Console.WriteLine($". {question.Answers[i]}");
                    }
                }

        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid option selected. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }
            return choice - 1;  // adjust to 0-indexed array because the user sees 1-4

        }

    }
}
