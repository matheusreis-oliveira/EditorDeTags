using Dapper.Contrib.Extensions;

namespace EditorDeTags.Models
{
    [Table("[Tag]")]
    public class TagModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}