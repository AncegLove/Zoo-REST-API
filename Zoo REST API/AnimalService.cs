
using Zoo_REST_API.Animals;

namespace Zoo_REST_API
{
    public class AnimalService : IAnimalService
    {
        private readonly IRepository _repository;
        public AnimalService(IRepository repository) { _repository = repository; }
        public async Task<int> AddAnimalAsync(Animal animal)
        {
            animal.Id = await GetNewIdAsync();
            animal.Energy = 100;
            var animals = await _repository.GetAllAsync();
            animals.Add(animal);
            return animal.Id;
        }
        private async Task<int> GetNewIdAsync()
        {
            var animals = await _repository.GetAllAsync();
            if (animals.Count != 0)
                return animals.Count + 1;
            else
                return 1;
        }

        public async Task<bool> DeleteAnimalByIdAsync(int id)
        {
            var animals = await _repository.GetAllAsync();
            var animal = animals.FirstOrDefault(x => x.Id == id);
            if (animal != null)
            {
                animals.Remove(animal);
                return true;
            } else return false;
        }

        public async Task<bool> FeedAnimalAsync(int id, int foud)
        {
            var animals = await _repository.GetAllAsync();
            var animal = animals.FirstOrDefault(x => x.Id==id);
            if (animal != null)
            {
                animal.Energy += foud;
                return true;
            }
            else return false;
        }

        public async Task<Animal>? GetAnimalByIdAsync(int id)
        {
            var animals = await _repository.GetAllAsync();
            var animal = animals.FirstOrDefault(x => x.Id==id);
            return animal;
        }

        public async Task<IEnumerable<Animal>> GetAnimalsAsync()
        {
            var animals = await _repository.GetAllAsync();
            return animals;
        }
    }
}
