namespace GameManager.Core {
	public delegate void OnStartingDelegate();
	public delegate void OnStartedDelegate();
	public delegate void OnStoppingDelegate();
	public delegate void OnStoppedDelegate();

	public class App {
		public event OnStartingDelegate OnStarting;
		public event OnStartedDelegate OnStarted;
		public event OnStoppingDelegate OnStopping;
		public event OnStoppedDelegate OnStopped;

		public Config Config { get; set; }

		public string Label { get; set; }
		public string Description { get; set; }

		public IRunner Runner { get; set; }

		public void Run() {}
	}
}
