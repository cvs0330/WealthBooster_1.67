using static WealthBooster.SigScan;
using static WealthBooster.GetAddress;


namespace WealthBooster
{
    internal static class Roulette
    {
        public static string roulette_left_table_ = "4D0";
        public static string roulette_right_table_ = "4D8";

        public static string roulette_vip1_table_ = "4E0";
        public static string roulette_vip2_table_ = "4E8";
        public static string roulette_vip3_table_ = "4F0";
        public static string roulette_vip4_table_ = "4F8";
        public static string roulette_table_bet_ = "970";

        public static int roulette_vip3_table
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_vip3_table_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_vip3_table_, "int", value.ToString());
        }
        public static int roulette_vip4_table
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_vip4_table_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_vip4_table_, "int", value.ToString());
        }
        public static int roulette_vip1_table
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_vip1_table_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_vip1_table_, "int", value.ToString());
        }
        public static int roulette_vip2_table
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_vip2_table_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_vip2_table_, "int", value.ToString());
        }



        public static int roulette_left_table
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_left_table_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_left_table_, "int", value.ToString());
        }
        public static int roulette_right_table
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_right_table_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_right_table_, "int", value.ToString());
        }
        public static int roulette_table_bet
        {
            get => MemLib.ReadInt(Roulette3 + "+" + roulette_table_bet_);
            set => MemLib.WriteMemory(Roulette3 + "+" + roulette_table_bet_, "int", value.ToString());
        }
    }
}
