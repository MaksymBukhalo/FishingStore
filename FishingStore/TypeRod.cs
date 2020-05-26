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
	public partial class TypeRod : Form
	{
		public List<FishingRod> fishingRods;
		public TypeRod()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			ProductPageCreation productPage = new ProductPageCreation();
			productPage.typeRod.Text = comboBox1.Text;
			productPage.fishingRods = this.fishingRods;
			productPage.ShowDialog();
			this.Close();
		}

		private void TypeRod_Load(object sender, EventArgs e)
		{

		}
	}
}
