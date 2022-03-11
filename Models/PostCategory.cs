using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace EditorDeTags.Models
{
    [Table("[Post]")]
    public class PostCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }

        public int AuthorId { get; set; }
        [Write(false)]
        public UserModel Author { get; set; }

        public int CategoryId { get; set; }
        [Write(false)]
        public CategoryModel Category { get; set; }

        [Write(false)]
        public List<TagModel> Tags { get; set; }
    }
}