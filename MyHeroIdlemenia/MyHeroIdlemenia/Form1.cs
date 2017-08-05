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
		List<KeyValuePair<int, int>> BenoetigteExp = new List<KeyValuePair<int, int>>();
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

			// BenoetigteExp füllen
			BenoetigteExp.Add(new KeyValuePair<int, int>(0, 1));
			BenoetigteExp.Add(new KeyValuePair<int, int>(1, 2));
			BenoetigteExp.Add(new KeyValuePair<int, int>(2, 5));
			//BenoetigteExp.Add(new KeyValuePair<int, int>(3, 6));

			lPlayer = new Player("Michi");
			
			// DataBindings hinzufügen

			textBox_lv.DataBindings.Add("Text", lPlayer, "Level");
			statPoint_Str.DataBindings.Add("Text", lPlayer, "Strength");
			statPoint_Dex.DataBindings.Add("Text", lPlayer, "Dexterity");
			statPoint_Int.DataBindings.Add("Text", lPlayer, "Intelligence");
			statPoint_Con.DataBindings.Add("Text", lPlayer, "Constitution");
			textBox_Statuspoints.DataBindings.Add("Text", lPlayer, "Statuspoints");
			textBox_curXp.DataBindings.Add("Text", lPlayer, "CurrentExp");
			textBox_Xp_ToUp.DataBindings.Add("Text", lPlayer, "CurrentMaxExp");
			

			prgBar_Str.DataBindings.Add("Value", lPlayer, "Strength", true);
			prgBar_Dex.DataBindings.Add("Value", lPlayer, "Dexterity", true);
			prgBar_Int.DataBindings.Add("Value", lPlayer, "Intelligence", true);
			prgBar_Con.DataBindings.Add("Value", lPlayer, "Constitution", true);
			prgBar_Xp.DataBindings.Add("Value", lPlayer, "CurrentExp", true);
			prgBar_Xp.DataBindings.Add("Maximum", lPlayer, "CurrentMaxExp", true);

			lPlayer.CurrentExp = 0;
			lPlayer.CurrentMaxExp = this.GetCurrentMaxExp();
		}

		private int GetCurrentMaxExp()
		{
			KeyValuePair<int, int> AktuellesPair = BenoetigteExp.Where(x => x.Key == lPlayer.Level).FirstOrDefault();
			return lPlayer.CurrentMaxExp = (AktuellesPair.Value != 0) ? AktuellesPair.Value : Int32.MaxValue;
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
			if (lPlayer.ExpPerSecond > prgBar_Xp.Maximum || (prgBar_Xp.Value + lPlayer.ExpPerSecond > prgBar_Xp.Maximum))
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

	}
}
