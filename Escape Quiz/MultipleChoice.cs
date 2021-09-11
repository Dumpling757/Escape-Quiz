using System;

// Datentyp zur Interaktion mit einer Multiple / Single Choice Frage
public class MultipleChoice
{
	// enthaelt welche Antwort die richtige ist.
	private bool[] optionsTrue;

	// Antwortinhalt
	private string[] options;

	// Ob es Single oder Multiple Choice ist
	private bool singleAnswer;



	public MultipleChoice(bool singleAnswer, string[] answerStrings)
	{
		// Uebergabe des Parameters zur weiteren Verwendung
		this.singleAnswer = singleAnswer;

		// befuellen des Antworten Arrays mit einem Array aus der urspruenglichen Datenquelle
		foreach (String answerstring in answerStrings)
		{
			options.Append(answerstring);
			
		}
	}


	// Ueberprueft ob die gegebene Antwort richtig ist.
	public bool CheckAnswer(bool[] answers)
	{
		if (singleAnswer)
		{
			// Uebergibt die Richtigkeit der Antworten ins Objekt
			foreach (bool answerbool in answers)
			{
				optionsTrue.Append(answerbool);
			}

			// Geht das Antwortenstring Array durch und schaut ob an der Stelle
			// im AntwortenwahrheitenArray vermekt ist, ob die Antwort richtig ist.
			for (int i = 0; i < options.Length; i++)
			{

				if (optionsTrue[i])
				{
					// TODO moegliche Farbaenderung fuer Richtigkeitsindikations
					return true;
				}
				else {
                }

			}
			// TODO nicht sicher ob das hier gut ist, da eigentlich ein Match gefunden werden sollte.
			return false;
		}
		else {
			// TODO Logik implementieren wie bei echter Multiple Choice zu agieren ist.
			return false;
		}

		// TODO CheckAnswers() Logik wenn geklaert ist wie eine Antwort uebermittelt wird
		
	}
}
