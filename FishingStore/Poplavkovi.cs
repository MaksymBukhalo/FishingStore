using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	class Poplavkovi : FishingRod
	{
		public string TypeRod = "Поплавкове";
		public string TipsBuildName = "Будова Кінчика";
		public string TipsBuild;

		public Poplavkovi()
		{
			TipsBuild = ValueOptionalParameter;
		}

		public Poplavkovi(string name, string brand, string purpose, double lenght, string coil, double price, string description, string tipsBuild) : base(name, brand, purpose, lenght, coil, price, description)
		{
			TipsBuild = tipsBuild;
			ValueOptionalParameter = TipsBuild;
		}

		public override string GetTypeRoad()
		{
			return "Поплавкове";
		}
	}
}

