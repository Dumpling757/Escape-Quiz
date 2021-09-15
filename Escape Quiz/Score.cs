using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Quiz
{
    class Score
    {
        private int finalScore;

        public Score()
        {
            finalScore = 0;
        }

        public void OneUp()
        {
            finalScore++;
        }

        public int getScore()
        {
            return finalScore;
        }
    }
}
