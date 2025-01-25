using Zoo_REST_API.Animals;

namespace Zoo_REST_API
{
    public interface IRepository
    {
        public Task<List<Animal>> GetAllAsync();
    }
}
