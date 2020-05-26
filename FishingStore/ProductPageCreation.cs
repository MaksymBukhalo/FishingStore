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
	public partial class ProductPageCreation : Form
	{
		public List<FishingRod> fishingRods;
		public List<FishingRod> thisFishingRods;

		public ProductPageCreation()
		{
			InitializeComponent();
		}

		private void ProductPageCreation_Load(object sender, EventArgs e)
		{
			TypeCheck();
		}

		public void TypeCheck()
		{
			switch (this.typeRod.Text)
			{
				case "Спінінгове":
					optionalParameter.Text = "Клас Спінінга";
					valueOptionalParameter.Items.AddRange(new object[] { "Ультралегкий ", "Легкий", "Середній", "Важкий", });
					break;
				case "Фідерне":
					optionalParameter.Text = "Будова Фідера";
					valueOptionalParameter.Items.AddRange(new object[] { "Швидкий ", "Середній", "Повільний" });
					break;
				case "Поплавкове":
					optionalParameter.Text = "Будова Кінчика";
					valueOptionalParameter.Items.AddRange(new object[] { "Монолітний ", "Комбінований", "Порожній" });
					break;
				case "Махове":
					optionalParameter.Text = "Будова Вудочки";
					valueOptionalParameter.Items.AddRange(new object[] { "Швидка ", "Середня", "Повільна" });
					break;
				case "Матчеве":
					optionalParameter.Text = "З'єднання Вудочки";
					valueOptionalParameter.Items.AddRange(new object[] { "Штекерне ", "Телескопічне" });
					break;
				case "Зимове":
					optionalParameter.Text = "Будова Вудочки";
					valueOptionalParameter.Items.AddRange(new object[] { "Класична", "«Балалайка»", "Блеснілка" });
					break;
			}
			
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			switch (this.typeRod.Text)
			{
				case "Спінінгове":
					Spining spining = new Spining();
					SaveCharacteristics(spining);
					spining.SpinningClas = valueOptionalParameter.Text;
					spining.ValueOptionalParameter = spining.SpinningClas;
					AddNewFishingRod(spining);
					break;
				case "Фідерне":
					Fiderni fiderni = new Fiderni();
					SaveCharacteristics(fiderni);
					fiderni.FiderBuild = valueOptionalParameter.Text;
					fiderni.ValueOptionalParameter = fiderni.FiderBuild;
					AddNewFishingRod(fiderni);
					break;
				case "Поплавкове":
					Poplavkovi poplavkovi =new Poplavkovi();
					SaveCharacteristics(poplavkovi);
					poplavkovi.TipsBuild = valueOptionalParameter.Text;
					poplavkovi.ValueOptionalParameter = poplavkovi.TipsBuild;
					AddNewFishingRod(poplavkovi);
					break;
				case "Махове":
					Makhovi makhovi =new Makhovi();
					SaveCharacteristics(makhovi);
					makhovi.TipsBuild = valueOptionalParameter.Text;
					makhovi.ValueOptionalParameter = makhovi.TipsBuild;
					AddNewFishingRod(makhovi);
					break;
				case "Матчеве":
					Matchevy matchevy = new Matchevy();
					SaveCharacteristics(matchevy);
					matchevy.TipsСonnection = valueOptionalParameter.Text;
					matchevy.ValueOptionalParameter = matchevy.TipsСonnection;
					AddNewFishingRod(matchevy);
					break;
				case "Зимове":
					Winter winter = new Winter();
					SaveCharacteristics(winter);
					winter.TipsBuild = valueOptionalParameter.Text;
					winter.ValueOptionalParameter = winter.TipsBuild;
					AddNewFishingRod(winter);
					break;
			}
			this.Close();
		}

		public void SaveCharacteristics(FishingRod fishingRod)
		{
			fishingRod.Name = nameProduct.Text;
			fishingRod.Brand = nameBrand.Text;
			fishingRod.Purpose = purpose.Text;
			fishingRod.Coil = coil.Text;
			fishingRod.DescriptionValue = description.Text;
			if (double.TryParse(lenght.Text, out fishingRod.Lenght))
			{
				fishingRod.Lenght = Convert.ToDouble(lenght.Text);
			}
			else
		    {
				fishingRod.Lenght = 0.0;
			}

			if (double.TryParse(price.Text, out fishingRod.Price))
			{
				fishingRod.Price = Convert.ToDouble(price.Text);
			}
			else
			{
				fishingRod.Price = 0.0;
			}
		}

		private void AddNewFishingRod(FishingRod fishingRod)
		{
			if (fishingRods == null)
			{
				thisFishingRods = new List<FishingRod>();
				thisFishingRods.Add(fishingRod);
			}
			else
			{
				thisFishingRods = fishingRods;
				thisFishingRods.Add(fishingRod);
			}
			MainMenu mainMenu = Program.mainMenu;
			mainMenu.fishingRods = thisFishingRods;
			mainMenu.Update();
		}
	}
}
