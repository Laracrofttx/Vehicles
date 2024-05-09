namespace Vehycle.Data.Models
{
	public class VehycleAd
	{
		public VehycleAd()
		{
			this.VehycleId = Guid.NewGuid();
			this.AdId = Guid.NewGuid();
		}

		public Guid VehycleId { get; set; }

		public virtual Vehycle Vehycles { get; set; } = null!;

		public Guid AdId { get; set; }

		public virtual Ad Ads { get; set; } = null!;



	}
}
