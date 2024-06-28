using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFPTJobMatch.Models
{
	public class Job
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Qualification { get; set; }
		public string Location { get; set; }
		public string Industry { get; set; }
		public DateTime Deadline { get; set; }
		public int CategoryId { get; set; } 
		[ForeignKey("CategoryId")]
		public virtual Category? ObjCategory { get; set; }
		[InverseProperty("ObjJob")]
		public virtual ICollection<ProJob>? ProJobs { get; set; }
	}
}
