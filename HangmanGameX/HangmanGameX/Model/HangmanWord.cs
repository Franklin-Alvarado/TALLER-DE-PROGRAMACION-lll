using System;

namespace HangmanGameX.Model
{
	public class HangmanWord
	{
		public HangmanChar[] Chars { get; set; }

		public HangmanWord(string word)
		{
			// Controlar la Exception o mandar un CustomException...
			string upperWord = word.ToUpper();

			this.Chars = new HangmanChar[upperWord.Length];

			for (int i = 0; i < upperWord.Length; i++)
			{
				this.Chars[i] = new HangmanChar(upperWord[i]);
			}
		}

		public bool MatchChar(char attempt)
		{
			bool matched = false;
			char finalChar = Char.ToUpper(attempt);

			foreach (HangmanChar hc in this.Chars)
			{
				if (hc.Contains(finalChar))
				{
					matched = true;
					hc.Hidden = false;
				}
			}

			return matched;
		}

		public override string ToString()
		{
			string[] chars = new string[this.Chars.Length];
			int index = 0;

			foreach (HangmanChar hc in this.Chars)
			{
				chars[index] = hc.ToString();
				index++;
			}

			return string.Join(" ", chars);
		}
	}
}
