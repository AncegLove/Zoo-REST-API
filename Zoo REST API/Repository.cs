using Zoo_REST_API.Animals;

namespace Zoo_REST_API
{
    public class Repository : IRepository
    {
        private readonly List<Animal> _animals;
        public async Task<List<Animal>> GetAllAsync() => await Task.FromResult(_animals);
    }
}
