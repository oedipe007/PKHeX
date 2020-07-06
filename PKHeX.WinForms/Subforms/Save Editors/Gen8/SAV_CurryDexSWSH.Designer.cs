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
            this.GB_CurryData = new System.Windows.Forms.GroupBox();
            this.CHK_HasLastCooking = new System.Windows.Forms.CheckBox();
            this.CAL_LastCookingDate = new System.Windows.Forms.DateTimePicker();
            this.L_LastCookingDate = new System.Windows.Forms.Label();
            this.CAL_FirstCookingDate = new System.Windows.Forms.DateTimePicker();
            this.L_FirstCookingDate = new System.Windows.Forms.Label();
            this.L_Medal = new System.Windows.Forms.Label();
            this.CB_Medal = new System.Windows.Forms.ComboBox();
            this.TB_PokemonName = new System.Windows.Forms.TextBox();
            this.L_PokemonName = new System.Windows.Forms.Label();
            this.L_NumberOfPokemon = new System.Windows.Forms.Label();
            this.TB_NumberOfPokemon = new System.Windows.Forms.TextBox();
            this.CB_EatingLocation = new System.Windows.Forms.ComboBox();
            this.L_EatingLocation = new System.Windows.Forms.Label();
            this.CHK_SmallSize = new System.Windows.Forms.CheckBox();
            this.GB_Sizes = new System.Windows.Forms.GroupBox();
            this.CHK_NediumSize = new System.Windows.Forms.CheckBox();
            this.CHK_BigSize = new System.Windows.Forms.CheckBox();
            this.GB_CurryData.SuspendLayout();
            this.GB_Sizes.SuspendLayout();
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
            this.LB_AllCurry.Size = new System.Drawing.Size(234, 344);
            this.LB_AllCurry.TabIndex = 4;
            // 
            // GB_CurryData
            // 
            this.GB_CurryData.Controls.Add(this.GB_Sizes);
            this.GB_CurryData.Controls.Add(this.CB_EatingLocation);
            this.GB_CurryData.Controls.Add(this.TB_NumberOfPokemon);
            this.GB_CurryData.Controls.Add(this.TB_PokemonName);
            this.GB_CurryData.Controls.Add(this.CHK_HasLastCooking);
            this.GB_CurryData.Controls.Add(this.CAL_LastCookingDate);
            this.GB_CurryData.Controls.Add(this.L_LastCookingDate);
            this.GB_CurryData.Controls.Add(this.CAL_FirstCookingDate);
            this.GB_CurryData.Controls.Add(this.L_FirstCookingDate);
            this.GB_CurryData.Controls.Add(this.L_EatingLocation);
            this.GB_CurryData.Controls.Add(this.L_NumberOfPokemon);
            this.GB_CurryData.Controls.Add(this.L_PokemonName);
            this.GB_CurryData.Controls.Add(this.L_Medal);
            this.GB_CurryData.Controls.Add(this.CB_Medal);
            this.GB_CurryData.Location = new System.Drawing.Point(12, 12);
            this.GB_CurryData.Name = "GB_CurryData";
            this.GB_CurryData.Size = new System.Drawing.Size(536, 344);
            this.GB_CurryData.TabIndex = 8;
            this.GB_CurryData.TabStop = false;
            this.GB_CurryData.Text = "Curry\'s data";
            // 
            // CHK_HasLastCooking
            // 
            this.CHK_HasLastCooking.AutoSize = true;
            this.CHK_HasLastCooking.Location = new System.Drawing.Point(355, 210);
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
            this.CAL_LastCookingDate.Location = new System.Drawing.Point(384, 205);
            this.CAL_LastCookingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CAL_LastCookingDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.CAL_LastCookingDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.CAL_LastCookingDate.Name = "CAL_LastCookingDate";
            this.CAL_LastCookingDate.Size = new System.Drawing.Size(146, 26);
            this.CAL_LastCookingDate.TabIndex = 38;
            this.CAL_LastCookingDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // L_LastCookingDate
            // 
            this.L_LastCookingDate.AutoSize = true;
            this.L_LastCookingDate.Location = new System.Drawing.Point(379, 180);
            this.L_LastCookingDate.Name = "L_LastCookingDate";
            this.L_LastCookingDate.Size = new System.Drawing.Size(150, 20);
            this.L_LastCookingDate.TabIndex = 37;
            this.L_LastCookingDate.Text = "Date of last cooking";
            // 
            // CAL_FirstCookingDate
            // 
            this.CAL_FirstCookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CAL_FirstCookingDate.Location = new System.Drawing.Point(384, 149);
            this.CAL_FirstCookingDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CAL_FirstCookingDate.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.CAL_FirstCookingDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.CAL_FirstCookingDate.Name = "CAL_FirstCookingDate";
            this.CAL_FirstCookingDate.Size = new System.Drawing.Size(146, 26);
            this.CAL_FirstCookingDate.TabIndex = 36;
            this.CAL_FirstCookingDate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // L_FirstCookingDate
            // 
            this.L_FirstCookingDate.AutoSize = true;
            this.L_FirstCookingDate.Location = new System.Drawing.Point(379, 124);
            this.L_FirstCookingDate.Name = "L_FirstCookingDate";
            this.L_FirstCookingDate.Size = new System.Drawing.Size(151, 20);
            this.L_FirstCookingDate.TabIndex = 10;
            this.L_FirstCookingDate.Text = "Date of first cooking";
            // 
            // L_Medal
            // 
            this.L_Medal.AutoSize = true;
            this.L_Medal.Location = new System.Drawing.Point(3, 124);
            this.L_Medal.Name = "L_Medal";
            this.L_Medal.Size = new System.Drawing.Size(121, 20);
            this.L_Medal.TabIndex = 10;
            this.L_Medal.Text = "Obtained Medal";
            // 
            // CB_Medal
            // 
            this.CB_Medal.FormattingEnabled = true;
            this.CB_Medal.Location = new System.Drawing.Point(7, 147);
            this.CB_Medal.Name = "CB_Medal";
            this.CB_Medal.Size = new System.Drawing.Size(121, 28);
            this.CB_Medal.TabIndex = 9;
            // 
            // TB_PokemonName
            // 
            this.TB_PokemonName.Location = new System.Drawing.Point(153, 148);
            this.TB_PokemonName.MaxLength = 12;
            this.TB_PokemonName.Name = "TB_PokemonName";
            this.TB_PokemonName.Size = new System.Drawing.Size(182, 26);
            this.TB_PokemonName.TabIndex = 40;
            // 
            // L_PokemonName
            // 
            this.L_PokemonName.AutoSize = true;
            this.L_PokemonName.Location = new System.Drawing.Point(149, 124);
            this.L_PokemonName.Name = "L_PokemonName";
            this.L_PokemonName.Size = new System.Drawing.Size(120, 20);
            this.L_PokemonName.TabIndex = 10;
            this.L_PokemonName.Text = "Pokemon name";
            // 
            // L_NumberOfPokemon
            // 
            this.L_NumberOfPokemon.AutoSize = true;
            this.L_NumberOfPokemon.Location = new System.Drawing.Point(149, 180);
            this.L_NumberOfPokemon.Name = "L_NumberOfPokemon";
            this.L_NumberOfPokemon.Size = new System.Drawing.Size(153, 20);
            this.L_NumberOfPokemon.TabIndex = 10;
            this.L_NumberOfPokemon.Text = "Number of pokemon";
            // 
            // TB_NumberOfPokemon
            // 
            this.TB_NumberOfPokemon.Location = new System.Drawing.Point(153, 204);
            this.TB_NumberOfPokemon.Name = "TB_NumberOfPokemon";
            this.TB_NumberOfPokemon.Size = new System.Drawing.Size(182, 26);
            this.TB_NumberOfPokemon.TabIndex = 40;
            // 
            // CB_EatingLocation
            // 
            this.CB_EatingLocation.FormattingEnabled = true;
            this.CB_EatingLocation.Location = new System.Drawing.Point(153, 259);
            this.CB_EatingLocation.Name = "CB_EatingLocation";
            this.CB_EatingLocation.Size = new System.Drawing.Size(182, 28);
            this.CB_EatingLocation.TabIndex = 41;
            // 
            // L_EatingLocation
            // 
            this.L_EatingLocation.AutoSize = true;
            this.L_EatingLocation.Location = new System.Drawing.Point(149, 236);
            this.L_EatingLocation.Name = "L_EatingLocation";
            this.L_EatingLocation.Size = new System.Drawing.Size(114, 20);
            this.L_EatingLocation.TabIndex = 10;
            this.L_EatingLocation.Text = "Eating location";
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
            // GB_Sizes
            // 
            this.GB_Sizes.Controls.Add(this.CHK_BigSize);
            this.GB_Sizes.Controls.Add(this.CHK_NediumSize);
            this.GB_Sizes.Controls.Add(this.CHK_SmallSize);
            this.GB_Sizes.Location = new System.Drawing.Point(7, 35);
            this.GB_Sizes.Name = "GB_Sizes";
            this.GB_Sizes.Size = new System.Drawing.Size(256, 68);
            this.GB_Sizes.TabIndex = 43;
            this.GB_Sizes.TabStop = false;
            this.GB_Sizes.Text = "Sizes";
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
            // SAV_CurryDexSWSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GB_CurryData);
            this.Controls.Add(this.LB_AllCurry);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Cancel);
            this.Icon = global::PKHeX.WinForms.Properties.Resources.Icon;
            this.Name = "SAV_CurryDexSWSH";
            this.Text = "Curry Dex Editor";
            this.GB_CurryData.ResumeLayout(false);
            this.GB_CurryData.PerformLayout();
            this.GB_Sizes.ResumeLayout(false);
            this.GB_Sizes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Button B_Cancel;
        private System.Windows.Forms.ListBox LB_AllCurry;
        private System.Windows.Forms.GroupBox GB_CurryData;
        private System.Windows.Forms.Label L_Medal;
        private System.Windows.Forms.ComboBox CB_Medal;
        private System.Windows.Forms.DateTimePicker CAL_FirstCookingDate;
        private System.Windows.Forms.Label L_FirstCookingDate;
        private System.Windows.Forms.DateTimePicker CAL_LastCookingDate;
        private System.Windows.Forms.Label L_LastCookingDate;
        private System.Windows.Forms.CheckBox CHK_HasLastCooking;
        private System.Windows.Forms.TextBox TB_PokemonName;
        private System.Windows.Forms.Label L_PokemonName;
        private System.Windows.Forms.TextBox TB_NumberOfPokemon;
        private System.Windows.Forms.Label L_NumberOfPokemon;
        private System.Windows.Forms.ComboBox CB_EatingLocation;
        private System.Windows.Forms.Label L_EatingLocation;
        private System.Windows.Forms.GroupBox GB_Sizes;
        private System.Windows.Forms.CheckBox CHK_BigSize;
        private System.Windows.Forms.CheckBox CHK_NediumSize;
        private System.Windows.Forms.CheckBox CHK_SmallSize;
    }
}