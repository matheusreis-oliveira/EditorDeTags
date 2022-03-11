using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace EditorDeTags.Models
{
    [Table("[User]")]
    public class UserModel
    {
        public UserModel() => Roles = new List<RoleModel>();

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

        [Write(false)]
        public List<RoleModel> Roles { get; set; }
    }
}