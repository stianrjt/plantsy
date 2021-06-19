using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Plantsy.Shared
{
	public class Image
	{
		public Guid ID { get; set; }
		public Guid PlantID { get; set; }
		public string ImagePath { get; set; }
		public string ImageName { get; set; }
	}
}
