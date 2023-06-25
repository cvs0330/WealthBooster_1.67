using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static WealthBooster.Bools;

namespace WealthBooster
{
    public partial class Menu : Form
    {

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        private PlayerMenu playerMenuForm;
        private WeaponMenu weaponMenuForm;
        private VehicleMenu vehicleMenuForm;
        private TeleportMenu teleportMenuForm;
        private MoneyMenu moneyMenuForm;
        private WorldMenu worldMenuForm;
        private Form currentForm;

        


        public Menu()
        {
            InitializeComponent();
            InitializeFormProperties();



            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Thread shm = new Thread(ShowHideMenu);
            shm.Start();

            playerMenuForm = new PlayerMenu();
            weaponMenuForm = new WeaponMenu();
            vehicleMenuForm = new VehicleMenu();
            teleportMenuForm = new TeleportMenu();
            moneyMenuForm = new MoneyMenu();
            worldMenuForm = new WorldMenu();


            HideForm(playerMenuForm);
            HideForm(weaponMenuForm);
            HideForm(vehicleMenuForm);
            HideForm(teleportMenuForm);
            HideForm(moneyMenuForm);
            HideForm(worldMenuForm);
            currentForm = null;
        }

        private void InitializeFormProperties()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            this.SetRoundedRegion(15);

            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;

            this.Left = screenWidth - formWidth;
            this.Top = screenHeight / 2 - formHeight / 1;
        }

        private void ShowMainMenu()
        {
            this.Invoke(new Action(() =>
            {
                this.Show();
                if (currentForm != null)
                {
                    Cursor.Position = new Point(currentForm.Location.X + currentForm.Size.Width / 2, currentForm.Location.Y + currentForm.Size.Height / 2);
                }
                else
                {
                    Cursor.Position = new Point(this.Location.X + this.Size.Width / 2, this.Location.Y + this.Size.Height / 2);
                }
                SetForegroundWindow(this.Handle);
                this.Activate();
                this.Focus();
            }));
        }

        private void ShowHideMenu()
        {
            bool isGKeyPressed = false;
            bool isDeleteKeyPressed = false;

            while (true)
            {
                bool currentGKeyState = GetAsyncKeyState(Keys.G) < 0;
                bool currentDeleteKeyState = GetAsyncKeyState(Keys.Delete) < 0;

                if (currentGKeyState && !isGKeyPressed)
                {
                    mainMenuVisible = !mainMenuVisible;

                    if (mainMenuVisible)
                    {
                        ShowMainMenu();
                        ShowCurrentSubmenuForm();
                    }
                    else
                    {
                        HideMainMenu();
                        HideCurrentSubmenuForm();
                    }
                }

                if (currentDeleteKeyState && !isDeleteKeyPressed)
                {
                    Environment.Exit(0);
                }

                isGKeyPressed = currentGKeyState;
                isDeleteKeyPressed = currentDeleteKeyState;

                Thread.Sleep(70);
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            TimerManager.StartTimer(100, SharedTimer_Tick);
        }

        private void ShowHideSubmenu(Form form)
        {
            if (currentForm == form)
            {
                HideForm(form);
                currentForm = null;
            }
            else
            {
                HideCurrentSubmenuForm();
                ShowForm(form);
                currentForm = form;
            }
        }
        private void HideMainMenu()
        {
            this.Invoke(new Action(() => this.Hide()));
            Process[] p = Process.GetProcessesByName("GTA5");
            if (p.Length > 0)
            {
                SetForegroundWindow(p[0].MainWindowHandle);
            }
        }

        private void ShowCurrentSubmenuForm()
        {
            if (currentForm != null)
            {
                ShowForm(currentForm);
            }
        }

        private void HideCurrentSubmenuForm()
        {
            if (currentForm != null)
            {
                HideForm(currentForm);
            }
        }

        private void ShowForm(Form form)
        {
            form.Visible = true;
            form.Enabled = true;
            form.BringToFront();
            form.Focus();
        }

        private void HideForm(Form form)
        {
            form.Visible = false;
            form.Enabled = false;
        }

        private void SharedTimer_Tick(object sender, EventArgs e)
        {

        }

        private void PlayerMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(playerMenuForm);

        }
        private void WeaponMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(weaponMenuForm);
        }

        private void VehicleMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(vehicleMenuForm);
        }

        private void TeleportMenuButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(teleportMenuForm);
        }

        private void MoneyRpPageButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(moneyMenuForm);
        }

        private void WorldPageButton_Click(object sender, EventArgs e)
        {
            ShowHideSubmenu(worldMenuForm);
        }
    }
}
