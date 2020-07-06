using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PKHeX.Core;

namespace PKHeX.WinForms
{
    public partial class SAV_CurryDexSWSH : Form
    {
        private readonly SAV8SWSH Origin;
        private readonly SAV8SWSH SAV;

        public SAV_CurryDexSWSH(SAV8SWSH sav)
        {
            InitializeComponent();
            WinFormsUtil.TranslateInterface(this, Main.CurrentLanguage);
            SAV = (SAV8SWSH)(Origin = sav).Clone();
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
            CAL_LastCookingDate.Enabled = !CAL_LastCookingDate.Enabled;
        }
    }
}
