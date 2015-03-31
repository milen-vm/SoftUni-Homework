namespace StudentSystem.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Resource
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public ResourceType Type { get; set; }

        public string Link { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
