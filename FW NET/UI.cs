using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FW_NET
{
    static class QuizInterfase
    {
        public static Quiz Start(SubjectPool SP)
        {
            Random random = new Random();
            string[] options = new string[] { "Subject", "Number of questions", "Start" };
            int selectedOptionIndex = 0;
            ConsoleKeyInfo keyInfo;
            int SelectedSubject = 0;
            int QuestionNum = 1;
            string subject = SP[0].Name;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Select an option using the up/down arrow keys and change the value using the left/right arrow keys:");
                Console.WriteLine();

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selectedOptionIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (i != 2)
                    {
                        Console.WriteLine($"{options[i]}: {(i == 0 ? SP[SelectedSubject].Name : QuestionNum.ToString())}");
                    }
                    else
                    {
                        Console.WriteLine($"{options[i]}");
                    }
                    Console.ResetColor();
                }

               keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedOptionIndex = (selectedOptionIndex == 0) ? options.Length - 1 : selectedOptionIndex - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedOptionIndex = (selectedOptionIndex == options.Length - 1) ? 0 : selectedOptionIndex + 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (selectedOptionIndex == 0)
                        {
                            SelectedSubject = (SelectedSubject == 0 ? SP.GetSize() - 1 : SelectedSubject - 1);
                        }
                        else if (selectedOptionIndex == 1)
                        {
                            QuestionNum = (QuestionNum == 1 ? QuestionNum = SP[SelectedSubject].GetSize() : QuestionNum - 1);
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (selectedOptionIndex == 0)
                        {
                            SelectedSubject = (SelectedSubject == SP.GetSize() - 1 ? 0 : SelectedSubject + 1);
                        }
                        else if (selectedOptionIndex == 1)
                        {
                            QuestionNum = (QuestionNum == SP[SelectedSubject].GetSize() ? QuestionNum = QuestionNum = 1  : QuestionNum + 1);
                        }
                        break;
                    case ConsoleKey.Enter:
                        if(selectedOptionIndex == 2)
                        {
                            List<Question> questions = new List<Question>();
                            
                            for(int i = 0; i < QuestionNum; i++)
                            {
                                int num = random.Next(0, SP[SelectedSubject].GetSize() - 1);

                                questions.Add(SP[SelectedSubject][num]);
                            }
                            return new Quiz(questions);
                        }
                        break;
                }
            }
        }

        public static int SelectOption(Question question)
        {
            int selectedOptionIndex = 0;
            ConsoleKeyInfo keyInfo;
            List<string> options = new List<string>();
            for(int i = 0; i < question.GetAnswersCount(); i++)
            {
                options.Add(question[i].Text);
            }

            while (true)
            {
                Console.Clear();
                Console.WriteLine(question.Text);
                for (int i = 0; i < options.Count; i++)
                {
                    if (i == selectedOptionIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine($"{i + 1}. {options[i]}");
                    Console.ResetColor();
                }

                keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedOptionIndex = (selectedOptionIndex == 0) ? options.Count - 1 : selectedOptionIndex - 1;
                        break;
                    case ConsoleKey.DownArrow:
                        selectedOptionIndex = (selectedOptionIndex == options.Count - 1) ? 0 : selectedOptionIndex + 1;
                        break;
                    case ConsoleKey.Enter:
                        return selectedOptionIndex;
                }
            }
        }
    }
}
