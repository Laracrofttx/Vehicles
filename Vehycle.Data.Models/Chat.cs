using System.ComponentModel.DataAnnotations;

namespace Vehycle.Data.Models
{
	public class Chat
	{
        public Chat()
        {

            this.Messages = new HashSet<Message>();
            this.Users = new HashSet<ApplicationUser>();
        }
        [Key]
        public int Id { get; set; }

        public virtual ICollection<Message> Messages { get; set; } = null!;

		public virtual ICollection<ApplicationUser> Users { get; set; } = null!;

	}
}
