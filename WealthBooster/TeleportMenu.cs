using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static WealthBooster.Player;
using static WealthBooster.Vehicle;
using static WealthBooster.GetAddress;
using static WealthBooster.SigScan;
using System.Runtime.InteropServices;

namespace WealthBooster
{
    public partial class TeleportMenu : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);


        public TeleportMenu()
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

        private void tpAmmuNation_Click(object sender, EventArgs e)
        {
            player_coord_x = 14;
            player_coord_y = -1121;
            player_coord_z = 29;
            player_visual_coord_x = 14;
            player_visual_coord_y = -1121;
            player_visual_coord_z = 29;

        }

        private void tpPonsonbys_Click(object sender, EventArgs e)
        {
            player_coord_x = -721;
            player_visual_coord_x = -721;
            player_coord_y = -159;
            player_visual_coord_y = -159;
            player_coord_z = 38;
            player_visual_coord_z = 38;




        }

        private void tpBarberShop_Click(object sender, EventArgs e)
        {
            player_coord_x = -828;
            player_visual_coord_x = -828;
            player_coord_y = -191;
            player_visual_coord_y = -191;
            player_coord_z = 38;
            player_visual_coord_z = 38;
        }

        private void tpVespucciMasks_Click(object sender, EventArgs e)
        {
            player_coord_x = -1341;
            player_visual_coord_x = -1341;
            player_coord_y = -1280;
            player_visual_coord_y = -1280;
            player_coord_z = 5;
            player_visual_coord_z = 5;
        }

        private void tpTattooShop_Click(object sender, EventArgs e)
        {
            player_coord_x = -1159;
            player_visual_coord_x = -1159;
            player_coord_y = -1420;
            player_visual_coord_y = -1420;
            player_coord_z = 5;
            player_visual_coord_z = 5;
        }

        private void tpGolfClub_Click(object sender, EventArgs e)
        {
            player_coord_x = -1381;
            player_visual_coord_x = -1381;
            player_coord_y = 58;
            player_visual_coord_y = 58;
            player_coord_z = 54;
            player_visual_coord_z = 54;
        }

        private void tpSuburban_Click(object sender, EventArgs e)
        {
            player_coord_x = 130;
            player_visual_coord_x = 130;
            player_coord_y = -202;
            player_visual_coord_y = -202;
            player_coord_z = 55;
            player_visual_coord_z = 55;
        }

        private void tpBinco_Click(object sender, EventArgs e)
        {
            player_coord_x = 414;
            player_visual_coord_x = 414;
            player_coord_y = -807;
            player_visual_coord_y = -807;
            player_coord_z = 30;
            player_visual_coord_z = 30;
        }

        private void tpDarts_Click(object sender, EventArgs e)
        {
            player_coord_x = 1996;
            player_visual_coord_x = 1996;
            player_coord_y = 3059;
            player_visual_coord_y = 3059;
            player_coord_z = 47;
            player_visual_coord_z = 47;
        }

        private void tpDiscountStore_Click(object sender, EventArgs e)
        {
            player_coord_x = 88;
            player_visual_coord_x = 88;
            player_coord_y = -1392;
            player_visual_coord_y = -1392;
            player_coord_z = 29;
            player_visual_coord_z = 29;
        }

        private void tpStripClub_Click(object sender, EventArgs e)
        {
            player_coord_x = 133;
            player_visual_coord_x = 133;
            player_coord_y = -1306;
            player_visual_coord_y = -1306;
            player_coord_z = 29;
            player_visual_coord_z = 29;
        }

        private void tpHighway_Click(object sender, EventArgs e)
        {
            player_coord_x = -952;
            player_visual_coord_x = -952;
            player_coord_y = -571;
            player_visual_coord_y = -571;
            player_coord_z = 18;
            player_visual_coord_z = 18;
        }

        private void tpLSC_Click(object sender, EventArgs e)
        {
            player_coord_x = -371;
            player_visual_coord_x = -371;
            player_coord_y = -130;
            player_visual_coord_y = -130;
            player_coord_z = 38;
            player_visual_coord_z = 38;
            vehicle_coord_x = -371;
            vehicle_coord_y = -130;
            vehicle_coord_z = 38;
        }

        private void tpCarMeeting_Click(object sender, EventArgs e)
        {
            player_coord_x = 790;
            player_visual_coord_x = 790;
            player_coord_y = -1867;
            player_visual_coord_y = -1867;
            player_coord_z = 29;
            player_visual_coord_z = 29;
            vehicle_coord_x = 790;
            vehicle_coord_y = -1867;
            vehicle_coord_z = 29;
        }

        private void tpBeekers_Click(object sender, EventArgs e)
        {
            player_coord_x = 120;
            player_visual_coord_x = 120;
            player_coord_y = 6613;
            player_visual_coord_y = 6613;
            player_coord_z = 31;
            player_visual_coord_z = 31;
            vehicle_coord_x = 120;
            vehicle_coord_y = 6613;
            vehicle_coord_z = 31;
        }

        private void tpBennys_Click(object sender, EventArgs e)
        {
            player_coord_x = -203;
            player_visual_coord_x = -203;
            player_coord_y = -1300;
            player_visual_coord_y = -1300;
            player_coord_z = 31;
            player_visual_coord_z = 31;
            vehicle_coord_x = -203;
            vehicle_coord_y = -1300;
            vehicle_coord_z = 31;
        }

    



        private void SetCustomLocationButton_Click(object sender, EventArgs e)
        {
            SetCustomLocation();
        }

        private void SetCustomLocation()
        {

            string selectedLocation = CustomTeleportLocations.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedLocation))
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Teleport Locations", "Custom_Locations.txt");

                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    List<LocationData> locations = new List<LocationData>();
                    LocationData currentLocation = null;

                    foreach (string line in lines)
                    {
                        if (line.StartsWith("Location Name:"))
                        {
                            if (currentLocation != null)
                                locations.Add(currentLocation);

                            currentLocation = new LocationData();
                            currentLocation.Name = line.Substring("Location Name:".Length).Trim();
                        }
                        else if (line.StartsWith("X = :"))
                        {
                            currentLocation.X = float.Parse(line.Substring("X = :".Length).Trim());
                        }
                        else if (line.StartsWith("Y = :"))
                        {
                            currentLocation.Y = float.Parse(line.Substring("Y = :".Length).Trim());
                        }
                        else if (line.StartsWith("Z = :"))
                        {
                            currentLocation.Z = float.Parse(line.Substring("Z = :".Length).Trim());
                        }
                    }

                    if (currentLocation != null)
                        locations.Add(currentLocation);

                    LocationData selectedLocationData = locations.FirstOrDefault(loc => loc.Name == selectedLocation);
                    if (selectedLocationData != null)
                    {
                        player_coord_x = selectedLocationData.X;
                        player_visual_coord_x = selectedLocationData.X;
                        player_coord_y = selectedLocationData.Y;
                        player_visual_coord_y = selectedLocationData.Y;
                        player_coord_z = selectedLocationData.Z;
                        player_visual_coord_z = selectedLocationData.Z;
                        vehicle_coord_x = selectedLocationData.X;
                        vehicle_coord_y = selectedLocationData.Y;
                        vehicle_coord_z = selectedLocationData.Z;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        public class LocationData
        {
            public string Name { get; set; }
            public float X { get; set; }
            public float Y { get; set; }
            public float Z { get; set; }
        }

        private void SaveCustomLocationButton_Click(object sender, EventArgs e)
        {
            SaveCustomLocation();
        }

        private void SaveCustomLocation()
        {
            string locationName = CustomLocationNameBox.Text.Trim();

            if (string.IsNullOrEmpty(locationName))
            {

                return;
            }

            float x = player_coord_x;
            float y = player_coord_y;
            float z = player_coord_z;

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Teleport Locations", "Custom_Locations.txt");

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine("Location Name: " + locationName);
                sw.WriteLine("X = : " + x);
                sw.WriteLine("Y = : " + y);
                sw.WriteLine("Z = : " + z);
                sw.WriteLine("////////////////////////////////");
            }

            MessageBox.Show("Custom location saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            CustomLocationNameBox.Text = string.Empty;


            RefreshCustomLocations();
        }


        private void RefreshCustomLocations()
        {
            CustomTeleportLocations.Items.Clear();

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Teleport Locations", "Custom_Locations.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                List<LocationData> locations = new List<LocationData>();
                LocationData currentLocation = null;

                foreach (string line in lines)
                {
                    if (line.StartsWith("Location Name:"))
                    {
                        if (currentLocation != null)
                            locations.Add(currentLocation);

                        currentLocation = new LocationData();
                        currentLocation.Name = line.Substring("Location Name:".Length).Trim();
                    }
                    else if (line.StartsWith("X = :"))
                    {
                        currentLocation.X = float.Parse(line.Substring("X = :".Length).Trim());
                    }
                    else if (line.StartsWith("Y = :"))
                    {
                        currentLocation.Y = float.Parse(line.Substring("Y = :".Length).Trim());
                    }
                    else if (line.StartsWith("Z = :"))
                    {
                        currentLocation.Z = float.Parse(line.Substring("Z = :".Length).Trim());
                    }
                }

                if (currentLocation != null)
                    locations.Add(currentLocation);

                foreach (LocationData location in locations)
                {
                    CustomTeleportLocations.Items.Add(location.Name);
                }
            }
        }
        private void CustomTeleportLocations_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.DrawBackground();
            if (e.Index >= 0)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(Brushes.Purple, e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.DimGray, e.Bounds);
                }
                string itemText = listBox.Items[e.Index].ToString();
                e.Graphics.DrawString(itemText, e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }
        private void G1_Click(object sender, EventArgs e)
        {
            X1.Text = MemLib.ReadFloat(CNavigation + "+" + player_coord_x_).ToString("F2");
            Y1.Text = MemLib.ReadFloat(CNavigation + "+" + player_coord_y_).ToString("F2");
            Z1.Text = MemLib.ReadFloat(CNavigation + "+" + player_coord_z_).ToString("F2");
        }
        private void S1_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(CNavigation + "+" + player_coord_x_, "float", X1.Text);
            MemLib.WriteMemory(CNavigation + "+" + player_coord_y_, "float", Y1.Text);
            MemLib.WriteMemory(CNavigation + "+" + player_coord_z_, "float", Z1.Text);
            MemLib.WriteMemory(CPed + "+" + player_visual_coord_x_, "float", X1.Text);
            MemLib.WriteMemory(CPed + "+" + player_visual_coord_y_, "float", Y1.Text);
            MemLib.WriteMemory(CPed + "+" + player_visual_coord_z_, "float", Z1.Text);
            MemLib.WriteMemory(CVehicleStuff + "+" + vehicle_coord_x_, "float", X1.Text);
            MemLib.WriteMemory(CVehicleStuff + "+" + vehicle_coord_y_, "float", Y1.Text);
            MemLib.WriteMemory(CVehicleStuff + "+" + vehicle_coord_z_, "float", Z1.Text);
        }
        private void G2_Click(object sender, EventArgs e)
        {
            X2.Text = MemLib.ReadFloat(CNavigation + "+" + player_coord_x_).ToString("F2");
            Y2.Text = MemLib.ReadFloat(CNavigation + "+" + player_coord_y_).ToString("F2");
            Z2.Text = MemLib.ReadFloat(CNavigation + "+" + player_coord_z_).ToString("F2");
        }
        private void S2_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(CNavigation + "+" + player_coord_x_, "float", X2.Text);
            MemLib.WriteMemory(CNavigation + "+" + player_coord_y_, "float", Y2.Text);
            MemLib.WriteMemory(CNavigation + "+" + player_coord_z_, "float", Z2.Text);
            MemLib.WriteMemory(CPed + "+" + player_visual_coord_x_, "float", X2.Text);
            MemLib.WriteMemory(CPed + "+" + player_visual_coord_y_, "float", Y2.Text);
            MemLib.WriteMemory(CPed + "+" + player_visual_coord_z_, "float", Z2.Text);
            MemLib.WriteMemory(CVehicleStuff + "+" + vehicle_coord_x_, "float", X2.Text);
            MemLib.WriteMemory(CVehicleStuff + "+" + vehicle_coord_y_, "float", Y2.Text);
            MemLib.WriteMemory(CVehicleStuff + "+" + vehicle_coord_z_, "float", Z2.Text);
        }
        private void SharedTimerTeleport_Tick(object sender, EventArgs e)
        {
            if (GetAsyncKeyState(Keys.NumPad7) < 0)
            {
                G1_Click(sender, e);
            }
            if (GetAsyncKeyState(Keys.NumPad4) < 0)
            {
                S1_Click(sender, e);
            }
            if (GetAsyncKeyState(Keys.NumPad9) < 0)
            {
                G2_Click(sender, e);
            }
            if (GetAsyncKeyState(Keys.NumPad6) < 0)
            {
                S2_Click(sender, e);
            }
        }

        private void TeleportMenu_Load(object sender, EventArgs e)
        {
            CustomTeleportLocations.DrawMode = DrawMode.OwnerDrawFixed;
            CustomTeleportLocations.DrawItem += CustomTeleportLocations_DrawItem;
            TimerManager.SharedTimerTick += SharedTimerTeleport_Tick;
            SaveCustomLocationButton.Click += SaveCustomLocationButton_Click;
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Teleport Locations", "Custom_Locations.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                List<LocationData> locations = new List<LocationData>();
                LocationData currentLocation = null;

                foreach (string line in lines)
                {
                    if (line.StartsWith("Location Name:"))
                    {
                        if (currentLocation != null)
                            locations.Add(currentLocation);

                        currentLocation = new LocationData();
                        currentLocation.Name = line.Substring("Location Name:".Length).Trim();
                    }
                    else if (line.StartsWith("X = :"))
                    {
                        currentLocation.X = float.Parse(line.Substring("X = :".Length).Trim());
                    }
                    else if (line.StartsWith("Y = :"))
                    {
                        currentLocation.Y = float.Parse(line.Substring("Y = :".Length).Trim());
                    }
                    else if (line.StartsWith("Z = :"))
                    {
                        currentLocation.Z = float.Parse(line.Substring("Z = :".Length).Trim());
                    }
                }

                if (currentLocation != null)
                    locations.Add(currentLocation);

                foreach (LocationData location in locations)
                {
                    CustomTeleportLocations.Items.Add(location.Name);
                }
            }
        }

        private void TeleportMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            SharedTimerTeleport.Stop();
        }
    }





}
