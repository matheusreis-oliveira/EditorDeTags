using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace EditorDeTags.Models
{
    [Table("[Category]")]
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<PostCategory> Posts { get; set; }
    }
}