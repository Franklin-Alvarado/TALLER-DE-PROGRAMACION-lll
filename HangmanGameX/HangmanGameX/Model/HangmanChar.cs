namespace HangmanGameX.Model
{
	public class HangmanChar
	{
		private char Base { get; set; }
		public bool Hidden { get; set; }
		public char VisibleChar
		{
			get
			{
				return (this.Hidden) ? '_' : this.Base;
			}
		}

		public HangmanChar(char originalChar)
		{
			this.Base = originalChar;
			this.Hidden = true;
		}

		public bool Contains(char someChar)
		{
			return (this.Base == someChar);
		}

		public override string ToString()
		{
			return this.VisibleChar.ToString();
		}
	}
}
