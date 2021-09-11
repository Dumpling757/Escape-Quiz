using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Escape_Quiz
{
    class Cloze
    {

        // Wird verwendet um Input zu normalisieren / auf leichte Fehler zu ueberpruefen.
        public string NormalizeInput(string input)
        {
            input.ToLower();
            string regexString = "[^A-Za-z0-9]";
            Regex r = new Regex(regexString, RegexOptions.IgnoreCase);
            MatchEvaluator matchEvaluator = new MatchEvaluator(ReplaceWithBlank);
            r.Replace(input, matchEvaluator);
            
            
            // TODO Input normalisieren / auf leichte Fehler ueberpruefen.

            return input;
        }

        public string ReplaceWithBlank(Match m)
        {
            return " ";
        }
    }
}


/*
 * Frame
 * Create View Folder
 * 
 * 
 * In Button
 *  this.MainFrame.Navigate(new Quiz1View);
 */