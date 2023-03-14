using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_NET
{
    interface IPool
    {
        int GetSize();

        Subject this[int index] { get; }
    }

    public class SubjectPool : IPool
    {
        private readonly List<Subject> _subjects;
        
        public SubjectPool(List<Subject> subjects) { 
            _subjects = subjects; 
        }

        public void addSubject (Subject subject)
        {
            _subjects.Add(subject);
        }

        public int GetSize()
        {
            return _subjects.Count;
        }

        public Subject this[int index] { 
            get {
                return _subjects[index];
            } 
        }
    }

    public class Subject
    {
        public string Name { get; }
        private readonly List<Question> _questions;

        public Subject(string name, List<Question> questions)
        {
            Name = name;
            _questions = questions;
        }

        public void addQuestion(Question question)
        {
            _questions.Add(question);
        }

        public int GetSize()
        {
            return _questions.Count();
        }

        public Question this[int index]
        {
            get
            {
                return _questions[index];
            }
        }
    }

    public class Question
    {
        private readonly List<Answer> _answers;

        public string Text { get; }

        public Question(string text, List<Answer> answers)
        {
            Text = text;
            _answers = answers;
        }

        public void AddAnswer(Answer answer)
        {
            _answers.Add(answer);
        }

        public int GetAnswersCount()
        {
            return _answers.Count;
        }

        public Answer this[int index] 
            {
            get
            {
                return _answers[index];
            }
        }
    }
    
    public class Answer
    {
        public string Text { get; }

        private bool _isAnswer;

        public Answer(string text, bool isAnswer)
        {
            Text = text;
           _isAnswer = isAnswer;
        }

        public bool IsAnswer()
        {
            return _isAnswer;
        }

    }
}
