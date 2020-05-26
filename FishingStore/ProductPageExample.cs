using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FishingStore
{
	public partial class ProductPageExample : FishingStore.ExampleBackground
	{
		public List<FishingRod> fishingRods;
		private FishingRod rod;

		public ProductPageExample()
		{
			InitializeComponent();
		}

		private void edit_Click(object sender, EventArgs e)
		{
			name.Enabled = true;
			brandName.Enabled = true;
			prupose.Enabled = true;
			valueOptionalParameter.Enabled = true;
			typeCoil.Enabled = true;
			price.Enabled = true;
			rodLenght.Enabled = true;
			description.Enabled = true;
			description.ReadOnly = false;
			save.Visible = true;
			for (int i = 0; i < fishingRods.Count; i++)
			{
				if (fishingRods[i].Name == name.Text)
				{
					rod = fishingRods[i];
				}
			}
		}

		private void ProductPageExample_Load(object sender, EventArgs e)
		{
			save.Visible = false;
			TypeCheck();
		}

		private void save_Click(object sender, EventArgs e)
		{
			name.Enabled = false;
			brandName.Enabled = false;
			prupose.Enabled = false;
			typeCoil.Enabled = false;
			valueOptionalParameter.Enabled = false;
			price.Enabled = false;
			rodLenght.Enabled = false;
			description.Enabled = false;
			description.ReadOnly = true;
			SaveCharacteristics(rod);
			save.Visible = false;
		}

		public void SaveCharacteristics(FishingRod fishingRod)
		{
			fishingRod.Name = name.Text;
			fishingRod.Brand = brandName.Text;
			fishingRod.Purpose = prupose.Text;
			fishingRod.Coil = coil.Text;
			fishingRod.DescriptionValue = description.Text;
			if (double.TryParse(rodLenght.Text, out fishingRod.Lenght))
			{
				fishingRod.Lenght = Convert.ToDouble(rodLenght.Text);
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
			for (int i = 0; i < fishingRods.Count; i++)
			{
				if (fishingRods[i].Name == name.Text)
				{
					fishingRods[i] = fishingRod;
				}
			}
			MainMenu mainMenu = Program.mainMenu;
			mainMenu.fishingRods = this.fishingRods;
			mainMenu.Update();
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
	}
}
