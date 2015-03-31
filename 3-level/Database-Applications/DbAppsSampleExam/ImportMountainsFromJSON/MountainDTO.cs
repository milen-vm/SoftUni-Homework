using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportMountainsFromJSON
{
    public class MountainDTO
    {
        public MountainDTO()
        {
            this.Peaks = new HashSet<PeakDTO>();
            this.Countries = new HashSet<string>();
        }
        public string MountainName { get; set; }

        public ICollection<PeakDTO> Peaks { get; set; }

        public ICollection<string> Countries { get; set; }
    }
}
