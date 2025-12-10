using ZenBlog.Domain.Entities.Common;

namespace ZenBlog.Domain.Entities;//.net 9 ile {} yerine ; kullanabiliriz.

public class Category: BaseEntity
    {
    public string CategoryName { get; set; }
    public virtual IList<Blog> Blogs { get; set; } //bire çok ilişki amacıyla
}

