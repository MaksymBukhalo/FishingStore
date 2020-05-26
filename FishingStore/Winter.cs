using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	class Winter :FishingRod
	{
		public string TypeRod = "Зимове";
		public string TipsBuildName = "Будова Вудочки";
		public string TipsBuild;

		public Winter()
		{
			TipsBuild = ValueOptionalParameter;
		}

		public Winter(string name, string brand, string purpose, double lenght, string coil, double price, string description, string tipsBuild) : base(name, brand, purpose, lenght, coil, price, description)
		{
			TipsBuild = tipsBuild;
			ValueOptionalParameter = tipsBuild;
		}

		public override string GetTypeRoad()
		{
			return "Зимове";
		}
	}

}
