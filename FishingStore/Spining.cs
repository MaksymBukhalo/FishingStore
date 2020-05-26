using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	public class Spining : FishingRod
	{
		public string TypeRod = "Спінінгове";
		public string SpinningClasName = "Клас Спінінга";
		public string SpinningClas;

		public Spining()
		{
			SpinningClas = ValueOptionalParameter;
		}

		public Spining(string name, string brand, string purpose, double lenght, string coil, double price, string description,  string spinningclas) : base(name, brand, purpose, lenght, coil,  price,description)
		{
			SpinningClas = spinningclas;
			ValueOptionalParameter = spinningclas;
		}

		public override string GetTypeRoad()
		{
			return "Спінінгове";
		}
	}
}
