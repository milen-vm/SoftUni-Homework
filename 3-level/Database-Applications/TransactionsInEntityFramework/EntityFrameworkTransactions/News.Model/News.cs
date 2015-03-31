namespace News.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class News
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR")]
        [MinLength(5)]
        [ConcurrencyCheck]
        public string Content { get; set; }
    }
}
