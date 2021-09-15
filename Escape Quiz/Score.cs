using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Quiz
{
    class Score
    {
        private static int finalScore;

        public Score()
        {
            finalScore = 0;
        }

        public static void OneUp()
        {
            finalScore++;
        }

        public static int GetScore()
        {
            return finalScore;
        }
    }
}
