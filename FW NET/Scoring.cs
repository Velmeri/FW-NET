using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW_NET
{
    class Scoring
    {
        private int _score;

        public Scoring()
        {
            _score = 0;
        }

        public void AddScore(int points)
        {
            _score += points;
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Score: {_score}");
        }
    }
}
