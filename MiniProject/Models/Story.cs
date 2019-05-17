using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject.Models
{
    public class Story
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StoryId { get; set; }
        public string StoryName { get; set; }
        [Required]
        public int ReleaseId { get; set; }
        [Required]
        public long StepId { get; set; }
        [ForeignKey("StepId")]
        public virtual Step Step { get; set; }
    }
}
