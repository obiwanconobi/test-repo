using System.ComponentModel.DataAnnotations;

namespace shearwell_test.Models
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
