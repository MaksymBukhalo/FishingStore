using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingStore
{
	public class FishingRod
	{
		public string Name;
		public string Brand;
		public string Purpose;
		public double Lenght;
		public string Coil;
		public double Price;
		public string ValueOptionalParameter;
		protected string Description;

		public string DescriptionValue
		{
			get
			{
				return Description;
			}

			set
			{
				Description = value;
			}
		}

		public FishingRod()
		{
			Name = "No Name";
			Brand = "No Name";
			Purpose = "Not Indicated";
			Lenght = 0;
			Coil = "Not Indicated";
			Price = 0;
			Description = "No Description";
			ValueOptionalParameter = "Not Indicated";
		}
	

		public FishingRod(string name)
		{
			Name = name;
		}

		public FishingRod(string name, string brand)
		{
			Name = name;
			Brand = brand;
		}

		public FishingRod(string name, string brand, string purpose)
		{
			Name = name;
			Brand = brand;
			Purpose = purpose;
		}

		public FishingRod(string name, string brand, string purpose, double lenght)
		{
			Name = name;
			Brand = brand;
			Purpose = purpose;
			Lenght = lenght;
		}

		public FishingRod(string name, string brand, string purpose, double lenght,string coil)
		{
			Name = name;
			Brand = brand;
			Purpose = purpose;
			Lenght = lenght;
			Coil = coil;
		}

		public FishingRod(string name, string brand, string purpose, double lenght, string coil,double price)
		{
			Name = name;
			Brand = brand;
			Purpose = purpose;
			Lenght = lenght;
			Coil = coil;
			Price = price;
		}

		public FishingRod(string name, string brand, string purpose, double lenght, string coil, double price, string description)
		{
			Name = name;
			Brand = brand;
			Purpose = purpose;
			Lenght = lenght;
			Coil = coil;
			Price = price;
			Description = description;
		}
	}
}
