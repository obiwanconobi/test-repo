using shearwell_test.DataAccess;
using shearwell_test.Models;

namespace shearwell_test.Services
{
    public class AnimalGroupRelService
    {
        private UnitOfWork _context;
        public AnimalGroupRelService(UnitOfWork context)
        {
            _context = context;
        }

        public List<Guid> animalsInGroup(Guid groupId)
        {
           return _context.AnimalGroupRel.Where(x => x.GroupId == groupId).Select(x => x.AnimalId).ToList();
        }

        public void RemoveFromGroup(Guid animalId, Guid groupId)
        {
            _context.AnimalGroupRel.Remove(new AnimalGroupRel { AnimalId = animalId, GroupId = groupId });
        }

        public async Task AddToGroup(Animal animal, Guid groupId)
        {
            _context.AnimalGroupRel.Add(new AnimalGroupRel { AnimalId = animal.Id, GroupId = groupId });
            await _context.SaveChangesAsync();
        }
    }
}
