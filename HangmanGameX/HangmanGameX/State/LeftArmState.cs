using System.Text;

namespace HangmanGameX.State
{
	public class LeftArmState : IHangmanState
	{
		public string GetRepresentation()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(" ____");
			sb.AppendLine("|    |");
			sb.AppendLine("|    O");
			sb.AppendLine("|   /|\\");
			sb.AppendLine("|    |");
			sb.AppendLine("|");
			sb.AppendLine("|");
			sb.AppendLine("|____________________");

			return sb.ToString();
		}
	}
}
