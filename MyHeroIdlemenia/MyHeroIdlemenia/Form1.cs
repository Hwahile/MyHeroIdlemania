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



        //Var und Fomrel für Str
        double str_str;
        double str_akt;
        double str_hp;

        //Var und Fomrel für Dex
        double dex_dex, dex_cr;

        //Var und Fomrel für Con
        double con_con, con_hp;

        //Var und Fomrel für Int
        double int_int, int_cd;

        //Var Statpoints
        int statpoints = 250;

        //Var für xp
        int xp = 0, xpsec = 1, lv = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // BenoetigteExp füllen
            BenoetigteExp.Add(new KeyValuePair<int, int>(0, 1));
            BenoetigteExp.Add(new KeyValuePair<int, int>(1, 2));
            BenoetigteExp.Add(new KeyValuePair<int, int>(2, 5));
            //BenoetigteExp.Add(new KeyValuePair<int, int>(3, 6));
            BenoetigteExp.Add(new KeyValuePair<int, int>(-1, -1));

        }

        public Form1()
        {
            InitializeComponent();
            button_Str_plus.FlatAppearance.BorderColor = Color.LightCoral;
            button_Str_plus.FlatAppearance.BorderSize = 1;

            button_Dex_plus.FlatAppearance.BorderColor = Color.PaleGreen;
            button_Dex_plus.FlatAppearance.BorderSize = 1;

            button_Con_plus.FlatAppearance.BorderColor = Color.PaleGoldenrod;
            button_Con_plus.FlatAppearance.BorderSize = 1;

            button_Int_plus.FlatAppearance.BorderColor = Color.LightSkyBlue;
            button_Int_plus.FlatAppearance.BorderSize = 1;

        }

        void lvUP()
        {
            if (prgBar_Xp.Value == prgBar_Xp.Maximum)
            {
                lv++;
                textBox_lv.Text = Convert.ToString(lv);
                statpoints++;
                textBox_Statuspoints.Text = Convert.ToString(statpoints);
                textBox_lv.Text = Convert.ToString(lv);
                prgBar_Xp.Value = 0;
                //prgBar_Xp.Maximum = prgBar_Xp.Maximum * 2;
                // LINQ FTW !1111!1
                KeyValuePair<int, int> AktuellesPair = BenoetigteExp.Where(x => x.Key == lv).FirstOrDefault();
                prgBar_Xp.Maximum = (AktuellesPair.Value != 0) ? AktuellesPair.Value : Int32.MaxValue;

            }
        }

        private void xp_per_sec_Tick(object sender, EventArgs e)
        {
            if (xpsec > prgBar_Xp.Maximum || (prgBar_Xp.Value + xpsec > prgBar_Xp.Maximum))
            {
                prgBar_Xp.Value = prgBar_Xp.Maximum;
            }
            else
            {
                prgBar_Xp.Value = prgBar_Xp.Value + xpsec;
            }

            lvUP();
            textBox_Xp_ToUp.Text = Convert.ToString(prgBar_Xp.Maximum);
            textBox_curXp.Text = Convert.ToString(prgBar_Xp.Value);
        }

        private void button_Dex_plus_Click(object sender, EventArgs e)
        {
            if (statpoints > 0 && prgBar_Dex.Value < 100)
            {
                dex_dex++;
                dex_cr++;
                statpoints--;
                statPoint_Dex.Text = Convert.ToString(dex_dex);
                textBox_Statuspoints.Text = Convert.ToString(statpoints);
                prgBar_Dex.Value = Convert.ToInt32(dex_dex);
            }
        }

        private void button_Con_plus_Click(object sender, EventArgs e)
        {
            if (statpoints > 0 && prgBar_Con.Value < 100)
            {
                con_con++;
                statpoints--;
                statPoint_Con.Text = Convert.ToString(con_con);
                textBox_Statuspoints.Text = Convert.ToString(statpoints);
                prgBar_Con.Value = Convert.ToInt32(con_con);
            }
        }

        private void button_Int_plus_Click(object sender, EventArgs e)
        {
            if (statpoints > 0 && prgBar_Int.Value < 100)
            {
                int_int++;
                statpoints--;
                statPoint_Int.Text = Convert.ToString(int_int);
                textBox_Statuspoints.Text = Convert.ToString(statpoints);
                prgBar_Int.Value = Convert.ToInt32(int_int);
            }
        }

        private void button_Str_plus_Click(object sender, EventArgs e)
        {
            if (statpoints > 0 && prgBar_Str.Value < 100)
            {
                str_str++;
                statpoints--;
                statPoint_Str.Text = Convert.ToString(str_str);
                textBox_Statuspoints.Text = Convert.ToString(statpoints);
                prgBar_Str.Value = Convert.ToInt32(str_str);
                prgBar_Str.ForeColor = Color.LightCoral;
            }
        }
    }




}
