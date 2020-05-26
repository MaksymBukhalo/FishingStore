using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	class Fiderni : FishingRod
	{
		public string TypeRod = "Фідерне";
		public string FiderBuildName = "Будова Фідера";
		public string FiderBuild;

		public Fiderni()
		{
			FiderBuild = ValueOptionalParameter;
		}
		public Fiderni(string name, string brand, string purpose, double lenght, string coil, double price, string description, string fiderbuild) : base(name, brand, purpose, lenght, coil, price, description)
		{
			FiderBuild = fiderbuild;
			ValueOptionalParameter = FiderBuild;
		}
	}
}
