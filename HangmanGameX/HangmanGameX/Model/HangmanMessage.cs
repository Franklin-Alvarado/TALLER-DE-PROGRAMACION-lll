namespace HangmanGameX.Model
{
	public class HangmanMessage
	{
		public HangmanWord[] Words { get; set; }
		
		// Message: @@@ @@@ @@@@@
		public HangmanMessage(string message)
		{
			string[] words = message.Split(' ');

			this.Words = new HangmanWord[words.Length];

			for (int i = 0; i < words.Length; i++)
			{
				this.Words[i] = new HangmanWord(words[i]);
			}
		}

		public bool MatchChar(char attempt)
		{
			bool matched = false;
			foreach (HangmanWord hw in this.Words)
			{
				if (hw.MatchChar(attempt))
				{
					matched = true;
				}
			}

			return matched;
		}

		public override string ToString()
		{
			string[] words = new string[this.Words.Length];
			int index = 0;

			foreach (HangmanWord hw in this.Words)
			{
				words[index] = hw.ToString();
				index++;
			}

			return string.Join("     ", words);
		}
	}
}
