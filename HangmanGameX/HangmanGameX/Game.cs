using HangmanGameX.Model;
using HangmanGameX.State;
using System.Collections.Generic;

namespace HangmanGameX
{
	public class Game
	{
		private HangmanMessage Message { get; set; }
		private StateManager StateManager { get; set; }
		private HashSet<char> UsedChars { get; set; }

		public Game(string message)
		{
			this.Message = new HangmanMessage(message);
			this.StateManager = new StateManager();
			this.UsedChars = new HashSet<char>();
		}

		private void DisplayHang()
		{
			System.Console.WriteLine(this.StateManager.CurrentState.GetRepresentation());
		}

		private void DisplayMessage()
		{
			System.Console.WriteLine("MESSAGE: {0}", this.Message);
		}

		private void DisplayUsedChars()
		{
			System.Console.WriteLine("USADOS: [{0}]", string.Join("][", this.UsedChars));
		}

		private void DisplayGame()
		{
			System.Console.Clear();

			this.DisplayHang();

			this.DisplayMessage();

			this.DisplayUsedChars();

			// This should end the game
			if (this.StateManager.IsLastState())
			{
				System.Console.WriteLine("\n\n******************************");
				System.Console.WriteLine("*         GAME  OVER         *");
				System.Console.WriteLine("******************************");
			}
			else
			{
				this.CaptureKey();
			}
		}

		private void HandleValidInput(char inputChar)
		{
			// Update the UsedChars
			this.UsedChars.Add(inputChar);

			// Do we have match?
			if (!this.Message.MatchChar(inputChar))
			{
				this.StateManager.GoToNextState();
			}

			// Update the Game
			this.DisplayGame();
		}

		private void HandleInvalidInput(string input)
		{
			System.Console.ForegroundColor = System.ConsoleColor.Red;
			System.Console.WriteLine("Letra no valida: [{0}]\n", input);
			System.Console.ForegroundColor = System.ConsoleColor.White;
			this.CaptureKey();
		}

		private void CaptureKey()
		{
			System.Console.WriteLine("\nIntroduce una letra: ");
			string input = System.Console.ReadLine();

			if (!string.IsNullOrWhiteSpace(input) && input.Length == 1)
			{
				this.HandleValidInput(input.ToUpper()[0]);
			}
			else
			{
				this.HandleInvalidInput(input);
			}
		}

		public void Start()
		{
			this.DisplayGame();
		}
	}
}
