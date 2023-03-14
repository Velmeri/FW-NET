using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FW_NET
{
    class Quiz
    {
        private List<Question> _questions;

        public Quiz(List<Question> questions)
        {
            _questions = questions;
        }

        public void Start()
        {
            Scoring scoring = new Scoring();
            int option;

            for (int i = 0; i < _questions.Count(); i++)
            {
                option = QuizInterfase.SelectOption(_questions[i]);

                if (_questions[i][option].IsAnswer())
                {
                    Sound.PlaySound("correct answer");
                    scoring.AddScore(10);
                }
                else
                {
                    Sound.PlaySound("incorrect unswer");
                }
            }

            Console.Clear();
            scoring.DisplayScore();
        }
    }
}