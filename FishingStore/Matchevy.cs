using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	class Matchevy : FishingRod
	{

		public string TypeRod = "Матчеве";
		public string TipsСonnectionName = "З'єднання Вудочки";
		public string TipsСonnection;

		public Matchevy()
		{
			TipsСonnection = ValueOptionalParameter;
		}

		public Matchevy(string name, string brand, string purpose, double lenght, string coil, double price, string description, string tipsСonnection) : base(name, brand, purpose, lenght, coil, price, description)
		{
			TipsСonnection = tipsСonnection;
			ValueOptionalParameter = TipsСonnection;
		}
	}

}
