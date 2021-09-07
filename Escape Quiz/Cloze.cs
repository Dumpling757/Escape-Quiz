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
            Regex r = new Regex(regexString);
            // Match target = ;
           // MatchEvaluator evaluator = new MatchEvaluator(target);
            // TODO Input normalisieren / auf leichte Fehler ueberpruefen.

            return input;
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
 *  /