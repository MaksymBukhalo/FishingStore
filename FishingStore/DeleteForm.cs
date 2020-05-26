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
	public partial class DeleteForm : Form
	{
		public List<FishingRod> fishingRods;
		public DeleteForm()
		{
			InitializeComponent();
		}

		private void DeleteForm_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < fishingRods.Count; i++)
			{
				deleteList.Items.Insert(i, fishingRods[i].Name);
			}
		}

		private void delete_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < deleteList.Items.Count; i++)
			{
				if (deleteList.GetSelected(i) == true)
				{
					fishingRods.RemoveAt(i);
				}
			}
			MainMenu mainMenu = Program.mainMenu;
			mainMenu.fishingRods = this.fishingRods;
			mainMenu.Update();
			this.Close();
		}
	}
}
