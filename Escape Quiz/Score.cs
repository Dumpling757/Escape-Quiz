using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Escape_Quiz
{
    class Score
    {
        private static int finalScore;
        public static Brush Right { get => new SolidColorBrush(Colors.Green); }
        public static Brush Wrong { get => new SolidColorBrush(Colors.Red); }

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
