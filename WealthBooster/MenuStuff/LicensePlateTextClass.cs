using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WealthBooster
{
    public static class LicensePlateTextClass
    {

        public static SortedDictionary<char, byte> VehPlate = new SortedDictionary<char, byte>
{
    {'0', 0x00}, {'1', 0x01}, {'2', 0x02}, {'3', 0x03}, {'4', 0x04},
    {'5', 0x05}, {'6', 0x06}, {'7', 0x07}, {'8', 0x08}, {'9', 0x09},
    {'A', 0x0A}, {'B', 0x0B}, {'C', 0x0C}, {'D', 0x0D}, {'E', 0x0E},
    {'F', 0x0F}, {'G', 0x10}, {'H', 0x11}, {'I', 0x12}, {'J', 0x13},
    {'K', 0x14}, {'L', 0x15}, {'M', 0x16}, {'N', 0x17}, {'O', 0x18},
    {'P', 0x19}, {'Q', 0x1A}, {'R', 0x1B}, {'S', 0x1C}, {'T', 0x1D},
    {'U', 0x1E}, {'V', 0x1F}, {'W', 0x20}, {'X', 0x21}, {'Y', 0x22},
    {'Z', 0x23}, {'?', 0x63}
};



 

    }
}
