using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] questions;

        public Quiz(Question[] questions)
        {
            this.questions = questions;
        }

        public void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                              Question 1                                 ║");
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

            if (GetUserChoice() == question.CorrectAnswerIndex)
            {
                Console.WriteLine("Correct");
            }else
            {
                Console.WriteLine("Incorrect");
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
