using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


using static WealthBooster.SigScan;
using static WealthBooster.GetAddress;
using static WealthBooster.Vehicle;
using static WealthBooster.Globals;
using static WealthBooster.AiHandling;
using static WealthBooster.LicensePlateTextClass;
using System.Threading;
using Microsoft.VisualBasic.Devices;
using WealthBooster;

namespace WealthBooster
{
    public partial class VehicleMenu : Form
    {
        public VehicleMenu()
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

        private void GetHandling_Click(object sender, EventArgs e)
        {
            tbmass.Text = MemLib.ReadFloat(CHandlingData + "+" + mass).ToString("F4");
            tbsuspension_force.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_force).ToString("F4");
            tbupshift.Text = MemLib.ReadFloat(CHandlingData + "+" + upshift).ToString("F4");
            tbdownshift.Text = MemLib.ReadFloat(CHandlingData + "+" + downshift).ToString("F4");
            tbsuspension_raise.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_raise).ToString("F4");
            tbsuspension_lower_limit.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_lower_limit).ToString("F4");
            tbsuspension_upper_limit.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_upper_limit).ToString("F4");
            tbsuspension_rebound_damp.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_rebound_damp).ToString("F4");
            tbsuspension_comp_damp.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_comp_damp).ToString("F4");
            tbroll_centre_height_rear.Text = MemLib.ReadFloat(CHandlingData + "+" + roll_centre_height_rear).ToString("F4");
            tbtraction_loss_mult.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_loss_mult).ToString("F4");
            tbcamber_stiffness.Text = MemLib.ReadFloat(CHandlingData + "+" + camber_stiffness).ToString("F4");
            tbtraction_bias_rear.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_bias_rear).ToString("F4");
            tbtraction_bias_front.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_bias_front).ToString("F4");
            tbanti_rollbar_bias_rear.Text = MemLib.ReadFloat(CHandlingData + "+" + anti_rollbar_bias_rear).ToString("F4");
            tbroll_centre_height_front.Text = MemLib.ReadFloat(CHandlingData + "+" + roll_centre_height_front).ToString("F4");
            tbbrake_force.Text = MemLib.ReadFloat(CHandlingData + "+" + brake_force).ToString("F4");
            tbhandbrake_force.Text = MemLib.ReadFloat(CHandlingData + "+" + handbrake_force).ToString("F4");
            tbbrake_bias_front.Text = MemLib.ReadFloat(CHandlingData + "+" + brake_bias_front).ToString("F4");
            tbbrake_bias_rear.Text = MemLib.ReadFloat(CHandlingData + "+" + brake_bias_rear).ToString("F4");
            tbsteering_lock.Text = MemLib.ReadFloat(CHandlingData + "+" + steering_lock).ToString("F4");
            tbsteering_lock_ratio.Text = MemLib.ReadFloat(CHandlingData + "+" + steering_lock_ratio).ToString("F4");
            tbtraction_curve_max.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_curve_max).ToString("F4");
            tbtraction_curve_lateral.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_curve_lateral).ToString("F4");
            tbtraction_curve_min.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_curve_min).ToString("F4");
            tbtraction_curve_ratio.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_curve_ratio).ToString("F4");
            tbcurve_lateral.Text = MemLib.ReadFloat(CHandlingData + "+" + curve_lateral).ToString("F4");
            tbcurve_lateral_ratio.Text = MemLib.ReadFloat(CHandlingData + "+" + curve_lateral_ratio).ToString("F4");
            tbbuoyancy.Text = MemLib.ReadFloat(CHandlingData + "+" + buoyancy).ToString("F4");
            tbanti_rollbar_force.Text = MemLib.ReadFloat(CHandlingData + "+" + anti_rollbar_force).ToString("F4");
            tbanti_rollbar_bias_front.Text = MemLib.ReadFloat(CHandlingData + "+" + anti_rollbar_bias_front).ToString("F4");
            tbinitial_drag_coeff.Text = MemLib.ReadFloat(CHandlingData + "+" + initial_drag_coeff).ToString("F4");
            tbdownforce_multiplier.Text = MemLib.ReadFloat(CHandlingData + "+" + downforce_multiplier).ToString("F4");
            tbpopup_light_rotation.Text = MemLib.ReadFloat(CHandlingData + "+" + popup_light_rotation).ToString("F4");
            tblow_speed_traction_loss_mult.Text = MemLib.ReadFloat(CHandlingData + "+" + low_speed_traction_loss_mult).ToString("F4");
            tbtraction_spring_delta_max_ratio.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_spring_delta_max_ratio).ToString("F4");
            tbtraction_spring_delta_max.Text = MemLib.ReadFloat(CHandlingData + "+" + traction_spring_delta_max).ToString("F4");
            tbdrive_bias_rear.Text = MemLib.ReadFloat(CHandlingData + "+" + drive_bias_rear).ToString("F4");
            tbdrive_bias_front.Text = MemLib.ReadFloat(CHandlingData + "+" + drive_bias_front).ToString("F4");
            tbacceleration.Text = MemLib.ReadFloat(CHandlingData + "+" + acceleration).ToString("F4");
            tbdrive_inertia.Text = MemLib.ReadFloat(CHandlingData + "+" + drive_inertia).ToString("F4");
            tbinitial_drive_force.Text = MemLib.ReadFloat(CHandlingData + "+" + initial_drive_force).ToString("F4");
            tbdrive_max_flat_velocity.Text = MemLib.ReadFloat(CHandlingData + "+" + drive_max_flat_velocity).ToString("F4");
            tbinitial_drive_max_flat_vel.Text = MemLib.ReadFloat(CHandlingData + "+" + initial_drive_max_flat_vel).ToString("F4");
            tbsuspension_bias_front.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_bias_front).ToString("F4");
            tbsuspension_bias_rear.Text = MemLib.ReadFloat(CHandlingData + "+" + suspension_bias_rear).ToString("F4");
            tbgravity.Text = MemLib.ReadFloat(CVehicle + "+" + vehicle_gravity_).ToString("F4");
            tbcolldmgmult.Text = MemLib.ReadFloat(CHandlingData + "+" + collision_damage_mult).ToString("F4");
            tbweapon_damage_mult.Text = MemLib.ReadFloat(CHandlingData + "+" + weapon_damage_mult).ToString("F4");
            tbdeformation_mult.Text = MemLib.ReadFloat(CHandlingData + "+" + deformation_mult).ToString("F4");
            tbengine_damage_mult.Text = MemLib.ReadFloat(CHandlingData + "+" + engine_damage_mult).ToString("F4");
            tbpetrol_tank_volume.Text = MemLib.ReadFloat(CHandlingData + "+" + petrol_tank_volume).ToString("F4");
            tboil_volume.Text = MemLib.ReadFloat(CHandlingData + "+" + oil_volume).ToString("F4");
            tbvehicle_headlightmult_.Text = MemLib.ReadFloat(CVehicle + "+" + vehicle_headlightmult_).ToString("F4");
            tbvehicle_boost_recharge_.Text = MemLib.ReadFloat(CVehicle + "+" + vehicle_boost_recharge_).ToString("F4");

        }

        private void SetHandling_Click(object sender, EventArgs e)
        {
            string[] values = { tbmass.Text, tbsuspension_force.Text, tbupshift.Text, tbdownshift.Text, tbsuspension_raise.Text, tbsuspension_lower_limit.Text, tbsuspension_upper_limit.Text, tbsuspension_rebound_damp.Text, tbsuspension_comp_damp.Text, tbroll_centre_height_rear.Text, tbtraction_loss_mult.Text, tbcamber_stiffness.Text, tbtraction_bias_rear.Text, tbtraction_bias_front.Text, tbanti_rollbar_bias_rear.Text, tbroll_centre_height_front.Text, tbbrake_force.Text, tbhandbrake_force.Text, tbbrake_bias_front.Text, tbbrake_bias_rear.Text, tbsteering_lock.Text, tbsteering_lock_ratio.Text, tbtraction_curve_max.Text, tbtraction_curve_lateral.Text, tbtraction_curve_min.Text, tbtraction_curve_ratio.Text, tbcurve_lateral.Text, tbcurve_lateral_ratio.Text, tbbuoyancy.Text, tbanti_rollbar_force.Text, tbanti_rollbar_bias_front.Text, tbinitial_drag_coeff.Text, tbdownforce_multiplier.Text, tbpopup_light_rotation.Text, tblow_speed_traction_loss_mult.Text, tbtraction_spring_delta_max_ratio.Text, tbtraction_spring_delta_max.Text, tbdrive_bias_rear.Text, tbdrive_bias_front.Text, tbacceleration.Text, tbdrive_inertia.Text, tbinitial_drive_force.Text, tbdrive_max_flat_velocity.Text, tbinitial_drive_max_flat_vel.Text, tbsuspension_bias_front.Text, tbsuspension_bias_rear.Text, tbcolldmgmult.Text, tbweapon_damage_mult.Text, tbdeformation_mult.Text, tbengine_damage_mult.Text, tbpetrol_tank_volume.Text, tboil_volume.Text };
            string[] offsets = { mass, suspension_force, upshift, downshift, suspension_raise, suspension_lower_limit, suspension_upper_limit, suspension_rebound_damp, suspension_comp_damp, roll_centre_height_rear, traction_loss_mult, camber_stiffness, traction_bias_rear, traction_bias_front, anti_rollbar_bias_rear, roll_centre_height_front, brake_force, handbrake_force, brake_bias_front, brake_bias_rear, steering_lock, steering_lock_ratio, traction_curve_max, traction_curve_lateral, traction_curve_min, traction_curve_ratio, curve_lateral, curve_lateral_ratio, buoyancy, anti_rollbar_force, anti_rollbar_bias_front, initial_drag_coeff, downforce_multiplier, popup_light_rotation, low_speed_traction_loss_mult, traction_spring_delta_max_ratio, traction_spring_delta_max, drive_bias_rear, drive_bias_front, acceleration, drive_inertia, initial_drive_force, drive_max_flat_velocity, initial_drive_max_flat_vel, suspension_bias_front, suspension_bias_rear, collision_damage_mult, weapon_damage_mult, deformation_mult, engine_damage_mult, petrol_tank_volume, oil_volume };
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != "")
                    MemLib.WriteMemory(CHandlingData + "+" + offsets[i], "float", values[i]);

            }
            MemLib.WriteMemory(CVehicle + "+" + vehicle_gravity_, "float", tbgravity.Text);
            MemLib.WriteMemory(CVehicle + "+" + vehicle_headlightmult_, "float", tbvehicle_headlightmult_.Text);
            MemLib.WriteMemory(CVehicle + "+" + vehicle_boost_recharge_, "float", tbvehicle_boost_recharge_.Text);

        }

        private void SaveHandling_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Vehicle Handling");
            Directory.CreateDirectory(folderPath);

            string configName = tbConfigName.Text;
            string fileName = GenerateUniqueFileName(folderPath, configName, "Handling");

            string filePath = Path.Combine(folderPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("---------------");
                writer.WriteLine("Vehicle Handling Configuration File (this file can be shared with other Wealth Booster Users)");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("Config Name: " + tbConfigName.Text);
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("VEHICLE HANDLING DATA");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("Mass: " + tbmass.Text);
                writer.WriteLine("Suspension Force: " + tbsuspension_force.Text);
                writer.WriteLine("Upshift: " + tbupshift.Text);
                writer.WriteLine("Downshift: " + tbdownshift.Text);
                writer.WriteLine("Suspension Raise: " + tbsuspension_raise.Text);
                writer.WriteLine("Suspension Lower Limit: " + tbsuspension_lower_limit.Text);
                writer.WriteLine("Suspension Upper Limit: " + tbsuspension_upper_limit.Text);
                writer.WriteLine("Suspension Rebound Damp: " + tbsuspension_rebound_damp.Text);
                writer.WriteLine("Suspension Comp Damp: " + tbsuspension_comp_damp.Text);
                writer.WriteLine("Roll Centre Height Rear: " + tbroll_centre_height_rear.Text);
                writer.WriteLine("Traction Loss Mult: " + tbtraction_loss_mult.Text);
                writer.WriteLine("Camber Stiffness: " + tbcamber_stiffness.Text);
                writer.WriteLine("Traction Bias Rear: " + tbtraction_bias_rear.Text);
                writer.WriteLine("Traction Bias Front: " + tbtraction_bias_front.Text);
                writer.WriteLine("Anti Rollbar Bias Rear: " + tbanti_rollbar_bias_rear.Text);
                writer.WriteLine("Roll Centre Height Front: " + tbroll_centre_height_front.Text);
                writer.WriteLine("Brake Force: " + tbbrake_force.Text);
                writer.WriteLine("Handbrake Force: " + tbhandbrake_force.Text);
                writer.WriteLine("Brake Bias Front: " + tbbrake_bias_front.Text);
                writer.WriteLine("Brake Bias Rear: " + tbbrake_bias_rear.Text);
                writer.WriteLine("Steering Lock: " + tbsteering_lock.Text);
                writer.WriteLine("Steering Lock Ratio: " + tbsteering_lock_ratio.Text);
                writer.WriteLine("Traction Curve Max: " + tbtraction_curve_max.Text);
                writer.WriteLine("Traction Curve Lateral: " + tbtraction_curve_lateral.Text);
                writer.WriteLine("Traction Curve Min: " + tbtraction_curve_min.Text);
                writer.WriteLine("Traction Curve Ratio: " + tbtraction_curve_ratio.Text);
                writer.WriteLine("Curve Lateral: " + tbcurve_lateral.Text);
                writer.WriteLine("Curve Lateral Ratio: " + tbcurve_lateral_ratio.Text);
                writer.WriteLine("Buoyancy: " + tbbuoyancy.Text);
                writer.WriteLine("Anti Rollbar Force: " + tbanti_rollbar_force.Text);
                writer.WriteLine("Anti Rollbar Bias Front: " + tbanti_rollbar_bias_front.Text);
                writer.WriteLine("Initial Drag Coeff: " + tbinitial_drag_coeff.Text);
                writer.WriteLine("Downforce Multiplier: " + tbdownforce_multiplier.Text);
                writer.WriteLine("Popup Light Rotation: " + tbpopup_light_rotation.Text);
                writer.WriteLine("Low Speed Traction Loss Mult: " + tblow_speed_traction_loss_mult.Text);
                writer.WriteLine("Traction Spring Delta Max Ratio: " + tbtraction_spring_delta_max_ratio.Text);
                writer.WriteLine("Traction Spring Delta Max: " + tbtraction_spring_delta_max.Text);
                writer.WriteLine("Drive Bias Rear: " + tbdrive_bias_rear.Text);
                writer.WriteLine("Drive Bias Front: " + tbdrive_bias_front.Text);
                writer.WriteLine("Acceleration: " + tbacceleration.Text);
                writer.WriteLine("Drive Inertia: " + tbdrive_inertia.Text);
                writer.WriteLine("Initial Drive Force: " + tbinitial_drive_force.Text);
                writer.WriteLine("Drive Max Flat Velocity: " + tbdrive_max_flat_velocity.Text);
                writer.WriteLine("Initial Drive Max Flat Vel: " + tbinitial_drive_max_flat_vel.Text);
                writer.WriteLine("Suspension Bias Front: " + tbsuspension_bias_front.Text);
                writer.WriteLine("Suspension Bias Rear: " + tbsuspension_bias_rear.Text);
                writer.WriteLine("Gravity: " + tbgravity.Text);
                writer.WriteLine("Collision Damage Multiplier: " + tbcolldmgmult.Text);
                writer.WriteLine("Weapon Damage Multiplier: " + tbweapon_damage_mult.Text);
                writer.WriteLine("Deformation Multiplier: " + tbdeformation_mult.Text);
                writer.WriteLine("Engine Damage Multiplier: " + tbengine_damage_mult.Text);
                writer.WriteLine("Petrol Tank Volume: " + tbpetrol_tank_volume.Text);
                writer.WriteLine("Oil Volume: " + tboil_volume.Text);
                writer.WriteLine("Headlight Multiplier: " + tbvehicle_headlightmult_.Text);


            }
            MessageBox.Show($"Handling File saved to {filePath}");

        }

        private string GenerateUniqueFileName(string folderPath, string configName, string fileNamePrefix)
        {
            string fileName = $"{fileNamePrefix}_{configName}.txt";
            int counter = 1;

            while (File.Exists(Path.Combine(folderPath, fileName)))
            {
                string extension = Path.GetExtension(fileName);
                string baseFileName = Path.GetFileNameWithoutExtension(fileName);
                fileName = $"{baseFileName}_{counter}{extension}";
                counter++;
            }

            return fileName;
        }


        private void LoadHandling_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Vehicle Handling"),
                Filter = "Handling files (*.txt)|*.txt",
                FilterIndex = 0,
                RestoreDirectory = true,
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                Dictionary<string, TextBox> handlingDataDict = new Dictionary<string, TextBox>
        {
            { "Config Name", tbConfigName },
            { "Mass", tbmass },
            { "Suspension Force", tbsuspension_force },
            { "Upshift", tbupshift },
            { "Downshift", tbdownshift },
            { "Suspension Raise", tbsuspension_raise },
            { "Suspension Lower Limit", tbsuspension_lower_limit },
            { "Suspension Upper Limit", tbsuspension_upper_limit },
            { "Suspension Rebound Damp", tbsuspension_rebound_damp },
            { "Suspension Comp Damp", tbsuspension_comp_damp },
            { "Roll Centre Height Rear", tbroll_centre_height_rear },
            { "Traction Loss Mult", tbtraction_loss_mult },
            { "Camber Stiffness", tbcamber_stiffness },
            { "Traction Bias Rear", tbtraction_bias_rear },
            { "Traction Bias Front", tbtraction_bias_front },
            { "Anti Rollbar Bias Rear", tbanti_rollbar_bias_rear },
            { "Roll Centre Height Front", tbroll_centre_height_front },
            { "Brake Force", tbbrake_force },
            { "Handbrake Force", tbhandbrake_force },
            { "Brake Bias Front", tbbrake_bias_front },
            { "Brake Bias Rear", tbbrake_bias_rear },
            { "Steering Lock", tbsteering_lock },
            { "Steering Lock Ratio", tbsteering_lock_ratio },
            { "Traction Curve Max", tbtraction_curve_max },
            { "Traction Curve Lateral", tbtraction_curve_lateral },
            { "Traction Curve Min", tbtraction_curve_min },
            { "Traction Curve Ratio", tbtraction_curve_ratio },
            { "Curve Lateral", tbcurve_lateral },
            { "Curve Lateral Ratio", tbcurve_lateral_ratio },
            { "Buoyancy", tbbuoyancy },
            { "Anti Rollbar Force", tbanti_rollbar_force },
            { "Anti Rollbar Bias Front", tbanti_rollbar_bias_front },
            { "Initial Drag Coeff", tbinitial_drag_coeff },
            { "Downforce Multiplier", tbdownforce_multiplier },
            { "Popup Light Rotation", tbpopup_light_rotation },
            { "Low Speed Traction Loss Mult", tblow_speed_traction_loss_mult },
            { "Traction Spring Delta Max Ratio", tbtraction_spring_delta_max_ratio },
            { "Traction Spring Delta Max", tbtraction_spring_delta_max },
            { "Drive Bias Rear", tbdrive_bias_rear },
            { "Drive Bias Front", tbdrive_bias_front },
            { "Acceleration", tbacceleration },
            { "Drive Inertia", tbdrive_inertia },
            { "Initial Drive Force", tbinitial_drive_force },
            { "Drive Max Flat Velocity", tbdrive_max_flat_velocity },
            { "Initial Drive Max Flat Vel", tbinitial_drive_max_flat_vel },
            { "Suspension Bias Front", tbsuspension_bias_front },
            { "Suspension Bias Rear", tbsuspension_bias_rear },
            { "Gravity", tbgravity },
            { "Collision Damage Multiplier", tbcolldmgmult },
            { "Weapon Damage Multiplier", tbweapon_damage_mult },
            { "Deformation Multiplier", tbdeformation_mult },
            { "Engine Damage Multiplier", tbengine_damage_mult },
            { "Petrol Tank Volume", tbpetrol_tank_volume },
            { "Oil Volume", tboil_volume },
            { "Headlight Multiplier", tbvehicle_headlightmult_ },

        };
                using (StreamReader reader = new StreamReader(selectedFilePath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string[] lineParts = reader.ReadLine().Split(':');
                        string name = lineParts[0].Trim();
                        string value = "";

                        if (lineParts.Length > 1)
                        {
                            value = lineParts[1].Trim();
                        }

                        if (handlingDataDict.ContainsKey(name))
                        {
                            handlingDataDict[name].Text = value;
                        }
                    }
                }
            }
        }




        private void AutoHealBox_CheckedChanged(object sender, EventArgs e)
        {
            Thread VehicleAutoHeal = new Thread(() =>
            {
                while (AutoHealBox.Checked)
                {
                    MemLib.WriteMemory(CVehicle + "+" + vehicle_health1_, "float", "1000");
                    MemLib.WriteMemory(CVehicle + "+" + vehicle_health2_, "float", "1000");
                    MemLib.WriteMemory(CVehicle + "+" + vehicle_health3_, "float", "1000");
                    MemLib.WriteMemory(CVehicle + "+" + vehicle_health4_, "float", "1000");
                }
            });
            if (AutoHealBox.Checked)
            {
                VehicleAutoHeal.Start();
            }
        }


        private void CarJMPRAMPPARA_Click(object sender, EventArgs e)
        {
            vehicle_extras = 864;
        }

        private void RocketBoost_Click(object sender, EventArgs e)
        {
            vehicle_extras = 64;
        }

        private void ResetCarMods_Click(object sender, EventArgs e)
        {
            vehicle_extras = 0;
        }

        private void AggressiveTraffic_Click(object sender, EventArgs e)
        {
            s_min_brake_distance = 1;
            s_max_brake_distance = 1;
            s_max_speed_at_brake_distance = 100;
            s_absolute_min_speed = 100;
            a_min_brake_distance = 1;
            a_max_brake_distance = 1;
            a_max_speed_at_brake_distance = 100;
            a_absolute_min_speed = 100;
            c_min_brake_distance = 1;
            c_max_brake_distance = 1;
            c_max_speed_at_brake_distance = 100;
            c_absolute_min_speed = 100;
            t_min_brake_distance = 1;
            t_max_brake_distance = 1;
            t_max_speed_at_brake_distance = 100;
            t_absolute_min_speed = 100;
        }

        private void RemoveTraffic_Click(object sender, EventArgs e)
        {
            s_max_brake_distance = 0;
            a_max_brake_distance = 0;
            c_max_brake_distance = 0;
            t_max_brake_distance = 0;
        }

        private void ResetTraffic_Click(object sender, EventArgs e)
        {
            //DEFAULT VALUES
            s_min_brake_distance = 10;
            s_max_brake_distance = 80;
            s_max_speed_at_brake_distance = 50;
            s_absolute_min_speed = 1;
            a_min_brake_distance = 10;
            a_max_brake_distance = 80;
            a_max_speed_at_brake_distance = 30;
            a_absolute_min_speed = 1;
            c_min_brake_distance = 10;
            c_max_brake_distance = 100;
            c_max_speed_at_brake_distance = 30;
            c_absolute_min_speed = 1;
            t_min_brake_distance = 10;
            t_max_brake_distance = 100;
            t_max_speed_at_brake_distance = 30;
            t_absolute_min_speed = 1;
        }

        private void RainbowCarBox_CheckedChanged(object sender, EventArgs e)
        {
            ToggleRainbowCarLoop();
            MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_xenon_, new byte[] { 1 });
        }

        private void GetPVMods_Click(object sender, EventArgs e)
        {
            tbLivery.Text = MemLib.ReadByte(CVehicleDrawHandler + "+" + vehicle_livery_).ToString("F0");
            tbvehicle_xenoncolor_.Text = MemLib.ReadByte(CVehicleDrawHandler + "+" + vehicle_xenoncolor_).ToString("F0");
            tbVehiclHorn.Text = MemLib.ReadByte(CVehicleDrawHandler + "+" + vehicle_horn_).ToString("F0");
        }

        private void SetPVMods_Click(object sender, EventArgs e)
        {

            MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_livery_, new byte[] { byte.Parse(tbLivery.Text) });
            MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_horn_, new byte[] { byte.Parse(tbVehiclHorn.Text) });
            MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_xenoncolor_, new byte[] { byte.Parse(tbvehicle_xenoncolor_.Text) });
        }

        private void ChangeLicensePlateButton_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            string licensePlate = Interaction.InputBox("Enter new license plate (?=SPACE// Its?Me = Its Me):", "License Plate", "", -1, -1);

            if (!string.IsNullOrEmpty(licensePlate))
            {
                byte[] plateBytes = ConvertLicensePlateToBytes(licensePlate);
                MemLib.WriteBytes(CVehicleVisual + "+" + license_plate_, plateBytes);
                this.TopMost = true;
            }
        }

        private byte[] ConvertLicensePlateToBytes(string licensePlate)
        {
            byte[] plateBytes = new byte[licensePlate.Length];

            for (int i = 0; i < licensePlate.Length; i++)
            {
                if (VehPlate.TryGetValue(char.ToUpper(licensePlate[i]), out byte hex))
                {
                    plateBytes[i] = hex;
                }
                else
                {
                    plateBytes[i] = 0x00;
                }
            }

            return plateBytes;
        }



        private int currentWordIndex = 0;
        private bool isLooping = false;
        private Thread licensePlateThread;

        private void LicensePlateLoop_CheckedChanged(object sender, EventArgs e)
        {
            if (LicensePlateLoop.Checked)
            {
                isLooping = true;
                currentWordIndex = 0;
                licensePlateThread = new Thread(WriteLicensePlates);
                licensePlateThread.Start();
            }
            else
            {
                isLooping = false;
                licensePlateThread?.Join();
            }
        }

        private void WriteLicensePlates()
        {
            while (isLooping)
            {
                string licensePlate = words[currentWordIndex];
                byte[] plateBytes = ConvertLicensePlateToBytes(licensePlate);
                MemLib.WriteBytes(CVehicleVisual + "+" + license_plate_, plateBytes);

                currentWordIndex = (currentWordIndex + 1) % words.Count;
                int delayInterval = 1000;
                Thread.Sleep(delayInterval);
            }
        }

        public List<string> words = new List<string>
{
    "??Never??", "?gonna?", "??give??", "??you???",
    "???up????", "??Never??", "??gonna?", "??let???",
    "???you???", "??down??", "??Never??", "?gonna?",
    "??run???", "?around", "??and???", "?desert?",
    "???you???", "??Never??", "??gonna?", "??make?",
    "???you???", "???cry???", "??Never??", "?gonna?",
    "???say??", "?goodbye", "??Never?", "?gonna?",
    "???tell??", "???a????","???lie??", "???and??",
    "??hurt??", "???you??"
};

        private void ChangePrimaryVehicleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    byte r = (byte)selectedColor.R;
                    byte g = (byte)selectedColor.G;
                    byte b = (byte)selectedColor.B;
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color1_r_, new byte[] { r });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color1_g_, new byte[] { g });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color1_b_, new byte[] { b });
                }
            }
        }

        private void ChangeSecondaryVehicleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    byte r = (byte)selectedColor.R;
                    byte g = (byte)selectedColor.G;
                    byte b = (byte)selectedColor.B;
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color2_r_, new byte[] { r });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color2_g_, new byte[] { g });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color2_b_, new byte[] { b });
                }
            }
        }

        private void ChangeTiresmokeVehicleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    byte r = (byte)selectedColor.R;
                    byte g = (byte)selectedColor.G;
                    byte b = (byte)selectedColor.B;
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_tiresmoke_r_, new byte[] { r });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_tiresmoke_g_, new byte[] { g });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_tiresmoke_b_, new byte[] { b });
                }
            }
        }

        private void ChangeNeonVehicleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    byte r = (byte)selectedColor.R;
                    byte g = (byte)selectedColor.G;
                    byte b = (byte)selectedColor.B;
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_neon_r_, new byte[] { r });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_neon_g_, new byte[] { g });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_neon_b_, new byte[] { b });
                }
            }
        }

        private void XenonON_Click(object sender, EventArgs e)
        {
            vehicle_xenon = 1;
        }

        private void XenonOFF_Click(object sender, EventArgs e)
        {
            vehicle_xenon = 0;
        }

        private void ChangeWheelVehicleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    byte r = (byte)selectedColor.R;
                    byte g = (byte)selectedColor.G;
                    byte b = (byte)selectedColor.B;
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_wheel_r_, new byte[] { r });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_wheel_g_, new byte[] { g });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_wheel_b_, new byte[] { b });
                }
            }
        }

        private void ChangeSpecialVehicleColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    Color selectedColor = colorDialog.Color;
                    byte r = (byte)selectedColor.R;
                    byte g = (byte)selectedColor.G;
                    byte b = (byte)selectedColor.B;
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_special_r_, new byte[] { r });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_special_g_, new byte[] { g });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_special_b_, new byte[] { b });
                }
            }
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            {
                string message = "How it works?\n\n" +
                                 "Make sure your'e in an Apartment Garage ( not car mod shop, bunker etc. ).\n" +
                                 "make all your edits.\n" +
                                 "to make it stick, leave garage with vehicle and find a new session.\n";

                MessageBox.Show(message, "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


}











