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
        /*
         * Alle Attribute hier sind statisch, damit es nur die eine Instanz dieser Klasse existiert und nur über Score.* angesprochen werden muss.
         */

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
