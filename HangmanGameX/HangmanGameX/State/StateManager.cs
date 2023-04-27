namespace HangmanGameX.State
{
	public class StateManager
	{
		private int CurrentIndex { get; set; }
		private IHangmanState[] StateList { get; set; }

		public IHangmanState CurrentState
		{
			get
			{
				return this.StateList[this.CurrentIndex];
			}
		}

		public StateManager()
		{
			this.CurrentIndex = 0;
			this.StateList = new IHangmanState[]
			{
				new EmptyState(),
				new HeadState(),
				new TorsoState(),
				new RightArmState(),
				new LeftArmState(),
				new RightLegState(),
				new LeftLegState()
			};
		}

		public void GoToNextState()
		{
			this.CurrentIndex++;
		}

		public bool IsLastState()
		{
			return (this.CurrentState.GetType() == typeof(LeftLegState));
		}
	}
}
