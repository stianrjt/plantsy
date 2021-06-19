using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plantsy.Shared
{
	public class Plant
	{
		public Guid ID { get; set; }
		public string PlantName { get; set; }
		public string PlantType { get; set; }
		public List<Image> Images { get; set; }
		public List<Water> WaterLog { get; set; }
		public string Info { get; set; }
		public List<Change> ChangeLog { get; set; }
	}
}
