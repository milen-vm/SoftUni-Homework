namespace CodeFirstMountainsDatabase
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MountainsContext : DbContext
    {
        public MountainsContext()
            : base("name=Mountains")
        {
        }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Mountain> Mountains { get; set; }

        public virtual DbSet<Peak> Peaks { get; set; }
    }
}