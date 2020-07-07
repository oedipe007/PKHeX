namespace PKHeX.WinForms
{
    partial class SAV_CurryDexSWSH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Save = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.LB_AllCurry = new System.Windows.Forms.ListBox();
            this.GB_FirstCookingData = new System.Windows.Forms.GroupBox();
            this.GB_Sizes = new System.Windows.Forms.GroupBox();
            this.CHK_BigSize = new System.Windows.Forms.CheckBox();
            this.CHK_NediumSize = new System.Windows.Forms.CheckBox();
            this.CHK_SmallSize = new System.Windows.Forms.CheckBox();
            this.CB_EatingLocation1 = new System.Windows.Forms.ComboBox();
            this.TB_PokemonName1 = new System.Windows.Forms.TextBox();
            this.CHK_HasLastCooking = new System.Windows.Forms.CheckBox();
            this.CAL_LastCookingDate = new System.Windows.Forms.DateTimePicker();
            this.L_LastCookingDate = new System.Windows.Forms.Label();
            this.CAL_FirstCookingDate = new System.Windows.Forms.DateTimePicker();
            this.L_FirstCookingDate = new System.Windows.Forms.Label();
            this.L_EatingLocation1 = new System.Windows.Forms.Label();
            this.L_NbPokemon1 = new System.Windows.Forms.Label();
            this.L_PokemonName1 = new System.Windows.Forms.Label();
            this.L_Medal = new System.Windows.Forms.Label();
            this.CB_Medal = new System.Windows.Forms.ComboBox();
            this.L_NbCooking = new System.Windows.Forms.Label();
            this.CHK_IsNew = new System.Windows.Forms.CheckBox();
            this.GB_LastCookingData = new System.Windows.Forms.GroupBox();
            this.CB_EatingLocation2 = new System.Windows.Forms.ComboBox();
            this.TB_PokemonName2 = new System.Windows.Forms.TextBox();
            this.L_EatingLocation2 = new System.Windows.Forms.Label();
            this.L_NbPokemon2 = new System.Windows.Forms.Label();
            this.L_PokemonName2 = new System.Windows.Forms.Label();
            this.NUD_NbCooking = new System.Windows.Forms.NumericUpDown();
            this.NUD_NbPokemon1 = new System.Windows.Forms.NumericUpDown();
            this.NUD_NbPokemon2 = new System.Windows.Forms.NumericUpDown();
            this.GB_FirstCookingData.SuspendLayout();
            this.GB_Sizes.SuspendLayout();
            this.GB_LastCookingData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbCooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbPokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbPokemon2)).BeginInit();
            this.SuspendLayout();
            // 
            // B_Save
            // 
            this.B_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Save.Location = new System.Drawing.Point(675, 401);
            this.B_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(112, 35);
            this.B_Save.TabIndex = 3;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = true;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.B_Cancel.Location = new System.Drawing.Point(554, 401);
            this.B_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(112, 35);
            this.B_Cancel.TabIndex = 2;
            this.B_Cancel.Text = "Cancel";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // LB_AllCurry
            // 
            this.LB_AllCurry.FormattingEnabled = true;
            this.LB_AllCurry.ItemHeight = 20;
            this.LB_AllCurry.Location = new System.Drawing.Point(554, 12);
            this.LB_AllCurry.Name = "LB_AllCurry";
            this.LB_AllCurry.Size = new System.Drawing.Size(234, 364);
            this.LB_AllCurry.TabIndex = 4;
            // 
            // GB_FirstCookingData
            // 
            this.GB_FirstCookingData.Controls.Add(this.CB_EatingLocation1);
            this.GB_FirstCookingData.Controls.Add(this.NUD_NbPokemon1);
            this.GB_FirstCookingData.Controls.Add(this.TB_PokemonName1);
            this.GB_FirstCookingData.Controls.Add(this.CAL_FirstCookingDate);
            this.GB_FirstCookingData.Controls.Add(this.L_FirstCookingDate);
            this.GB_FirstCookingData.Controls.Add(this.L_EatingLocation1);
            this.GB_FirstCookingData.Controls.Add(this.L_NbPokemon1);
            this.GB_FirstCookingData.Controls.Add(this.L_PokemonName1);
            this.GB_FirstCookingData.Location = new System.Drawing.Point(142, 86);
            this.GB_FirstCookingData.Name = "GB_FirstCookingData";
            this.GB_FirstCookingData.Size = new System.Drawing.Size(406, 152);
            this.GB_FirstCookingData.TabIndex = 8;
            this.GB_FirstCookingData.TabStop = false;
            this.GB_FirstCookingData.Text = "First cooking datas";
            // 
            // GB_Sizes
            // 
            this.GB_Sizes.Controls.Add(this.CHK_BigSize);
            this.GB_Sizes.Controls.Add(this.CHK_NediumSize);
            this.GB_Sizes.Controls.Add(this.CHK_SmallSize);
            this.GB_Sizes.Location = new System.Drawing.Point(143, 12);
            this.GB_Sizes.Name = "GB_Sizes";
            this.GB_Sizes.Size = new System.Drawing.Size(242, 68);
            this.GB_Sizes.TabIndex = 43;
            this.GB_Sizes.TabStop = false;
            this.GB_Sizes.Text = "Sizes";
            // 
            // CHK_BigSize
            // 
            this.CHK_BigSize.AutoSize = true;
            this.CHK_BigSize.Location = new System.Drawing.Point(183, 38);
            this.CHK_BigSize.Name = "CHK_BigSize";
            this.CHK_BigSize.Size = new System.Drawing.Size(58, 24);
            this.CHK_BigSize.TabIndex = 44;
            this.CHK_BigSize.Text = "Big";
            this.CHK_BigSize.UseVisualStyleBackColor = true;
            // 
            // CHK_NediumSize
            // 
            this.CHK_NediumSize.AutoSize = true;
            this.CHK_NediumSize.Location = new System.Drawing.Point(86, 38);
            this.CHK_NediumSize.Name = "CHK_NediumSize";
            this.CHK_NediumSize.Size = new System.Drawing.Size(91, 24);
            this.CHK_NediumSize.TabIndex = 43;
            this.CHK_NediumSize.Text = "Medium";
            this.CHK_NediumSize.UseVisualStyleBackColor = true;
            // 
            // CHK_SmallSize
            // 
            this.CHK_SmallSize.AutoSize = true;
            this.CHK_SmallSize.Location = new System.Drawing.Point(6, 38);
            this.CHK_SmallSize.Name = "CHK_SmallSize";
            this.CHK_SmallSize.Size = new System.Drawing.Size(74, 24);
            this.CHK_SmallSize.TabIndex = 42;
            this.CHK_SmallSize.Text = "Small";
            this.CHK_SmallSize.UseVisualStyleBackColor = true;
            // 
            // CB_EatingLocation1
            // 
            this.CB_EatingLocation1.FormattingEnabled = true;
            this.CB_EatingLocation1.Location = new System.Drawing.Point(214, 114);
            this.CB_EatingLocation1.Name = "CB_EatingLocation1";
            this.CB_EatingLocation1.Size = new System.Drawing.Size(182, 28);
            this.CB_EatingLocation1.TabIndex = 41;
            // 
            // TB_PokemonName1
            // 
            this.TB_PokemonName1.Location = new System.Drawing.Point(13, 58);
            this.TB_PokemonName1.MaxLength = 12;
            this.TB_PokemonName1.Name = "TB_PokemonName1";
            this.TB_PokemonName1.Size = new System.Drawing.Size(149, 26);
            this.TB_PokemonName1.TabIndex = 40;
            // 
            // CHK_HasLastCooking
            // 
            this.CHK_HasLastCooking.AutoSize = true;
            this.CHK_HasLastCooking.Location = new System.Drawing.Point(115, 244);
            this.CHK_HasLastCooking.Name = "CHK_HasLastCooking";
            this.CHK_HasLastCooking.Size = new System.Drawing.Size(22, 21);
            this.CHK_HasLastCooking.TabIndex = 39;
            this.CHK_HasLastCooking.UseVisualStyleBackColor = true;
            this.CHK_HasLastCooking.CheckedChanged += new System.EventHandler(this.CHK_HasLastCooking_CheckedChanged);
            // 
            // CAL_LastCookingDate
            // 
            this.CAL_LastCookingDate.Enabled = false;
            this.CAL_LastCookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CAL_LastCookingDate.Location = new System.Drawing.Point(214, 57);
            this.CAL_LastCookingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CAL_LastCookingDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.CAL_LastCookingDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.CAL_LastCookingDate.Name = "CAL_LastCookingDate";
            this.CAL_LastCookingDate.Size = new System.Drawing.Size(181, 26);
            this.CAL_LastCookingDate.TabIndex = 38;
            this.CAL_LastCookingDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // L_LastCookingDate
            // 
            this.L_LastCookingDate.AutoSize = true;
            this.L_LastCookingDate.Location = new System.Drawing.Point(209, 32);
            this.L_LastCookingDate.Name = "L_LastCookingDate";
            this.L_LastCookingDate.Size = new System.Drawing.Size(150, 20);
            this.L_LastCookingDate.TabIndex = 37;
            this.L_LastCookingDate.Text = "Date of last cooking";
            // 
            // CAL_FirstCookingDate
            // 
            this.CAL_FirstCookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CAL_FirstCookingDate.Location = new System.Drawing.Point(215, 60);
            this.CAL_FirstCookingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CAL_FirstCookingDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.CAL_FirstCookingDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.CAL_FirstCookingDate.Name = "CAL_FirstCookingDate";
            this.CAL_FirstCookingDate.Size = new System.Drawing.Size(181, 26);
            this.CAL_FirstCookingDate.TabIndex = 36;
            this.CAL_FirstCookingDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // L_FirstCookingDate
            // 
            this.L_FirstCookingDate.AutoSize = true;
            this.L_FirstCookingDate.Location = new System.Drawing.Point(210, 35);
            this.L_FirstCookingDate.Name = "L_FirstCookingDate";
            this.L_FirstCookingDate.Size = new System.Drawing.Size(151, 20);
            this.L_FirstCookingDate.TabIndex = 10;
            this.L_FirstCookingDate.Text = "Date of first cooking";
            // 
            // L_EatingLocation1
            // 
            this.L_EatingLocation1.AutoSize = true;
            this.L_EatingLocation1.Location = new System.Drawing.Point(210, 91);
            this.L_EatingLocation1.Name = "L_EatingLocation1";
            this.L_EatingLocation1.Size = new System.Drawing.Size(114, 20);
            this.L_EatingLocation1.TabIndex = 10;
            this.L_EatingLocation1.Text = "Eating location";
            // 
            // L_NbPokemon1
            // 
            this.L_NbPokemon1.AutoSize = true;
            this.L_NbPokemon1.Location = new System.Drawing.Point(9, 91);
            this.L_NbPokemon1.Name = "L_NbPokemon1";
            this.L_NbPokemon1.Size = new System.Drawing.Size(153, 20);
            this.L_NbPokemon1.TabIndex = 10;
            this.L_NbPokemon1.Text = "Number of pokemon";
            // 
            // L_PokemonName1
            // 
            this.L_PokemonName1.AutoSize = true;
            this.L_PokemonName1.Location = new System.Drawing.Point(9, 35);
            this.L_PokemonName1.Name = "L_PokemonName1";
            this.L_PokemonName1.Size = new System.Drawing.Size(120, 20);
            this.L_PokemonName1.TabIndex = 10;
            this.L_PokemonName1.Text = "Pokemon name";
            // 
            // L_Medal
            // 
            this.L_Medal.AutoSize = true;
            this.L_Medal.Location = new System.Drawing.Point(12, 12);
            this.L_Medal.Name = "L_Medal";
            this.L_Medal.Size = new System.Drawing.Size(121, 20);
            this.L_Medal.TabIndex = 10;
            this.L_Medal.Text = "Obtained Medal";
            // 
            // CB_Medal
            // 
            this.CB_Medal.FormattingEnabled = true;
            this.CB_Medal.Location = new System.Drawing.Point(16, 35);
            this.CB_Medal.Name = "CB_Medal";
            this.CB_Medal.Size = new System.Drawing.Size(121, 28);
            this.CB_Medal.TabIndex = 9;
            // 
            // L_NbCooking
            // 
            this.L_NbCooking.AutoSize = true;
            this.L_NbCooking.Location = new System.Drawing.Point(138, 408);
            this.L_NbCooking.Name = "L_NbCooking";
            this.L_NbCooking.Size = new System.Drawing.Size(142, 20);
            this.L_NbCooking.TabIndex = 10;
            this.L_NbCooking.Text = "Number of cooking";
            // 
            // CHK_IsNew
            // 
            this.CHK_IsNew.AutoSize = true;
            this.CHK_IsNew.Location = new System.Drawing.Point(398, 50);
            this.CHK_IsNew.Name = "CHK_IsNew";
            this.CHK_IsNew.Size = new System.Drawing.Size(150, 24);
            this.CHK_IsNew.TabIndex = 45;
            this.CHK_IsNew.Text = "Shown as \"new\"";
            this.CHK_IsNew.UseVisualStyleBackColor = true;
            // 
            // GB_LastCookingData
            // 
            this.GB_LastCookingData.Controls.Add(this.NUD_NbPokemon2);
            this.GB_LastCookingData.Controls.Add(this.CB_EatingLocation2);
            this.GB_LastCookingData.Controls.Add(this.TB_PokemonName2);
            this.GB_LastCookingData.Controls.Add(this.L_EatingLocation2);
            this.GB_LastCookingData.Controls.Add(this.L_NbPokemon2);
            this.GB_LastCookingData.Controls.Add(this.L_PokemonName2);
            this.GB_LastCookingData.Controls.Add(this.CAL_LastCookingDate);
            this.GB_LastCookingData.Controls.Add(this.L_LastCookingDate);
            this.GB_LastCookingData.Location = new System.Drawing.Point(143, 244);
            this.GB_LastCookingData.Name = "GB_LastCookingData";
            this.GB_LastCookingData.Size = new System.Drawing.Size(406, 152);
            this.GB_LastCookingData.TabIndex = 42;
            this.GB_LastCookingData.TabStop = false;
            this.GB_LastCookingData.Text = "Last cooking datas";
            // 
            // CB_EatingLocation2
            // 
            this.CB_EatingLocation2.FormattingEnabled = true;
            this.CB_EatingLocation2.Location = new System.Drawing.Point(214, 114);
            this.CB_EatingLocation2.Name = "CB_EatingLocation2";
            this.CB_EatingLocation2.Size = new System.Drawing.Size(181, 28);
            this.CB_EatingLocation2.TabIndex = 41;
            // 
            // TB_PokemonName2
            // 
            this.TB_PokemonName2.Location = new System.Drawing.Point(13, 59);
            this.TB_PokemonName2.MaxLength = 12;
            this.TB_PokemonName2.Name = "TB_PokemonName2";
            this.TB_PokemonName2.Size = new System.Drawing.Size(148, 26);
            this.TB_PokemonName2.TabIndex = 40;
            // 
            // L_EatingLocation2
            // 
            this.L_EatingLocation2.AutoSize = true;
            this.L_EatingLocation2.Location = new System.Drawing.Point(210, 91);
            this.L_EatingLocation2.Name = "L_EatingLocation2";
            this.L_EatingLocation2.Size = new System.Drawing.Size(114, 20);
            this.L_EatingLocation2.TabIndex = 10;
            this.L_EatingLocation2.Text = "Eating location";
            // 
            // L_NbPokemon2
            // 
            this.L_NbPokemon2.AutoSize = true;
            this.L_NbPokemon2.Location = new System.Drawing.Point(9, 91);
            this.L_NbPokemon2.Name = "L_NbPokemon2";
            this.L_NbPokemon2.Size = new System.Drawing.Size(153, 20);
            this.L_NbPokemon2.TabIndex = 10;
            this.L_NbPokemon2.Text = "Number of pokemon";
            // 
            // L_PokemonName2
            // 
            this.L_PokemonName2.AutoSize = true;
            this.L_PokemonName2.Location = new System.Drawing.Point(9, 35);
            this.L_PokemonName2.Name = "L_PokemonName2";
            this.L_PokemonName2.Size = new System.Drawing.Size(120, 20);
            this.L_PokemonName2.TabIndex = 10;
            this.L_PokemonName2.Text = "Pokemon name";
            // 
            // NUD_NbCooking
            // 
            this.NUD_NbCooking.Location = new System.Drawing.Point(286, 405);
            this.NUD_NbCooking.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.NUD_NbCooking.Name = "NUD_NbCooking";
            this.NUD_NbCooking.Size = new System.Drawing.Size(63, 26);
            this.NUD_NbCooking.TabIndex = 46;
            // 
            // NUD_NbPokemon1
            // 
            this.NUD_NbPokemon1.Location = new System.Drawing.Point(13, 114);
            this.NUD_NbPokemon1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUD_NbPokemon1.Name = "NUD_NbPokemon1";
            this.NUD_NbPokemon1.Size = new System.Drawing.Size(149, 26);
            this.NUD_NbPokemon1.TabIndex = 47;
            // 
            // NUD_NbPokemon2
            // 
            this.NUD_NbPokemon2.Location = new System.Drawing.Point(12, 120);
            this.NUD_NbPokemon2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NUD_NbPokemon2.Name = "NUD_NbPokemon2";
            this.NUD_NbPokemon2.Size = new System.Drawing.Size(149, 26);
            this.NUD_NbPokemon2.TabIndex = 48;
            // 
            // SAV_CurryDexSWSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NUD_NbCooking);
            this.Controls.Add(this.GB_LastCookingData);
            this.Controls.Add(this.CHK_IsNew);
            this.Controls.Add(this.GB_Sizes);
            this.Controls.Add(this.GB_FirstCookingData);
            this.Controls.Add(this.LB_AllCurry);
            this.Controls.Add(this.CHK_HasLastCooking);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.L_NbCooking);
            this.Controls.Add(this.B_Cancel);
            this.Controls.Add(this.L_Medal);
            this.Controls.Add(this.CB_Medal);
            this.Icon = global::PKHeX.WinForms.Properties.Resources.Icon;
            this.Name = "SAV_CurryDexSWSH";
            this.Text = "Curry Dex Editor";
            this.GB_FirstCookingData.ResumeLayout(false);
            this.GB_FirstCookingData.PerformLayout();
            this.GB_Sizes.ResumeLayout(false);
            this.GB_Sizes.PerformLayout();
            this.GB_LastCookingData.ResumeLayout(false);
            this.GB_LastCookingData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbCooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbPokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_NbPokemon2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.ListBox LB_AllCurry;
        private System.Windows.Forms.GroupBox GB_FirstCookingData;
        private System.Windows.Forms.Label L_Medal;
        private System.Windows.Forms.ComboBox CB_Medal;
        private System.Windows.Forms.DateTimePicker CAL_FirstCookingDate;
        private System.Windows.Forms.Label L_FirstCookingDate;
        private System.Windows.Forms.DateTimePicker CAL_LastCookingDate;
        private System.Windows.Forms.Label L_LastCookingDate;
        private System.Windows.Forms.CheckBox CHK_HasLastCooking;
        private System.Windows.Forms.TextBox TB_PokemonName1;
        private System.Windows.Forms.Label L_PokemonName1;
        private System.Windows.Forms.Label L_NbPokemon1;
        private System.Windows.Forms.ComboBox CB_EatingLocation1;
        private System.Windows.Forms.Label L_EatingLocation1;
        private System.Windows.Forms.GroupBox GB_Sizes;
        private System.Windows.Forms.CheckBox CHK_BigSize;
        private System.Windows.Forms.CheckBox CHK_NediumSize;
        private System.Windows.Forms.CheckBox CHK_SmallSize;
        private System.Windows.Forms.Label L_NbCooking;
        private System.Windows.Forms.CheckBox CHK_IsNew;
        private System.Windows.Forms.GroupBox GB_LastCookingData;
        private System.Windows.Forms.ComboBox CB_EatingLocation2;
        private System.Windows.Forms.TextBox TB_PokemonName2;
        private System.Windows.Forms.Label L_EatingLocation2;
        private System.Windows.Forms.Label L_NbPokemon2;
        private System.Windows.Forms.Label L_PokemonName2;
        private System.Windows.Forms.NumericUpDown NUD_NbPokemon1;
        private System.Windows.Forms.NumericUpDown NUD_NbCooking;
        private System.Windows.Forms.NumericUpDown NUD_NbPokemon2;
    }
}