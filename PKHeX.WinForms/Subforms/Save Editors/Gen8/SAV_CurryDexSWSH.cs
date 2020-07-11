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
        private int lastIndex;

        public SAV_CurryDexSWSH(SAV8SWSH sav)
        {
            InitializeComponent();
            InitializeBinding();
            PopulateCBLocation();
            WinFormsUtil.TranslateInterface(this, Main.CurrentLanguage);
            SAV = (SAV8SWSH)(Origin = sav).Clone();
            lastIndex = 0;
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
            Close();
        }

        private void Save()
        {
            Origin.CopyChangesFrom(SAV);
        }

        private void CHK_HasLastCooking_CheckedChanged(object sender, EventArgs e)
        {
            GB_LastCookingData.Enabled = !GB_LastCookingData.Enabled;
        }

        private void LB_AllCurry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LB_AllCurry.SelectedIndex != lastIndex)
            {
                if (!CheckNames())
                {
                    LB_AllCurry.SelectedIndex = lastIndex;
                    return;
                }
                SetFormData();
                lastIndex = LB_AllCurry.SelectedIndex;
            }
        }

        /// <summary>
        /// Check if the names in the textboxes are valid
        /// </summary>
        /// <returns>Boolean result if the text is valid or not</returns>
        private Boolean CheckNames()
        {
            if(WordFilter.IsFiltered(TB_PokemonName1.Text, out string bad1))
            {
                MessageBox.Show($"Illegal Name ! {bad1}", "Error", MessageBoxButtons.OK);
                return false;
            }
            if (WordFilter.IsFiltered(TB_PokemonName2.Text, out string bad2))
            {
                MessageBox.Show($"Illegal Name ! {bad2}", "Error", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void SetFormData()
        {

        }
    }
}
