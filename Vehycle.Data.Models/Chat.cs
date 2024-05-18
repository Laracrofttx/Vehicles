namespace Vehycle.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	public class Chat
	{
		public Chat()
		{

			this.Messages = new HashSet<Message>();
			this.Users = new HashSet<ApplicationUser>();
		}

		[Key]
		public int Id { get; set; }

		public ICollection<Message> Messages { get; set; } = null!;

		public ICollection<ApplicationUser> Users { get; set; } = null!;

	}
}
