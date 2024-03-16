namespace Vehycles.Services.Interfaces
{
	public interface ICategoryService
	{
		Task<bool> CategoryExistByIdAsync(int Id);
	}
}
