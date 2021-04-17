using System.Collections.Generic;

namespace GameManager.Core {
	public class Config {
		private Dictionary<string, ConfigEntry> _config { get; set; } = new() {
			{ "pepega", new ConfigEntry() }
		};
	}

	public class ConfigEntry {
		public ConfigEntryType Type { get; set; }
		public string Id { get; set; }
		public string Label { get; set; }
		public string Description { get; set; }
		public object Value { get; set; }
		public object DefaultValue { get; set; }
		public bool Enabled { get; set; } = true;
	}

	public enum ConfigEntryType {
		String,
		Int,
		Float,
		Dropdown,
		Path,
		Boolean,
		Table
	}

	public class ConfigTableValue {
		public ConfigEntry[] Columns { get; set; }
		public List<ConfigTableRow> Rows { get; set; }
	}

	public class ConfigTableRow {

	}
}
