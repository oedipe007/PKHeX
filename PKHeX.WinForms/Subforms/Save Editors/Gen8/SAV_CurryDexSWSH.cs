using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PKHeX.Core;
using PKHeX.WinForms.Properties;

namespace PKHeX.WinForms
{
    public partial class SAV_CurryDexSWSH : Form
    {
        private readonly SAV8SWSH Origin;
        private readonly SAV8SWSH SAV;

        public SAV_CurryDexSWSH(SAV8SWSH sav)
        {
            InitializeComponent();
            InitializeBinding();
            PopulateCBLocation();
            WinFormsUtil.TranslateInterface(this, Main.CurrentLanguage);
            SAV = (SAV8SWSH)(Origin = sav).Clone();
        }

        private void InitializeBinding()
        {
            ComboBox[] cbs = { CB_EatingLocation1, CB_EatingLocation2 };
            foreach (var cb in cbs)
            {
                cb.InitializeBinding();
            }
        }

        private void PopulateCBLocation()
        {
            var loc = GameInfo.GetLocationList(GameVersion.SW, 8, egg: false);
            CB_EatingLocation1.DataSource = new BindingSource(loc, null);
            CB_EatingLocation2.DataSource = new BindingSource(loc, null);
        }

        private void B_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            Save();
            Origin.CopyChangesFrom(SAV);
            Close();
        }

        private void Save()
        {

        }

        private void CHK_HasLastCooking_CheckedChanged(object sender, EventArgs e)
        {
            GB_LastCookingData.Enabled = !GB_LastCookingData.Enabled;
        }
    }
}
