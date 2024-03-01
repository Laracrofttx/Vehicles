namespace Vehycle.Data.Models
{
	public class Chat
	{
        public Chat()
        {
            this.Messages = new HashSet<Message>();
            this.Users = new HashSet<ApplicationUser>();
        }

        public ICollection<Message> Messages { get; set; } = null!;

		public ICollection<ApplicationUser> Users { get; set; } = null!;

	}
}
