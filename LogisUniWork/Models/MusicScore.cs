using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogisUniWork.Classes;

namespace LogisUniWork.Models
{
    public class MusicScore
    {
        public string name { get; set; }
        public int tempo { get; set; }
        public List<MusicNote> notes { get; set; }
        public MusicScore()
        {
            this.notes = new List<MusicNote>();
        }
    }
}
