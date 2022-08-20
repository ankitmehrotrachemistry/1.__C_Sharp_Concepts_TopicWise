using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Two_Class_Linking
{
    public class JackPotWinRequest
    {
        public int position { get; set; }
        public JackPotWin[] jackPotWin { get; set; }
    }
    public class JackPotWin
    {
        public string JackPotId { get; set; }
        public ulong WinnerId { get; set; }
        public int TierPosition { get; set; }
        public ulong Value { get; set; }
    }
}
