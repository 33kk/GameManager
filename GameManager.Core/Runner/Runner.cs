namespace GameManager.Core {
	public interface IRunner {
		public Config Config { get; set; }

		public string Label { get; set; }
		public string Description { get; set; }
	}
}
