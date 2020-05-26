using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingStore
{
	public partial class SortForm : Form
	{
		public List<FishingRod> fishingRods;

		public SortForm()
		{
			InitializeComponent();
		}

		private void Sort_Click(object sender, EventArgs e)
		{
			if (typeRod.Text != "Не вказано")
			{
				switch (typeRod.Text)
				{
					case "Спінінгове":
						SerchCharecteristicTypeRod("Spining");
						break;
					case "Фідерне":
						SerchCharecteristicTypeRod("Fiderni");
						break;
					case "Поплавкове":
						SerchCharecteristicTypeRod("Poplavkovi");
						break;
					case "Махове":
						SerchCharecteristicTypeRod("Makhovi");
						break;
					case "Матчеве":
						SerchCharecteristicTypeRod("Matchevy");
						break;
					case "Зимове":
						SerchCharecteristicTypeRod("Winter");
						break;
				}
			}
			if (nameBrand.Text != "Не вказано")
			{
				for (int i = 0; i < fishingRods.Count; i++)
				{
					if (fishingRods[i].Brand != nameBrand.Text)
					{
						fishingRods.RemoveAt(i);
					}
				}
			}

			if (purpose.Text != "Не вказано")
			{
				for (int i = 0; i < fishingRods.Count; i++)
				{
					if (fishingRods[i].Coil != purpose.Text)
					{
						fishingRods.RemoveAt(i);
					}
				}
			}

			if (coil.Text != "Не вказано")
			{
				for (int i = 0; i < fishingRods.Count; i++)
				{
					if (fishingRods[i].Coil != coil.Text)
					{
						fishingRods.RemoveAt(i);
					}
				}
			}

			double text;
			if (double.TryParse(lenght.Text, out text ))
			{
				text = Convert.ToDouble(lenght.Text);
				for (int i = 0; i < fishingRods.Count; i++)
				{
					if (fishingRods[i].Lenght != text)
					{
						fishingRods.RemoveAt(i);
					}
				}
			}
			double text1;
			double text2;
			if (double.TryParse(priceMin.Text, out text1) || double.TryParse(priceMax.Text, out text2))
			{
				text1 = Convert.ToDouble(priceMin.Text);
				text2 = Convert.ToDouble(priceMax.Text);
				for (int i = 0; i < fishingRods.Count; i++)
				{
					if (fishingRods[i].Price >=text1 && fishingRods[i].Price <= text2)
					{
						fishingRods.RemoveAt(i);
					}
				}
			}
			MainMenu mainMenu = Program.mainMenu;
			mainMenu.sortFishingRods = fishingRods;
			mainMenu.Update();
			this.Close();
		}

		private void SerchCharecteristicTypeRod(string text)
		{
			for (int i = 0; i < fishingRods.Count; i++)
			{
				if (fishingRods[i].GetType().Name != text)
				{
					fishingRods.RemoveAt(i);
					i--;
				}
			}
		}

		private void SortForm_Load(object sender, EventArgs e)
		{

		}
	}
}
