using shearwell_test.DataAccess;
using shearwell_test.Models;

namespace shearwell_test.Services
{
    public class AnimalService
    {
        private UnitOfWork _context;
        private AnimalGroupRelService _animalGroupRelService;
        public AnimalService(UnitOfWork context, AnimalGroupRelService animalGroupRelService) 
        {
            _context = context;
            _animalGroupRelService = animalGroupRelService;
        }

        public List<Animal> listAnimals()
        {
            return _context.Animals.ToList();
        }

        public List<Animal> listAnimalsFromGroup(Guid Id)
        {
            var animals = _animalGroupRelService.animalsInGroup(Id);
            return _context.Animals.Where(x => animals.Contains(x.Id)).ToList();
        }

        public async Task AddAnimal(Animal animal, Guid Id)
        {
            using var transaction = await _context.Database.BeginTransactionAsync();
            try
            {                
                _context.Animals.Add(animal);
                await _context.SaveChangesAsync();

                await _animalGroupRelService.AddToGroup(animal, Id);
                await transaction.CommitAsync();
               
            }
            catch
            {
                await transaction.RollbackAsync();
                throw; 
            }
        }

    }
}
