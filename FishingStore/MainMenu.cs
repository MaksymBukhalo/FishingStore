using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FishingStore
{
	public partial class MainMenu : FishingStore.ExampleBackground
	{
		public List<FishingRod> fishingRods;
		public List<Control> buttonList;
		public List<FishingRod> sortFishingRods;
		private List<FishingRod> MainFishingRods;

		public MainMenu()
		{
			Program.mainMenu = this;
			InitializeComponent();
			AddStartListRod();
		}


		private void MainMenu_Load(object sender, EventArgs e)
		{
			CreateNewButtonList(fishingRods);
		}

		private void CreateNewButtonList(List<FishingRod> fishings)
		{
			MainFishingRods = fishingRods;
			int h = 80;
			if (fishings == null)
			{
				buttonList = new List<Control>();
			}
			else
			{
				for (int i = 0; i < fishings.Count; i++)
				{
					InInitializeMyButton(fishings[i].Name, new Point(-5, h));
					h += 40;
				}
			}
		}


		private void addButton_Click(object sender, EventArgs e)
		{
			ClearListButton();
			TypeRod typeRod = new TypeRod();
			typeRod.fishingRods = this.fishingRods;
			typeRod.ShowDialog();
			CreateNewButtonList(fishingRods);
		}

		Button button;
		public void InInitializeMyButton(string name, Point point)
		{
			button = new Button();
			button.Size = new Size(840, 40);
			button.Location = point;
			button.BackColor = Color.White;
			button.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
			button.Name = name;
			button.Text = name;
			button.Click += new EventHandler(button_Click);
			buttonList.Add(button);
			this.Controls.Add(button);
		}

		private void button_Click(object sender, EventArgs e)
		{
			Control requestingControl = (Control)sender;
			string str = (string)requestingControl.Text;
			ProductPageExample productPageExample = new ProductPageExample();
			for (int i = 0; i < buttonList.Count; i++)
			{
				if (buttonList[i].Name == str)
				{
					SetCharacteristics(productPageExample, i);
				}
			}
			productPageExample.fishingRods = this.fishingRods;
			productPageExample.ShowDialog();
			ClearListButton();
			CreateNewButtonList(fishingRods);
		}

		private void SetCharacteristics(ProductPageExample productPage,int i)
		{
			productPage.name.Text = MainFishingRods[i].Name;
			productPage.brandName.Text = MainFishingRods[i].Brand;
			productPage.prupose.Text = MainFishingRods[i].Purpose;
			productPage.typeCoil.Text = MainFishingRods[i].Coil;
			productPage.description.Text = MainFishingRods[i].DescriptionValue;
			productPage.rodLenght.Text = Convert.ToString(MainFishingRods[i].Lenght);
			productPage.price.Text = Convert.ToString(MainFishingRods[i].Price);
			productPage.valueOptionalParameter.Text = MainFishingRods[i].ValueOptionalParameter;
			switch (MainFishingRods[i].GetType().Name)
			{
				case "Spining":
					Spining spining = new Spining();
					productPage.typeRod.Text = spining.TypeRod;
					productPage.optionalParameter.Text = spining.SpinningClasName;
					break;
				case "Fiderni":
					Fiderni fiderni = new Fiderni();
					productPage.typeRod.Text = fiderni.TypeRod;
					productPage.optionalParameter.Text = fiderni.FiderBuildName;
					break;
				case "Poplavkovi":
					Poplavkovi poplavkovi = new Poplavkovi();
					productPage.typeRod.Text = poplavkovi.TypeRod;
					productPage.optionalParameter.Text = poplavkovi.TipsBuildName;
					break;
				case "Makhovi":
					Makhovi makhovi = new Makhovi();
					productPage.typeRod.Text = makhovi.TypeRod;
					productPage.optionalParameter.Text = makhovi.TipsBuildName;
					break;
				case "Matchevy":
					Matchevy matchevy = new Matchevy();
					productPage.typeRod.Text = matchevy.TypeRod;
					productPage.optionalParameter.Text = matchevy.TipsСonnectionName;
					break;
				case "Winter":
					Winter winter = new Winter();
					productPage.typeRod.Text = winter.TypeRod;
					productPage.optionalParameter.Text = winter.TipsBuildName;
					break;
			}
		}

		private void Delete_Click(object sender, EventArgs e)
		{
			ClearListButton();
			DeleteForm deleteForm = new DeleteForm();
			deleteForm.fishingRods = this.fishingRods;
			deleteForm.ShowDialog();
			CreateNewButtonList(fishingRods);
		}

		private void ClearListButton()
		{
			for (int i = 0; i < buttonList.Count; i++)
			{
				this.Controls.Remove(buttonList[i]);
			}
			buttonList.Clear();
		}

		private void sortButton_Click(object sender, EventArgs e)
		{
			ClearListButton();
			SortForm sortForm = new SortForm();
			sortFishingRods = new List<FishingRod>(fishingRods);
			sortForm.fishingRods = sortFishingRods;
			sortForm.ShowDialog();
			int h = 80;
			MainFishingRods = sortFishingRods;
			if (sortFishingRods == null)
			{
				buttonList = new List<Control>();
			}
			else
			{
				for (int i = 0; i < sortFishingRods.Count; i++)
				{
					InInitializeMyButton(sortFishingRods[i].Name, new Point(-5, h));
					h += 40;
				}
			}
		}

		private void AddStartListRod()
		{
			buttonList = new List<Control>();
			fishingRods = new List<FishingRod>();
			string spinningName = "MEGAFORCE JIGGERSPIN MFJ225-ST (11241-225)";
			string spinningBrand = "Daiwa";
			string spinningPurpose = "Сомові";
			double spinninglenght = 2.2;
			string spinningCoil = "Інерційна";
			double spinningPrice = 600;
			string spinningDescription = "Спиннинг - Удилища - Микроджиговые:Спиннинг Daiwa 19 MEGAFORCE JIGGERSPIN MFJ225 - ST(11241 - 225) купить недорого в Киеве с доставкой в любую точку Украины. Выбирать Распродажа в рыболовном интернет - магазине KENGO очень удобно: самая лучшая система фильтров, продуманная и понятная структура категорий, фото товаров и видео.Отзывы покупателей о Спиннинг Daiwa 19 MEGAFORCE JIGGERSPIN MFJ225 - ST(11241 - 225) и других товарах раздела Распродажа, консультации по телефону и в чате -поможем подобрать рыболовные товары из раздела Распродажа под твои предпочтения.Фирменная гарантия, обмен и возврат. Постоянные акции, распродажи и подарки от рыбацкого интернет - магазина KENGO приносят еще больше радости при покупке, скидки приятно удивляют и дают возможность не только выгодно приобрести Спиннинг Daiwa 19 MEGAFORCE JIGGERSPIN MFJ225 - ST(11241 - 225), но и сэкономить, а накопленные бонусы позволят покупать еще больше, а платить меньше! Чаще всех заказывают Спиннинг Daiwa 19 MEGAFORCE JIGGERSPIN MFJ225 - ST(11241 - 225) жители городов: Киев, Харьков, Днепр, Львов, Одесса, Запорожье, Николаев, Чернигов, Житомир, Мариуполь, Винница, Полтава, Херсон, Сумы, Черкассы, Хмельницкий, Кривой Рог, Ровно, Тернополь.";
			string spinningClass = "Важкий";
			Spining spining = new Spining(spinningName,spinningBrand,spinningPurpose,spinninglenght,spinningCoil,spinningPrice,spinningDescription,spinningClass);
			fishingRods.Add(spining);

			string fiderName = "Mikado Shinju Feeder";
			string fiderBrand = "Mikado";
			string fiderPurpose = "Карпові";
			double fiderlenght = 3;
			string fiderCoil = "Безінерційна";
			double fiderPrice = 754;
			string fiderDescription = "Фидерное удилище со средним строем из композитнных материалов. Гибкий и чувствительный, позволяет ловить на больших дистанциях. Колена соединяются «комель в хлыст». Кольца SiC, установленные на ножках с тремя точками крепления. В комплекте 3 стеклопластиковых хлыстика различной жесткости. Классический катушкодержатель, пенорезиновая рукоять. Фидер поставляется в транспортной полиэтиленовой упаковке.";
			string fiderBuild = "Середній";
			Fiderni fiderni = new Fiderni(fiderName,fiderBrand,fiderPurpose,fiderlenght,fiderCoil,fiderPrice,fiderDescription,fiderBuild);
			fishingRods.Add(fiderni);

			string winterName = "Удочка зимняя судаковая Flagman короткая";
			string winterBrand = "Flagman";
			string winterPurpose = "Сомові";
			double winterlenght = 0.4;
			string winterCoil = "Інерційна";
			double winterPrice = 96.81;
			string winterDescription = "Удильник, предназначенный для ловли со льда на балансиры и блесны. Это максимально простая, проверенная годами конструкция. Пенопластовая ручка, металлический хлыстик и пропускное кольцо, кивок из стальной пружины – здесь нет непрочных или теряющих прочность на морозе материалов. Большой внутренний диаметр кивка и пропускного кольца делают возможной ловлю при очень низкой температуре, когда леска сильно обмерзает. Катушка крепится также очень простым способом – с помощью изоленты.";
			string winterType = "Класична";
			Winter winter = new Winter(winterName, winterBrand, winterPurpose, winterlenght, winterCoil, winterPrice, winterDescription, winterType);
			fishingRods.Add(winter);
		}
	}
}
