using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleProject.Entity.Entities
{
    public class AppUser:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("A14B14F8-A193-4940-A67F-ABFEF7E542A0");
        public Image Image { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
