# Quiz Application

<sub>Documentation drafted with claude.ai</sub>

A console quiz app, written as the final exercise for the OOP section of a C# course.
The whole point was separating the data from the behaviour rather than doing it all
in `Main`.

## Structure

- `Question.cs` - question text, the answer options, and the index of the correct one
- `Quiz.cs` - holds the questions, runs the loop, tracks the score, draws the output
- `Program.cs` - builds the question set and starts the quiz

## Running it

    dotnet run

Targets .NET 9.
