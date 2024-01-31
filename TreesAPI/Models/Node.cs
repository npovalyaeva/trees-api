using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserTestAPI.Models
{
	public class Node
	{
        [Key]
        public required long Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [ForeignKey("Parent")]
        public long? ParentId { get; set; }


        public virtual Node? Parent { get; set; }

        public virtual IEnumerable<Node>? Children { get; set; }
    }
}

