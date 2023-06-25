using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static WealthBooster.Weapon;
using static WealthBooster.GetAddress;
using static WealthBooster.SigScan;
using System.IO;
using WealthBooster;

namespace WealthBooster
{
    public partial class WeaponMenu : Form
    {
        public WeaponMenu()
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

        private void InfAmmoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            InfAmmo = InfAmmoCheckBox.Checked ? 3 : 0;
        }

        private void ExplosiveAmmoLoopBox_CheckedChanged(object sender, EventArgs e)
        {
            AmmoLooperEnabled();
        }

        private void ImpactFists_Click(object sender, EventArgs e)
        {
            ImpactType = 2;
        }

        private void BulletDefault_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = -1;
        }

        private void ImpactBullet_Click(object sender, EventArgs e)
        {
            ImpactType = 3;
        }

        private void ImpactExplosion_Click(object sender, EventArgs e)
        {
            ImpactType = 5;
        }

        private void BulletGrenade_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 5;
        }

        private void BulletMolotov_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 3;
        }

        private void BulletEmp_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 83;
        }

        private void BulletWater_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 13;
        }

        private void BulletFlame_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 12;
        }

        private void BulletGas_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 21;
        }

        private void BulletRailgun_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 36;
        }

        private void BulletRaygun_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 70;
        }

        private void BulletOrbital_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 59;
        }

        private void BulletBlimp_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 29;
        }

        private void BulletFlare_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 22;
        }

        private void BulletSmoke_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 20;
        }

        private void BulletSnowball_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 39;
        }

        private void BulletExtinguisher_Click(object sender, EventArgs e)
        {
            Weapon.ImpactExplosion = 24;
        }

        private void SetBulletType_Click(object sender, EventArgs e)
        {
          
            if (int.TryParse(ImpactTypeTextBox.Text, out int ImpactID))
            {
                Weapon.ImpactExplosion = ImpactID;
            }


        }



        private void GetWeaponData_Click(object sender, EventArgs e)
        {
            PenetrationBox.Text = Penetration.ToString("F2");
            SpreadBox.Text = WeaponSpread.ToString("F2");
            BulletSpeedBox.Text = BulletSpeed.ToString("F2");
            PedForceBox.Text = WeaponPedForce.ToString("F2");
            VehForceBox.Text = WeaponVehForce.ToString("F2");
            HeliForceBox.Text = WeaponHeliForce.ToString("F2");
            BatchSpreadBox.Text = BatchSpread.ToString("F2");
            DamageBox.Text = m_damage.ToString("F2");
            TBSBox.Text = timebetweenshots.ToString("F2");
            m_explosion_shake_amplitude_1.Text = m_explosion_shake_amplitude.ToString("F2");
            RecoilShakeBox.Text = Recoil_shake.ToString("F2");
            BulletBatchBox.Text = BulletsinBatch.ToString();
            tbBulletType.Text = ImpactType.ToString();
            tbBulletImpact.Text = Weapon.ImpactExplosion.ToString();
        }

        private void SetWeaponData_Click(object sender, EventArgs e)
        {
            string[] values = { PenetrationBox.Text, m_explosion_shake_amplitude_1.Text, SpreadBox.Text, BulletSpeedBox.Text, PedForceBox.Text, VehForceBox.Text,
                        HeliForceBox.Text, BatchSpreadBox.Text, DamageBox.Text, TBSBox.Text, RecoilShakeBox.Text,};
            string[] offsets = { PenetrationOffset, m_explosion_shake_amplitude_, WeaponSpreadOffset, BulletSpeedOffset, PedForceOffset, VehForceOffset,
                        HeliForceOffset,BatchSpreadOffset, m_damageOffset, timebetweenshotOffset, Recoil_shake_,};
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != "")
                    MemLib.WriteMemory(CWeaponInfo + "+" + offsets[i], "float", values[i]);

            }

            MemLib.WriteMemory(CWeaponInfo + "+" + ImpactOffset, "int", tbBulletType.Text);
            MemLib.WriteMemory(CWeaponInfo + "+" + ImpactExplosionOffset, "int", tbBulletImpact.Text);
            MemLib.WriteMemory(CWeaponInfo + "+" + BulletsinBatchOffset, "int", BulletBatchBox.Text);
        }

        private void SaveHandling_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Weapon Data");
            Directory.CreateDirectory(folderPath);

            string configName = tbConfigName.Text;
            string fileName = GenerateUniqueFileName(folderPath, configName);

            string filePath = Path.Combine(folderPath, fileName);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("---------------");
                writer.WriteLine("Weapon Handling Configuration File (this file can be shared with other Wealth Booster Users)");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("Config Name: " + configName);
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("WEAPON HANDLING DATA");
                writer.WriteLine("------------------------------------------------------");
                writer.WriteLine("Penetration: " + PenetrationBox.Text);
                writer.WriteLine("Weapon Spread: " + SpreadBox.Text);
                writer.WriteLine("Bullet Speed: " + BulletSpeedBox.Text);
                writer.WriteLine("Ped Force: " + PedForceBox.Text);
                writer.WriteLine("Vehicle Force: " + VehForceBox.Text);
                writer.WriteLine("Helicopter Force: " + HeliForceBox.Text);
                writer.WriteLine("Bullet Batch Spread: " + BatchSpreadBox.Text);
                writer.WriteLine("Damage: " + DamageBox.Text);
                writer.WriteLine("Time between Shots: " + TBSBox.Text);
                writer.WriteLine("Explosion Shake: " + m_explosion_shake_amplitude_1.Text);
                writer.WriteLine("Recoil Shake: " + RecoilShakeBox.Text);
                writer.WriteLine("Bullets in Batch: " + BulletBatchBox.Text);
                writer.WriteLine("Bullet Type: " + tbBulletType.Text);
                writer.WriteLine("Bullet Explosion: " + tbBulletImpact.Text);
            }

            MessageBox.Show($"Handling File saved to {filePath}");
        }

        private string GenerateUniqueFileName(string folderPath, string configName)
        {
            string fileName = $"{configName}.txt";
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
                InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WealthBooster", "Weapon Data"),
                Filter = "Data files (*.txt)|*.txt",
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
            { "Penetration", PenetrationBox },
            { "Weapon Spread", SpreadBox },
            { "Bullet Speed", BulletSpeedBox },
            { "Ped Force", PedForceBox },
            { "Vehicle Force", VehForceBox },
            { "Helicopter Force", HeliForceBox },
            { "Bullet Batch Spread", BatchSpreadBox },
            { "Damage", DamageBox },
            { "Time between Shots", TBSBox },
            { "Explosion Shake:", m_explosion_shake_amplitude_1 },
            { "Recoil Shake", RecoilShakeBox },
            { "Bullets in Batch", BulletBatchBox },
            { "Bullet Type", tbBulletType },
            { "Bullet Explosion", tbBulletImpact },

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
    }
}
