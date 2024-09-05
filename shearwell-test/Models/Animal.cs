using System.ComponentModel.DataAnnotations;

namespace shearwell_test.Models
{
    public class Animal
    {
        public Guid Id { get; set; }
        public string Tag { get; set; }
        public DateTime DateOfBirth { get; set; }
  
    }
}
