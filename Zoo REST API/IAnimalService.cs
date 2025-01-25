using Zoo_REST_API.Animals;

namespace Zoo_REST_API
{
    public interface IAnimalService
    {
        public Task<IEnumerable<Animal>> GetAnimalsAsync();
        public Task<Animal> GetAnimalByIdAsync(int id);
        public Task<int> AddAnimalAsync(Animal animal);
        public Task<bool> FeedAnimalAsync(int id, int food);
        public Task<bool> DeleteAnimalByIdAsync(int id); 
    }
}
