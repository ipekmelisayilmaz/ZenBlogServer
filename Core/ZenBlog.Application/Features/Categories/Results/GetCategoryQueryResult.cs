using ZenBlog.Application.Base;
using ZenBlog.Domain.Entities;

namespace ZenBlog.Application.Features.Categories.Results
{
    public class GetCategoryQueryResult:BaseDto
    {
        public string CategoryName { get; set; }
        //public IList<GetBlogQueryResult> Blogs { get; set; } 
    }
}
