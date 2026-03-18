using Domain;
using System.ComponentModel.DataAnnotations;

namespace DemoApi
{
    public class Department: Entity<Guid>
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
    }
}
