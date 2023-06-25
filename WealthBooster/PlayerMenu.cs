using System;
using System.Threading;
using System.Windows.Forms;
using static WealthBooster.Player;
using static WealthBooster.Vehicle;
using static WealthBooster.GetAddress;
using static WealthBooster.SigScan;
using System.Runtime.InteropServices;

namespace WealthBooster
{
    public partial class PlayerMenu : Form
    {

        private Thread superJumpThread;

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);


        public PlayerMenu()
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
        private void GodmodeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleGodMode();
        }

        private void UndeadRadarBox_CheckedChanged(object sender, EventArgs e)
        {
            player_max_health = UndeadRadarBox.Checked ? 0 : 328;
        }

        private void ToggleAutoJumpBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ToggleAutoJumpBox.Checked)
            {
                if (superJumpThread == null || !superJumpThread.IsAlive)
                {
                    superJumpThread = new Thread(SuperJumpThread);
                    superJumpThread.Start();
                }
            }
            else
            {
                if (superJumpThread != null && superJumpThread.IsAlive)
                {
                    superJumpThread.Abort();
                    superJumpThread.Join();
                }
            }
        }

        private void NoclipCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (NoclipCheckbox.Checked)
            {
                player_movement = 2; // Set player_movement to 2 when checkbox is checked
            }
            else
            {
                player_movement = 0; // Reset player_movement to default value when checkbox is unchecked
            }
        }

        private void RunSpeedMult_Scroll(object sender, EventArgs e)
        {
            run_speed = RunSpeedMult.Value;
            swim_speed = RunSpeedMult.Value;
            stealth_speed = RunSpeedMult.Value;
        }

        private void SuicideButton_Click(object sender, EventArgs e)
        {
            player_health = 0;
        }

        private void HealPlayerButton_Click(object sender, EventArgs e)
        {
            player_health = 328;
            player_armor = 200;
        }

        private void RemoveWantedButton_Click(object sender, EventArgs e)
        {
            wanted_level = 0;
        }

        private void MaxWantedButton_Click(object sender, EventArgs e)
        {
            wanted_level = 5;
        }
        private void SuperJumpThread()
        {
            while (ToggleAutoJumpBox.Checked)
            {
                frame_flags = ToggleAutoJumpBox.Checked ? -1 : 0;

            }
        }

        private void PlayerMenu_Load(object sender, EventArgs e)
        {
            TimerManager.SharedTimerTick += SharedTimerPlayer_Tick;
        }

        private void SharedTimerPlayer_Tick(object sender, EventArgs e)
        {
            wanted_level = NeverWantedBox.Checked ? 0 : wanted_level;
            player_collision = NoCollisionBox.Checked ? -1 : player_collision;

            if (GetAsyncKeyState(Keys.NumPad0) < 0)
            {
                player_health = 328;
                player_armor = 200;
            }
            if (GetAsyncKeyState(Keys.NumPad1) < 0)
            {
                player_health = 0;
                player_armor = 0;
            }

            if (GetAsyncKeyState(Keys.NumPad2) < 0)
            {
                RemoveWantedButton_Click(sender, e);
            }
            if (GetAsyncKeyState(Keys.NumPad3) < 0)
            {
                MaxWantedButton_Click(sender, e);
            }

            bool toggleKeyPressed = (GetAsyncKeyState(Keys.NumPad8) & 0x8000) != 0;

            if (toggleKeyPressed)
            {
                NoclipCheckbox.Checked = !NoclipCheckbox.Checked;
            }


            if (NoclipCheckbox.Checked && player_movement == 2)
            {
                int xMovement = 0;
                int yMovement = 0;
                int zMovement = 0;

                const int movementIncrement = 2;

                if (GetAsyncKeyState(Keys.E) < 0)
                    zMovement += movementIncrement;
                if (GetAsyncKeyState(Keys.Q) < 0)
                    zMovement -= movementIncrement;
                if (GetAsyncKeyState(Keys.D) < 0)
                    xMovement -= movementIncrement;
                if (GetAsyncKeyState(Keys.A) < 0)
                    xMovement += movementIncrement;
                if (GetAsyncKeyState(Keys.W) < 0)
                    yMovement -= movementIncrement;
                if (GetAsyncKeyState(Keys.S) < 0)
                    yMovement += movementIncrement;

                player_coord_x += xMovement;
                player_visual_coord_x += xMovement;
                player_coord_y += yMovement;
                player_visual_coord_y += yMovement;             
                player_coord_z += zMovement;
                player_visual_coord_z += zMovement;
             
            }
        }

        private void PlayerMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedTimerPlayer.Stop();
        }
    }
}
