using System;
using System.Threading.Tasks;

using static WealthBooster.Bools;
using static WealthBooster.Weapon;
using static WealthBooster.SigScan;
using static WealthBooster.Vehicle;
using static WealthBooster.GetAddress;
using static WealthBooster.Globals;
using static WealthBooster.Player;

namespace WealthBooster
{
    internal static class Tasks
    {



        public static async Task AttemptOpenProcess()
        {
            if (!IsProcessOpen && !IsConnectionAttempting)
            {
                IsConnectionAttempting = true;
                if (MemLib.OpenProcess("GTA5"))
                {
                    IsProcessOpen = true;
                    await ConnectWorld();
                    GTA_PROCESS = MemLib.mProc.Process;
                }
                IsConnectionAttempting = false;
            }
        }


        public static async Task AmmoLoop()
        {
            if (IsAmmoLooperEnabled && !AmmoLoopIsLooping)
            {
                AmmoLoopIsLooping = true;
                ImpactExplosion = -1;
                ImpactType = 5;
                Recoil_shake = 0;
                m_explosion_shake_amplitude = 0;
                Random random = new Random();

                while (IsAmmoLooperEnabled)
                {
                    ImpactExplosion = random.Next(1, 100);
                    await Task.Delay(25);
                }
                Recoil_shake = 1;
                m_explosion_shake_amplitude = 1;
                ImpactExplosion = -1;
                ImpactType = 3;
                AmmoLoopIsLooping = false;
            }
        }




        public static async Task AutoRP_Loop()
        {
            if (IsLooperEnabled && !AutoRP_Loop_IsLooping)
            {
                AutoRP_Loop_IsLooping = true;
                GlobalRPValue = 250f;
                wanted_level = 1;
                await Task.Delay(1000);
                wanted_level = 0;
                await Task.Delay(1000);
                //Reset RP State!
                GlobalRPValue = 1;
                AutoRP_Loop_IsLooping = false;
            }
            else
            {
            }
        }


        public static async Task RainbowCar_Loop()
        {
            if (IsRainbowLooperEnabled && !Rainbow_Loop_IsLooping)
            {
                Rainbow_Loop_IsLooping = true;
                double hue = 0;
                double hueIncrement = 1;
                int delay = 25;
                Random random = new Random();
                while (IsRainbowLooperEnabled)
                {



                    byte[] color2 = { (byte)random.Next(0, 12) };
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_xenoncolor_, color2);


                    byte[] color = HSVtoRGB(hue, 1, 1);

                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color1_r_, new byte[] { color[0] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color2_r_, new byte[] { color[0] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color1_g_, new byte[] { color[1] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color2_g_, new byte[] { color[1] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color1_b_, new byte[] { color[2] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_color2_b_, new byte[] { color[2] });


                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_neon_r_, new byte[] { color[0] });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_neon_g_, new byte[] { color[1] });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_neon_b_, new byte[] { color[2] });

                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_tiresmoke_r_, new byte[] { color[0] });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_tiresmoke_g_, new byte[] { color[1] });
                    MemLib.WriteBytes(CVehicleDrawHandler + "+" + vehicle_tiresmoke_b_, new byte[] { color[2] });


                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_wheel_r_, new byte[] { color[0] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_wheel_g_, new byte[] { color[1] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_wheel_b_, new byte[] { color[2] });

                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_special_r_, new byte[] { color[0] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_special_g_, new byte[] { color[1] });
                    MemLib.WriteBytes(CVehicleVisual + "+" + vehicle_special_b_, new byte[] { color[2] });


                    await Task.Delay(delay);

                    hue += hueIncrement;
                    if (hue >= 360)
                        hue -= 360;
                }

                Rainbow_Loop_IsLooping = false;
            }
        }



        private static byte[] HSVtoRGB(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);
            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return new byte[] { (byte)v, (byte)t, (byte)p };
            else if (hi == 1)
                return new byte[] { (byte)q, (byte)v, (byte)p };
            else if (hi == 2)
                return new byte[] { (byte)p, (byte)v, (byte)t };
            else if (hi == 3)
                return new byte[] { (byte)p, (byte)q, (byte)v };
            else if (hi == 4)
                return new byte[] { (byte)t, (byte)p, (byte)v };
            else
                return new byte[] { (byte)v, (byte)p, (byte)q };
        }
















    }
}
