namespace MyHeroIdlemenia
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.xp_per_sec = new System.Windows.Forms.Timer(this.components);
            this.button_Str_plus = new System.Windows.Forms.Button();
            this.button_Dex_plus = new System.Windows.Forms.Button();
            this.button_Con_plus = new System.Windows.Forms.Button();
            this.button_Int_plus = new System.Windows.Forms.Button();
            this.label_lv = new System.Windows.Forms.Label();
            this.label_Statuspoints = new System.Windows.Forms.Label();
            this.Headline_Stats = new System.Windows.Forms.Label();
            this.label_Int = new System.Windows.Forms.Label();
            this.label_Dex = new System.Windows.Forms.Label();
            this.label_Con = new System.Windows.Forms.Label();
            this.label_Str = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_lv = new System.Windows.Forms.TextBox();
            this.textBox_Statuspoints = new System.Windows.Forms.TextBox();
            this.statPoint_Str = new System.Windows.Forms.TextBox();
            this.statPoint_Dex = new System.Windows.Forms.TextBox();
            this.statPoint_Con = new System.Windows.Forms.TextBox();
            this.statPoint_Int = new System.Windows.Forms.TextBox();
            this.textBox_Xp_ToUp = new System.Windows.Forms.TextBox();
            this.textBox_curXp = new System.Windows.Forms.TextBox();
            this.prgBar_Xp = new System.Windows.Forms.ProgressBar();
            this.prgBar_Str = new System.Windows.Forms.ProgressBar();
            this.prgBar_Dex = new System.Windows.Forms.ProgressBar();
            this.prgBar_Con = new System.Windows.Forms.ProgressBar();
            this.prgBar_Int = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // xp_per_sec
            // 
            this.xp_per_sec.Enabled = true;
            this.xp_per_sec.Interval = 1000;
            this.xp_per_sec.Tick += new System.EventHandler(this.xp_per_sec_Tick);
            // 
            // button_Str_plus
            // 
            this.button_Str_plus.BackColor = System.Drawing.Color.White;
            this.button_Str_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Str_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Str_plus.ForeColor = System.Drawing.Color.Black;
            this.button_Str_plus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Str_plus.Location = new System.Drawing.Point(292, 120);
            this.button_Str_plus.Name = "button_Str_plus";
            this.button_Str_plus.Size = new System.Drawing.Size(32, 31);
            this.button_Str_plus.TabIndex = 14;
            this.button_Str_plus.Tag = "Strength";
            this.button_Str_plus.Text = "+";
            this.button_Str_plus.UseVisualStyleBackColor = false;
            this.button_Str_plus.Click += new System.EventHandler(this.btnPlusStat_Click);
            // 
            // button_Dex_plus
            // 
            this.button_Dex_plus.BackColor = System.Drawing.Color.White;
            this.button_Dex_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Dex_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Dex_plus.ForeColor = System.Drawing.Color.Black;
            this.button_Dex_plus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Dex_plus.Location = new System.Drawing.Point(292, 155);
            this.button_Dex_plus.Name = "button_Dex_plus";
            this.button_Dex_plus.Size = new System.Drawing.Size(32, 31);
            this.button_Dex_plus.TabIndex = 13;
            this.button_Dex_plus.Tag = "Dexterity";
            this.button_Dex_plus.Text = "+";
            this.button_Dex_plus.UseVisualStyleBackColor = false;
            this.button_Dex_plus.Click += new System.EventHandler(this.btnPlusStat_Click);
            // 
            // button_Con_plus
            // 
            this.button_Con_plus.BackColor = System.Drawing.Color.White;
            this.button_Con_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Con_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Con_plus.ForeColor = System.Drawing.Color.Black;
            this.button_Con_plus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Con_plus.Location = new System.Drawing.Point(292, 192);
            this.button_Con_plus.Name = "button_Con_plus";
            this.button_Con_plus.Size = new System.Drawing.Size(32, 31);
            this.button_Con_plus.TabIndex = 11;
            this.button_Con_plus.Tag = "Constitution";
            this.button_Con_plus.Text = "+";
            this.button_Con_plus.UseVisualStyleBackColor = false;
            this.button_Con_plus.Click += new System.EventHandler(this.btnPlusStat_Click);
            // 
            // button_Int_plus
            // 
            this.button_Int_plus.BackColor = System.Drawing.Color.White;
            this.button_Int_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Int_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Int_plus.ForeColor = System.Drawing.Color.Black;
            this.button_Int_plus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Int_plus.Location = new System.Drawing.Point(292, 228);
            this.button_Int_plus.Name = "button_Int_plus";
            this.button_Int_plus.Size = new System.Drawing.Size(32, 31);
            this.button_Int_plus.TabIndex = 12;
            this.button_Int_plus.Tag = "Intelligence";
            this.button_Int_plus.Text = "+";
            this.button_Int_plus.UseVisualStyleBackColor = false;
            this.button_Int_plus.Click += new System.EventHandler(this.btnPlusStat_Click);
            // 
            // label_lv
            // 
            this.label_lv.AutoSize = true;
            this.label_lv.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lv.ForeColor = System.Drawing.Color.White;
            this.label_lv.Location = new System.Drawing.Point(394, 52);
            this.label_lv.Name = "label_lv";
            this.label_lv.Size = new System.Drawing.Size(27, 18);
            this.label_lv.TabIndex = 24;
            this.label_lv.Text = "Lv:";
            // 
            // label_Statuspoints
            // 
            this.label_Statuspoints.AutoSize = true;
            this.label_Statuspoints.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Statuspoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Statuspoints.ForeColor = System.Drawing.Color.White;
            this.label_Statuspoints.Location = new System.Drawing.Point(31, 88);
            this.label_Statuspoints.Name = "label_Statuspoints";
            this.label_Statuspoints.Size = new System.Drawing.Size(94, 18);
            this.label_Statuspoints.TabIndex = 15;
            this.label_Statuspoints.Text = "Statuspoints:";
            // 
            // Headline_Stats
            // 
            this.Headline_Stats.AutoSize = true;
            this.Headline_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Headline_Stats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Headline_Stats.Location = new System.Drawing.Point(24, 44);
            this.Headline_Stats.Name = "Headline_Stats";
            this.Headline_Stats.Size = new System.Drawing.Size(79, 29);
            this.Headline_Stats.TabIndex = 8;
            this.Headline_Stats.Text = "Penis";
            // 
            // label_Int
            // 
            this.label_Int.AutoSize = true;
            this.label_Int.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Int.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Int.ForeColor = System.Drawing.Color.White;
            this.label_Int.Location = new System.Drawing.Point(79, 236);
            this.label_Int.Name = "label_Int";
            this.label_Int.Size = new System.Drawing.Size(80, 18);
            this.label_Int.TabIndex = 7;
            this.label_Int.Text = "Intelligence";
            // 
            // label_Dex
            // 
            this.label_Dex.AutoSize = true;
            this.label_Dex.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Dex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dex.ForeColor = System.Drawing.Color.White;
            this.label_Dex.Location = new System.Drawing.Point(77, 164);
            this.label_Dex.Name = "label_Dex";
            this.label_Dex.Size = new System.Drawing.Size(65, 18);
            this.label_Dex.TabIndex = 5;
            this.label_Dex.Text = "Dexterity";
            // 
            // label_Con
            // 
            this.label_Con.AutoSize = true;
            this.label_Con.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Con.ForeColor = System.Drawing.Color.White;
            this.label_Con.Location = new System.Drawing.Point(77, 201);
            this.label_Con.Name = "label_Con";
            this.label_Con.Size = new System.Drawing.Size(87, 18);
            this.label_Con.TabIndex = 6;
            this.label_Con.Text = "Constitution";
            // 
            // label_Str
            // 
            this.label_Str.AutoSize = true;
            this.label_Str.BackColor = System.Drawing.SystemColors.ControlText;
            this.label_Str.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Str.ForeColor = System.Drawing.Color.White;
            this.label_Str.Location = new System.Drawing.Point(77, 127);
            this.label_Str.Name = "label_Str";
            this.label_Str.Size = new System.Drawing.Size(63, 18);
            this.label_Str.TabIndex = 4;
            this.label_Str.Text = "Strength";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(165, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "XP";
            // 
            // textBox_lv
            // 
            this.textBox_lv.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox_lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lv.ForeColor = System.Drawing.Color.White;
            this.textBox_lv.Location = new System.Drawing.Point(430, 52);
            this.textBox_lv.Multiline = true;
            this.textBox_lv.Name = "textBox_lv";
            this.textBox_lv.ReadOnly = true;
            this.textBox_lv.Size = new System.Drawing.Size(42, 20);
            this.textBox_lv.TabIndex = 23;
            // 
            // textBox_Statuspoints
            // 
            this.textBox_Statuspoints.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Statuspoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Statuspoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Statuspoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Statuspoints.Location = new System.Drawing.Point(135, 88);
            this.textBox_Statuspoints.Multiline = true;
            this.textBox_Statuspoints.Name = "textBox_Statuspoints";
            this.textBox_Statuspoints.ReadOnly = true;
            this.textBox_Statuspoints.Size = new System.Drawing.Size(189, 20);
            this.textBox_Statuspoints.TabIndex = 16;
            this.textBox_Statuspoints.Text = "0";
            // 
            // statPoint_Str
            // 
            this.statPoint_Str.BackColor = System.Drawing.SystemColors.ControlText;
            this.statPoint_Str.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statPoint_Str.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statPoint_Str.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statPoint_Str.Location = new System.Drawing.Point(29, 127);
            this.statPoint_Str.Multiline = true;
            this.statPoint_Str.Name = "statPoint_Str";
            this.statPoint_Str.ReadOnly = true;
            this.statPoint_Str.Size = new System.Drawing.Size(42, 20);
            this.statPoint_Str.TabIndex = 17;
            this.statPoint_Str.Text = "0";
            // 
            // statPoint_Dex
            // 
            this.statPoint_Dex.BackColor = System.Drawing.SystemColors.ControlText;
            this.statPoint_Dex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statPoint_Dex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statPoint_Dex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statPoint_Dex.Location = new System.Drawing.Point(29, 164);
            this.statPoint_Dex.Multiline = true;
            this.statPoint_Dex.Name = "statPoint_Dex";
            this.statPoint_Dex.ReadOnly = true;
            this.statPoint_Dex.Size = new System.Drawing.Size(42, 20);
            this.statPoint_Dex.TabIndex = 18;
            this.statPoint_Dex.Text = "0";
            // 
            // statPoint_Con
            // 
            this.statPoint_Con.BackColor = System.Drawing.SystemColors.ControlText;
            this.statPoint_Con.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statPoint_Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statPoint_Con.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statPoint_Con.Location = new System.Drawing.Point(29, 201);
            this.statPoint_Con.Multiline = true;
            this.statPoint_Con.Name = "statPoint_Con";
            this.statPoint_Con.ReadOnly = true;
            this.statPoint_Con.Size = new System.Drawing.Size(42, 20);
            this.statPoint_Con.TabIndex = 19;
            this.statPoint_Con.Text = "0";
            // 
            // statPoint_Int
            // 
            this.statPoint_Int.BackColor = System.Drawing.SystemColors.ControlText;
            this.statPoint_Int.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statPoint_Int.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statPoint_Int.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statPoint_Int.Location = new System.Drawing.Point(29, 236);
            this.statPoint_Int.Multiline = true;
            this.statPoint_Int.Name = "statPoint_Int";
            this.statPoint_Int.ReadOnly = true;
            this.statPoint_Int.Size = new System.Drawing.Size(42, 20);
            this.statPoint_Int.TabIndex = 20;
            this.statPoint_Int.Text = "0";
            // 
            // textBox_Xp_ToUp
            // 
            this.textBox_Xp_ToUp.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox_Xp_ToUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Xp_ToUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Xp_ToUp.ForeColor = System.Drawing.Color.White;
            this.textBox_Xp_ToUp.Location = new System.Drawing.Point(281, 294);
            this.textBox_Xp_ToUp.Multiline = true;
            this.textBox_Xp_ToUp.Name = "textBox_Xp_ToUp";
            this.textBox_Xp_ToUp.ReadOnly = true;
            this.textBox_Xp_ToUp.Size = new System.Drawing.Size(42, 20);
            this.textBox_Xp_ToUp.TabIndex = 25;
            // 
            // textBox_curXp
            // 
            this.textBox_curXp.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBox_curXp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_curXp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_curXp.ForeColor = System.Drawing.Color.White;
            this.textBox_curXp.Location = new System.Drawing.Point(29, 294);
            this.textBox_curXp.Multiline = true;
            this.textBox_curXp.Name = "textBox_curXp";
            this.textBox_curXp.ReadOnly = true;
            this.textBox_curXp.Size = new System.Drawing.Size(42, 20);
            this.textBox_curXp.TabIndex = 26;
            // 
            // prgBar_Xp
            // 
            this.prgBar_Xp.ForeColor = System.Drawing.Color.MediumOrchid;
            this.prgBar_Xp.Location = new System.Drawing.Point(32, 279);
            this.prgBar_Xp.MarqueeAnimationSpeed = 10;
            this.prgBar_Xp.Maximum = 1;
            this.prgBar_Xp.Name = "prgBar_Xp";
            this.prgBar_Xp.Size = new System.Drawing.Size(291, 9);
            this.prgBar_Xp.Step = 1;
            this.prgBar_Xp.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar_Xp.TabIndex = 21;
            // 
            // prgBar_Str
            // 
            this.prgBar_Str.ForeColor = System.Drawing.Color.LightCoral;
            this.prgBar_Str.Location = new System.Drawing.Point(178, 125);
            this.prgBar_Str.Name = "prgBar_Str";
            this.prgBar_Str.Size = new System.Drawing.Size(100, 23);
            this.prgBar_Str.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar_Str.TabIndex = 0;
            // 
            // prgBar_Dex
            // 
            this.prgBar_Dex.ForeColor = System.Drawing.Color.PaleGreen;
            this.prgBar_Dex.Location = new System.Drawing.Point(178, 158);
            this.prgBar_Dex.Name = "prgBar_Dex";
            this.prgBar_Dex.Size = new System.Drawing.Size(100, 23);
            this.prgBar_Dex.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar_Dex.TabIndex = 1;
            // 
            // prgBar_Con
            // 
            this.prgBar_Con.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.prgBar_Con.Location = new System.Drawing.Point(178, 195);
            this.prgBar_Con.Name = "prgBar_Con";
            this.prgBar_Con.Size = new System.Drawing.Size(100, 23);
            this.prgBar_Con.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar_Con.TabIndex = 2;
            // 
            // prgBar_Int
            // 
            this.prgBar_Int.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.prgBar_Int.Location = new System.Drawing.Point(178, 232);
            this.prgBar_Int.Name = "prgBar_Int";
            this.prgBar_Int.Size = new System.Drawing.Size(100, 23);
            this.prgBar_Int.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar_Int.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(586, 397);
            this.Controls.Add(this.prgBar_Str);
            this.Controls.Add(this.label_Dex);
            this.Controls.Add(this.label_lv);
            this.Controls.Add(this.textBox_curXp);
            this.Controls.Add(this.textBox_lv);
            this.Controls.Add(this.textBox_Xp_ToUp);
            this.Controls.Add(this.Headline_Stats);
            this.Controls.Add(this.statPoint_Int);
            this.Controls.Add(this.button_Str_plus);
            this.Controls.Add(this.statPoint_Con);
            this.Controls.Add(this.label_Statuspoints);
            this.Controls.Add(this.statPoint_Dex);
            this.Controls.Add(this.button_Dex_plus);
            this.Controls.Add(this.statPoint_Str);
            this.Controls.Add(this.button_Int_plus);
            this.Controls.Add(this.textBox_Statuspoints);
            this.Controls.Add(this.button_Con_plus);
            this.Controls.Add(this.label_Int);
            this.Controls.Add(this.prgBar_Dex);
            this.Controls.Add(this.label_Con);
            this.Controls.Add(this.prgBar_Con);
            this.Controls.Add(this.prgBar_Xp);
            this.Controls.Add(this.prgBar_Int);
            this.Controls.Add(this.label_Str);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_lv;
        private System.Windows.Forms.Label label_lv;
        private System.Windows.Forms.Timer xp_per_sec;
        private System.Windows.Forms.Button button_Str_plus;
        private System.Windows.Forms.Label label_Statuspoints;
        private System.Windows.Forms.Button button_Dex_plus;
        private System.Windows.Forms.TextBox textBox_Statuspoints;
        private System.Windows.Forms.Button button_Int_plus;
        private System.Windows.Forms.TextBox statPoint_Str;
        private System.Windows.Forms.Button button_Con_plus;
        private System.Windows.Forms.TextBox statPoint_Dex;
        private System.Windows.Forms.Label Headline_Stats;
        private System.Windows.Forms.TextBox statPoint_Con;
        private System.Windows.Forms.Label label_Int;
        private System.Windows.Forms.TextBox statPoint_Int;
        private System.Windows.Forms.Label label_Con;
        private System.Windows.Forms.ProgressBar prgBar_Xp;
        private System.Windows.Forms.Label label_Str;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgBar_Int;
        private System.Windows.Forms.ProgressBar prgBar_Dex;
        private System.Windows.Forms.TextBox textBox_Xp_ToUp;
        private System.Windows.Forms.TextBox textBox_curXp;
        private System.Windows.Forms.Label label_Dex;
        private System.Windows.Forms.ProgressBar prgBar_Str;
		private System.Windows.Forms.ProgressBar prgBar_Con;
	}
}

