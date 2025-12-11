using Microsoft.AspNetCore.Identity;

namespace ZenBlog.Domain.Entities
{
    public class AppUser:IdentityUser<string>//yazmasan da oto. string
    {
        public AppUser()
        {
            Id = Guid.NewGuid().ToString(); // Id artık hiçbir zaman null değil
                                            // IdentityUser<string> PK olarak string kullanır.
                                            // Kullanıcı eklenirken null PK kabul edilmediği için constructor'da
                                            // otomatik Guid string üreterek primary key'i garanti altına alıyoruz.

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }
        public virtual IList<Blog> Blogs { get; set; }
        public virtual IList<Comment> Comments { get; set; }
        public virtual IList<SubComment> SubComments { get; set; }


    }
}
