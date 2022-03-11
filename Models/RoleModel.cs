using Dapper.Contrib.Extensions;

namespace EditorDeTags.Models
{
    [Table("[Role]")]
    public class RoleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}