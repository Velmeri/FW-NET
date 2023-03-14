using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sound.AddSound("correct answer", @"Sound\good.wav");
            Sound.AddSound("incorrect unswer", @"Sound\wrong.wav");

            // Video Games Questions
            List<Question> videoGamesQuestions = new List<Question>();

            List<Answer> vgq1Answers = new List<Answer>();
            vgq1Answers.Add(new Answer("Minecraft", false));
            vgq1Answers.Add(new Answer("Tetris", false));
            vgq1Answers.Add(new Answer("Grand Theft Auto V", true));
            vgq1Answers.Add(new Answer("Wii Sports", false));
            videoGamesQuestions.Add(new Question("What is the best-selling video game of all time?", vgq1Answers));

            List<Answer> vgq2Answers = new List<Answer>();
            vgq2Answers.Add(new Answer("Pong", true));
            vgq2Answers.Add(new Answer("Space Invaders", false));
            vgq2Answers.Add(new Answer("Pac-Man", false));
            vgq2Answers.Add(new Answer("Donkey Kong", false));
            videoGamesQuestions.Add(new Question("What was the first video game ever made?", vgq2Answers));

            List<Answer> vgq3Answers = new List<Answer>();
            vgq3Answers.Add(new Answer("Pokemon", true));
            vgq3Answers.Add(new Answer("Call of Duty", false));
            vgq3Answers.Add(new Answer("Mario", false));
            vgq3Answers.Add(new Answer("Grand Theft Auto", false));
            videoGamesQuestions.Add(new Question("What is the highest-grossing video game franchise?", vgq3Answers));

            List<Answer> vgq4Answers = new List<Answer>();
            vgq4Answers.Add(new Answer("1989", false));
            vgq4Answers.Add(new Answer("1990", true));
            vgq4Answers.Add(new Answer("1991", false));
            vgq4Answers.Add(new Answer("1992", false));
            videoGamesQuestions.Add(new Question("What year was the first Nintendo Game Boy released?", vgq4Answers));

            List<Answer> vgq5Answers = new List<Answer>();
            vgq5Answers.Add(new Answer("Mario", false));
            vgq5Answers.Add(new Answer("Sonic", true));
            vgq5Answers.Add(new Answer("Crash Bandicoot", false));
            vgq5Answers.Add(new Answer("Donkey Kong", false));
            videoGamesQuestions.Add(new Question("What is the name of the main character in the Sonic the Hedgehog series?", vgq5Answers));

            Subject VideoGames = new Subject("Video games", videoGamesQuestions);

            // Programming Questions (continued)
            List<Question> programmingQuestions = new List<Question>();

            List<Answer> pq1Answers = new List<Answer>();
            pq1Answers.Add(new Answer("A stack is last-in, first-out (LIFO) and a queue is first-in, first-out (FIFO)", true));
            pq1Answers.Add(new Answer("A stack is first-in, first-out (FIFO) and a queue is last-in, first-out (LIFO)", false));
            pq1Answers.Add(new Answer("A stack and a queue are the same thing", false));
            pq1Answers.Add(new Answer("A stack and a queue have nothing to do with programming", false));
            programmingQuestions.Add(new Question("What is the difference between a stack and a queue?", pq1Answers));

            List<Answer> pq2Answers = new List<Answer>();
            pq2Answers.Add(new Answer("A binary tree is a tree data structure in which each node has at most two children", true));
            pq2Answers.Add(new Answer("A binary tree is a data structure that can only store binary data", false));
            pq2Answers.Add(new Answer("A binary tree is a tree data structure in which each node has at least two children", false));
            pq2Answers.Add(new Answer("A binary tree is a type of sorting algorithm", false));
            programmingQuestions.Add(new Question("What is a binary tree and how does it work?", pq2Answers));

            List<Answer> pq3Answers = new List<Answer>();
            pq3Answers.Add(new Answer("Object-Oriented Programming", true));
            pq3Answers.Add(new Answer("Procedural Programming", false));
            pq3Answers.Add(new Answer("Functional Programming", false));
            pq3Answers.Add(new Answer("Structured Programming", false));
            programmingQuestions.Add(new Question("What is the name of the programming paradigm that emphasizes encapsulating data and behavior into objects?", pq3Answers));

            List<Answer> pq4Answers = new List<Answer>();
            pq4Answers.Add(new Answer("Recursion is a technique in which a function calls itself", true));
            pq4Answers.Add(new Answer("Recursion is a technique in which two or more functions call each other", false));
            pq4Answers.Add(new Answer("Recursion is a technique for creating infinite loops", false));
            pq4Answers.Add(new Answer("Recursion is a programming language used for scientific computing", false));
            programmingQuestions.Add(new Question("What is recursion and how is it used in programming?", pq4Answers));

            List<Answer> pq5Answers = new List<Answer>();
            pq5Answers.Add(new Answer("A programming paradigm is a way of classifying programming languages and techniques based on their features and approaches to problem-solving", true));
            pq5Answers.Add(new Answer("A programming paradigm is a type of sorting algorithm", false));
            pq5Answers.Add(new Answer("A programming paradigm is a way of organizing code into reusable modules", false));
            pq5Answers.Add(new Answer("A programming paradigm is a method for generating random numbers", false));
            programmingQuestions.Add(new Question("What is a programming paradigm and what are some examples of common programming paradigms?", pq5Answers));

            Subject Programming = new Subject("Programming", programmingQuestions);

            // Historical Questions
            List<Question> historyQuestions = new List<Question>();

            List<Answer> hq1Answers = new List<Answer>();
            hq1Answers.Add(new Answer("The Enlightenment", true));
            hq1Answers.Add(new Answer("The Renaissance", false));
            hq1Answers.Add(new Answer("The Industrial Revolution", false));
            hq1Answers.Add(new Answer("The Age of Exploration", false));
            historyQuestions.Add(new Question("Which period of European history in the 18th century emphasized reason, individualism, and skepticism?", hq1Answers));

            List<Answer> hq2Answers = new List<Answer>();
            hq2Answers.Add(new Answer("American Civil War", true));
            hq2Answers.Add(new Answer("World War I", false));
            hq2Answers.Add(new Answer("World War II", false));
            hq2Answers.Add(new Answer("Vietnam War", false));
            historyQuestions.Add(new Question("What was the name of the war fought in the United States from 1861-1865, primarily over the issue of slavery?", hq2Answers));

            List<Answer> hq3Answers = new List<Answer>();
            hq3Answers.Add(new Answer("The French Revolution", true));
            hq3Answers.Add(new Answer("The English Civil War", false));
            hq3Answers.Add(new Answer("The Hundred Years' War", false));
            hq3Answers.Add(new Answer("The War of the Roses", false));
            historyQuestions.Add(new Question("What was the name of the period of radical social and political upheaval that occurred in France from 1789-1799?", hq3Answers));

            List<Answer> hq4Answers = new List<Answer>();
            hq4Answers.Add(new Answer("Martin Luther", true));
            hq4Answers.Add(new Answer("John Calvin", false));
            hq4Answers.Add(new Answer("John Knox", false));
            hq4Answers.Add(new Answer("Thomas Cranmer", false));
            historyQuestions.Add(new Question("Who was the German monk and theologian who began the Protestant Reformation by nailing his Ninety-Five Theses to the door of a church in Wittenberg in 1517?", hq4Answers));

            List<Answer>  hq5Answers = new List<Answer>();
            hq5Answers.Add(new Answer("Magna Carta", true));
            hq5Answers.Add(new Answer("Bill of Rights", false));
            hq5Answers.Add(new Answer("Declaration of Independence", false));
            hq5Answers.Add(new Answer("U.S. Constitution", false));
            historyQuestions.Add(new Question("What is the name of the document signed by King John of England in 1215 that limited the power of the monarch and guaranteed certain rights to the people?", hq5Answers));

            Subject History = new Subject("History", historyQuestions);

            List<Subject> subjects = new List<Subject>();
            subjects.Add(VideoGames);
            subjects.Add(Programming);
            subjects.Add(History);

            SubjectPool SP = new SubjectPool(subjects);

            Quiz quiz = QuizInterfase.Start(SP);
            quiz.Start();

            Console.ReadKey();
        }
    }
}
