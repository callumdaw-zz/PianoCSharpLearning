using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisUniWork.Classes
{
    public class MusicNote
    {
        public int pitch { get; set; }
        public int noteType { get; set; }
        public int noteDuration { get; set; }
        public bool accidental { get; set; }
    }
}
