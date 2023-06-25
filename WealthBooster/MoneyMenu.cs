using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WealthBooster.Globals;
using static WealthBooster.SigScan;
using static WealthBooster.Roulette;
using static WealthBooster.Player;
using static WealthBooster.Vehicle;

namespace WealthBooster
{
    public partial class MoneyMenu : Form
    {
        public MoneyMenu()
        {
            InitializeComponent();
            InitializeFormProperties();
            CheckboxColorChanger.ApplyColorChangeToAllCheckboxes(this);
        }
        private void InitializeFormProperties()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.SetRoundedRegion(15);

        }





        private void SharedTimerMoney_Tick(object sender, EventArgs e)
        {
            if (IncreasePayout.Checked)
            {
                Global_CMFailMoney = 170000;
            }
            if (RigTable.Checked)
            {
                roulette_table_bet = 40000;
                roulette_left_table = 37;
                roulette_right_table = 37;

                roulette_vip1_table = 37;
                roulette_vip2_table = 37;
                roulette_vip3_table = 37;
                roulette_vip4_table = 37;

            }
        }

        private void MoneyMenu_Load(object sender, EventArgs e)
        {
            TimerManager.SharedTimerTick += SharedTimerMoney_Tick;
        }

        private void SetShotPrice_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ShotPriceText.Text, out int shotPrice))
            {
                Global_Strip_Club_Shot_Price = shotPrice;
            }
        }

        private void RpLoopBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleLooperEnabled();
        }

        private void TpCasino_Click(object sender, EventArgs e)
        {
            player_coord_x = 917;
            player_visual_coord_x = 917;
            player_coord_y = 50;
            player_visual_coord_y = 50;
            player_coord_z = 81;
            player_visual_coord_z = 81;
            vehicle_coord_x = 917;
            vehicle_coord_y = 50;
            vehicle_coord_z = 81;
        }

        private void TpShop_Click(object sender, EventArgs e)
        {
            player_coord_x = 1104;
            player_coord_y = 204;
            player_coord_z = -49;
            player_visual_coord_x = 1104;
            player_visual_coord_y = 204;
            player_visual_coord_z = -49;
        }

        private void TpTables_Click(object sender, EventArgs e)
        {
            player_coord_x = 1143;
            player_coord_y = 261;
            player_coord_z = -51;
            player_visual_coord_x = 1143;
            player_visual_coord_y = 261;
            player_visual_coord_z = -51;
        }

        private void TpCashier_Click(object sender, EventArgs e)
        {
            player_coord_x = 1114;
            player_coord_y = 220;
            player_coord_z = -49;
            player_visual_coord_x = 1114;
            player_visual_coord_y = 220;
            player_visual_coord_z = -49;
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            {
                string message = "How it works?\n\n" +
                                 "Make sure your'e in an empty lobby ( WORLD / EMPTY LOBBY Button or private session ).\n" +
                                 "sit down on any of the 6 roulette tables.\n" +
                                 "select Rig Table then bet on 00 ( just rig table and set the 40k bet on 00 ).\n" +
                                 "Golden Rule: win twice, lose once! ( Source: trust me bro )\n\n";

                MessageBox.Show(message, "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MoneyMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedTimerMoney.Stop();
        }
    }
}
