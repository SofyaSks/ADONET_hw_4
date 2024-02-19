using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET_hw_4
{
    public partial class song
    {
        public override string ToString()
        {
            return $" {Id, -3} {title, -20} {rating,-20} {weight,-20} {duration,-20} {date.ToShortDateString(),-20}";
        }
    }
}
