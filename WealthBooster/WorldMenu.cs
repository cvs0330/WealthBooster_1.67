using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WealthBooster.SigScan;
using static WealthBooster.Player;
using static WealthBooster.Globals;
using System.Diagnostics;
using WealthBooster;

namespace WealthBooster
{





    public partial class WorldMenu : Form
    {
        public WorldMenu()
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


        private void WorldMenu_Load(object sender, EventArgs e)
        {
            TimerManager.SharedTimerTick += SharedTimerWorld_Tick;

        }


     
        private void SetTime0_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(TimeBaseAddress + "+10", "int", "0");
            MemLib.WriteMemory(TimeBaseAddress + "+14", "int", "0");
        }

        private void SetTime6_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(TimeBaseAddress + "+10", "int", "6");
            MemLib.WriteMemory(TimeBaseAddress + "+14", "int", "0");
        }

        private void SetTime12_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(TimeBaseAddress + "+10", "int", "12");
            MemLib.WriteMemory(TimeBaseAddress + "+14", "int", "0");
        }

        private void SetTime18_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(TimeBaseAddress + "+10", "int", "18");
            MemLib.WriteMemory(TimeBaseAddress + "+14", "int", "0");
        }



        private void ClearWeather_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "1");
        }

        private void SunnyWeather_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "0");
        }

        private void WeatherXmas_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "3");
        }

        private void WeatherThunder_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "7");
        }

        private void WeatherRain_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "6");
        }

        private void WeatherWindySnow_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "11");
        }

        private void WeatherSmog_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+104", "int", "3");
        }

        private void ToggleSnowBox_CheckedChanged(object sender, EventArgs e)
        {
            Global_toggle_snow = ToggleSnowBox.Checked ? 1 : 0;
        }



        private void ResetRainSettings_Click(object sender, EventArgs e)
        {
            float value = 0.40f;
            string valueString = value.ToString("F2");

            MemLib.WriteMemory(WeatherBaseAddress + "+1B10E4", "float", valueString);
            MemLib.WriteMemory(WeatherBaseAddress + "+1B10E8", "float", valueString);
            MemLib.WriteMemory(WeatherBaseAddress + "+1B10EC", "float", valueString);
        }

        private void GreenRain_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+1B10E8", "float", "1");
        }

        private void RedRain_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+1B10E4", "float", "1");
        }

        private void BlueRain_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(WeatherBaseAddress + "+1B10EC", "float", "1");
        }

        private void EmptyLobbyButton_Click(object sender, EventArgs e)
        {
            Process process = Process.GetProcessesByName("GTA5")[0];
            process.Suspend();
            System.Threading.Thread.Sleep(10000);
            process.Resume();
        }

        private void SharedTimerWorld_Tick(object sender, EventArgs e)
        {
            if (TimeBypassBox.Checked)
            {
                MemLib.WriteMemory(TimeBaseAddress + "+C9F358", "int", "1");
            }

            if (SyncRealTimeBox.Checked)
            {
                DateTime currentTime = DateTime.Now;
                int hours = currentTime.Hour;
                int minutes = currentTime.Minute;
                MemLib.WriteMemory(TimeBaseAddress + "+10", "int", hours.ToString());
                MemLib.WriteMemory(TimeBaseAddress + "+14", "int", minutes.ToString());

            }
            if (CustomTimeFreezeBox.Checked)
            {

                MemLib.WriteMemory(TimeBaseAddress + "+10", "int", TimeMinutesValue.Value.ToString());
                MemLib.WriteMemory(TimeBaseAddress + "+14", "int", TimeSecondsValue.Value.ToString());

            }
        }

      
        private void WorldMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedTimerWorld.Stop();
        }
    }
}
