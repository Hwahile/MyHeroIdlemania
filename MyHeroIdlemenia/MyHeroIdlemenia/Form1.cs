using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHeroIdlemenia
{
	public partial class Form1 : Form
	{
		List<KeyValuePair<int, int>> BenoetigteExp = new List<KeyValuePair<int, int>>() {
			new KeyValuePair<int, int>(0, 1),
			new KeyValuePair<int, int>(1, 5),
			new KeyValuePair<int, int>(2, 10),
			new KeyValuePair<int, int>(3, 15)
		};
		Player lPlayer = null;



		public Form1()
		{
			InitializeComponent();

			// Anpassungen an der Form
			button_Str_plus.FlatAppearance.BorderColor = Color.LightCoral;
			button_Str_plus.FlatAppearance.BorderSize = 1;

			button_Dex_plus.FlatAppearance.BorderColor = Color.PaleGreen;
			button_Dex_plus.FlatAppearance.BorderSize = 1;

			button_Con_plus.FlatAppearance.BorderColor = Color.PaleGoldenrod;
			button_Con_plus.FlatAppearance.BorderSize = 1;

			button_Int_plus.FlatAppearance.BorderColor = Color.LightSkyBlue;
			button_Int_plus.FlatAppearance.BorderSize = 1;

			lPlayer = new Player("Michi");
			lPlayer.CurrentMaxExp = this.GetCurrentMaxExp();

			// DataBindings hinzufügen
			this.AddDataBindings();
		}

		private int GetCurrentMaxExp()
		{
			KeyValuePair<int, int> AktuellesPair = BenoetigteExp.Where(x => x.Key == lPlayer.Level).FirstOrDefault();
			return lPlayer.CurrentMaxExp = (AktuellesPair.Value != 0) ? AktuellesPair.Value + 1 : Int32.MaxValue;
		}

		void lvUP()
		{
			if (lPlayer.CurrentExp == lPlayer.CurrentMaxExp)
			{
				lPlayer.Level++;
				lPlayer.Statuspoints++;
				lPlayer.CurrentExp = 0;
				lPlayer.CurrentMaxExp = this.GetCurrentMaxExp();
			}
		}

		private void xp_per_sec_Tick(object sender, EventArgs e)
		{
			if (lPlayer.CurrentExp > lPlayer.CurrentMaxExpMinusOne || (lPlayer.CurrentExp + lPlayer.ExpPerSecond > lPlayer.CurrentMaxExpMinusOne))
				lPlayer.CurrentExp = lPlayer.CurrentMaxExp;
			else
				lPlayer.CurrentExp += lPlayer.ExpPerSecond;

			lvUP();
		}

		private void btnPlusStat_Click(object sender, EventArgs e)
		{
			if (lPlayer.Statuspoints > 0)
			{
				Button lButton = sender as Button;

				bool lSucces = true;

				Enum.TryParse<Player.Stat>(lButton.Tag.ToString(), out Player.Stat lStat);

				switch (lStat)
				{
					case Player.Stat.Strength:
						if (lPlayer.Strength < 100)
							lPlayer.Strength++;
						else
							lSucces = false;
						break;

					case Player.Stat.Dexterity:
						if (lPlayer.Dexterity < 100)
						{
							lPlayer.Dexterity++;
							if (lPlayer.Dexterity % 5 == 0)
								lPlayer.CritRate++;
						}
						else
							lSucces = false;

						break;

					case Player.Stat.Intelligence:
						if (lPlayer.Intelligence < 100)
							lPlayer.Intelligence++;
						else
							lSucces = false;
						break;

					case Player.Stat.Constitution:
						if (lPlayer.Constitution < 100)
							lPlayer.Constitution++;
						else
							lSucces = false;
						break;

					default:
						break;
				}

				if (lSucces)
					lPlayer.Statuspoints--;
			}
		}


		private void AddDataBindings()
		{
			// Textboxen
			textBox_lv.DataBindings.Add("Text", lPlayer, "Level");
			statPoint_Str.DataBindings.Add("Text", lPlayer, "Strength");
			statPoint_Dex.DataBindings.Add("Text", lPlayer, "Dexterity");
			statPoint_Int.DataBindings.Add("Text", lPlayer, "Intelligence");
			statPoint_Con.DataBindings.Add("Text", lPlayer, "Constitution");
			textBox_Statuspoints.DataBindings.Add("Text", lPlayer, "Statuspoints");
			textBox_curXp.DataBindings.Add("Text", lPlayer, "CurrentExp");
			textBox_Xp_ToUp.DataBindings.Add("Text", lPlayer, "CurrentMaxExpMinusOne");

			// ProgressBars
			prgBar_Str.DataBindings.Add("Value", lPlayer, "Strength", true);
			prgBar_Dex.DataBindings.Add("Value", lPlayer, "Dexterity", true);
			prgBar_Int.DataBindings.Add("Value", lPlayer, "Intelligence", true);
			prgBar_Con.DataBindings.Add("Value", lPlayer, "Constitution", true);
			prgBar_Xp.DataBindings.Add("Value", lPlayer, "CurrentExp", true);
			prgBar_Xp.DataBindings.Add("Maximum", lPlayer, "CurrentMaxExpMinusOne", true);
		}

	}
}
