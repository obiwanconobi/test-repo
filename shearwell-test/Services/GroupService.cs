using shearwell_test.DataAccess;
using shearwell_test.Models;

namespace shearwell_test.Services
{
    public class GroupService
    {
        private UnitOfWork _context;
        public GroupService(UnitOfWork context) 
        {
            _context = context;
        }

        public List<Group> listGroups()
        {
            return _context.Groups.ToList();
        }

        public async void addGroup(String groupName)
        {
            await _context.Groups.AddAsync(new Group { Name = groupName, DateCreated = DateTime.Now});
            await _context.SaveChangesAsync();
        }
    }
}
