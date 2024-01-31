using System.ComponentModel.DataAnnotations;

namespace UserTestAPI.Models
{
	public class JournalException
	{
        [Key]
        public long Id { get; set; }

        [Required]
        public long EventId { get; set; }

        [Required]
        public string Text { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

