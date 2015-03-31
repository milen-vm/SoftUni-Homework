namespace MountainsCodeFirst
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Mountain
    {
        public Mountain()
        {
            this.Peaks = new HashSet<Peak>();
            this.Countries = new HashSet<Country>();
        }
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Peak> Peaks { get; set; }

        public virtual ICollection<Country> Countries { get; set; } 
    }
}
