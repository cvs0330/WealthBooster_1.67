using static WealthBooster.SigScan;

namespace WealthBooster
{
    internal static class Globals
    {

        
        public static string Global_RP_ => (MemLib.ReadLong(GlobalBaseAddress + "+8") + 0x10).ToString("X2");
        public static string Global_ => (MemLib.ReadLong(GlobalBaseAddress + "+8") + 0x0).ToString("X2");
        public static string Global_CMFailMoney_ => (MemLib.ReadLong(GlobalBaseAddress + "+8") + 0x10B50).ToString("X2"); // (262145+8553)


        public static string Global_toggle_snow_ => (MemLib.ReadLong(GlobalBaseAddress + "+8") + 0x9488).ToString("X2");



        public static string Global_Strip_Club_Shot_Price_ => (MemLib.ReadLong(GlobalBaseAddress + "+8") + 0xDED8).ToString("X2"); // (262145+7130)





        public static int Global_Strip_Club_Shot_Price
        {
            get => MemLib.ReadInt(Global_Strip_Club_Shot_Price_);
            set => MemLib.WriteMemory(Global_Strip_Club_Shot_Price_, "int", value.ToString());
        }
       
        public static int Global_toggle_snow
        {
            get => MemLib.ReadInt(Global_toggle_snow_);
            set => MemLib.WriteMemory(Global_toggle_snow_, "int", value.ToString());
        }
       
        public static int Global_CMFailMoney
        {
            get => MemLib.ReadInt(Global_CMFailMoney_);
            set => MemLib.WriteMemory(Global_CMFailMoney_, "int", value.ToString());
        }
     
        public static float GlobalRPValue
        {
            get => MemLib.ReadFloat(Global_RP_);
            set => MemLib.WriteMemory(Global_RP_, "float", value.ToString());
        }
    }
}
