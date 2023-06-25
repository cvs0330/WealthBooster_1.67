using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static WealthBooster.Bools;
using static WealthBooster.SigScan;
using static WealthBooster.Tasks;
using static WealthBooster.GetAddress;
using static WealthBooster.Player;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace WealthBooster
{
    public partial class Overlay : Form
    {
        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);


 

        public Overlay()
        {
            InitializeComponent();
            InitializeFormProperties();
            InitializeThreads();
        }
        private void InitializeFormProperties()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.AllowTransparency = true;
            this.BackColor = Color.Wheat;
            CheckForIllegalCrossThreadCalls = false;
            this.TransparencyKey = Color.Wheat;
            this.TopMost = true;
            int initialStyle = Imps.GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x8000 | 0x20);
            HotkeyPanel.SetRoundedRegion(15);

            InfoPanel.SetRoundedRegion(15);
        }

        private void InitializeThreads()
        {
            Thread showHideHotkeysThread = new Thread(ShowHideHotkeys);
            showHideHotkeysThread.Start();

            var T = "";
            Task.Run(async () =>
            {
                while (true)
                {
                    if (GTA_PROCESS != null)
                    {
                        if (GTA_PROCESS.HasExited)
                        {
                            GTA_PROCESS = null;
                            IsProcessOpen = false;
                        }
                    }
                    AttemptOpenProcess();
                    AmmoLoop();
                    RainbowCar_Loop();
                    AutoRP_Loop();
                    T = IsProcessOpen ? MemLib.mProc.Process.ProcessName.ToString() + " Wealth Booster Overlay " : "Please Open GTA5 !";
                    if (ConnectionText.Text != T)
                        ConnectionText.Text = T;
                    ConnectionText.ForeColor = IsProcessOpen ? Color.Green : Color.Red;
                    await Task.Delay(100);
                }
            });
        }
        private void ShowHideHotkeys()
        {
            bool isKeyPressed = false;
            hotkeysShowing = HotkeyPanel.Visible;
            while (true)
            {
                bool currentState = GetAsyncKeyState(Keys.F5) < 0;
                if (currentState && !isKeyPressed)
                {
                    hotkeysShowing = !hotkeysShowing;
                    if (hotkeysShowing)
                    {
                        HotkeyPanel.Invoke(new Action(() => HotkeyPanel.Show()));
                    }
                    else
                    {
                        HotkeyPanel.Invoke(new Action(() => HotkeyPanel.Hide()));
                    }
                    isKeyPressed = true;
                }
                else if (!currentState)
                {
                    isKeyPressed = false;
                }
                Thread.Sleep(70);
            }
        }


        private void SharedTimerOverlay_Tick(object sender, EventArgs e)
        {
            ArmorLabel.Text = "Armor : " + MemLib.ReadFloat(CPed + "+" + player_armor_).ToString("F2");
            HealthLabel.Text = "Health : " + MemLib.ReadFloat(CPed + "+" + player_health_).ToString("F2");
            PosXLabel.Text = "Pos X : " + MemLib.ReadFloat(CNavigation + "+" + player_coord_x_).ToString("F2");
            PosYLabel.Text = "Pos Y : " + MemLib.ReadFloat(CNavigation + "+" + player_coord_y_).ToString("F2");
            PosZLabel.Text = "Pos Z : " + MemLib.ReadFloat(CNavigation + "+" + player_coord_z_).ToString("F2");
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            CreateRequiredFolders();
            Menu MenuForm = new Menu();
            MenuForm.Show();
            TimerManager.SharedTimerTick += SharedTimerOverlay_Tick;

        }
        private void CreateRequiredFolders()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string wealthBoosterPath = Path.Combine(desktopPath, "WealthBooster");

            
            if (!Directory.Exists(wealthBoosterPath))
                Directory.CreateDirectory(wealthBoosterPath);

           
            string vehicleHandlingPath = Path.Combine(wealthBoosterPath, "Vehicle Handling");
            if (!Directory.Exists(vehicleHandlingPath))
                Directory.CreateDirectory(vehicleHandlingPath);

            
            string weaponDataPath = Path.Combine(wealthBoosterPath, "Weapon Data");
            if (!Directory.Exists(weaponDataPath))
                Directory.CreateDirectory(weaponDataPath);

           
            string teleportLocationsPath = Path.Combine(wealthBoosterPath, "Teleport Locations");
            if (!Directory.Exists(teleportLocationsPath))
                Directory.CreateDirectory(teleportLocationsPath);
        }
        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedTimerOverlay.Stop();
        }
    }
}
