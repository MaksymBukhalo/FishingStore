using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	class Makhovi : FishingRod
	{
		public string TypeRod = "Махове";
		public string TipsBuildName = "Будова Вудочки";
		public string TipsBuild;

		public Makhovi()
		{
			TipsBuild = ValueOptionalParameter;
		}

		public Makhovi(string name, string brand, string purpose, double lenght, string coil, double price, string description, string tipsBuild) : base(name, brand, purpose, lenght, coil, price, description)
		{
			TipsBuild = tipsBuild;
			ValueOptionalParameter = TipsBuild;
		}

		public override string GetTypeRoad()
		{
			return "Махове";
		}
	}
}
