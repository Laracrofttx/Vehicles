using System.ComponentModel.DataAnnotations;

namespace Vehycle.Data.Models
{
	public class Message
	{
        public Message()
        {
			this.Id = Guid.NewGuid();	
        }

        [Key]
		public Guid Id { get; set; }
		public string UserName { get; set; } = null!;

		public string Content { get; set; } = null!;

		public DateTime Time { get; set; }

		public string ChatId { get; set; } = null!;

		public Chat Chat { get; set; } = null!;

	}
}
