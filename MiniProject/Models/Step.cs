using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProject.Models
{
    public class Step
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StepId { get; set; }
        public string StepName { get; set; }
        [Required]
        public long GoalId { get; set; }
        [ForeignKey("GoalId")]
        public virtual Goal Goal { get; set; }
        public virtual List<Story> Stories { get; set; }
    }
}
