using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFPTJobMatch.Models
{
	public class Profile
	{
		[Key]
		public int Id { get; set; }
		public string UserId { get; set; }
		public string FullName { get; set; }
		public string Address { get; set; }
		public string Skill { get; set; }
		public string Education { get; set; }
		public string MyFile { get; set; }
		[NotMapped]
		public IFormFile ImageFile { get; set; }
		[InverseProperty("ObjProfile")]
		public virtual ICollection<ProJob>? ProJobs { get; set; }
	}
}
