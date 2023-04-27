using System.Text;

namespace HangmanGameX.State
{
	public class EmptyState : IHangmanState
	{
		public string GetRepresentation()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine(" ____");
			sb.AppendLine("|    |");
			sb.AppendLine("|");
			sb.AppendLine("|");
			sb.AppendLine("|");
			sb.AppendLine("|");
			sb.AppendLine("|");
			sb.AppendLine("|____________________");

			return sb.ToString();
		}
	}
}
