using Microsoft.EntityFrameworkCore;
using UserDetails.Models;

namespace UserDetails.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public virtual DbSet<User> user{ get; set; }

}

}

