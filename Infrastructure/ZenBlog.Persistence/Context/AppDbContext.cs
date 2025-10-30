using Microsoft.EntityFrameworkCore;

namespace ZenBlog.Persistence.Context;

    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
}

