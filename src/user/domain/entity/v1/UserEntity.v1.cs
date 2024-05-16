using System;

namespace API_EM_C_.src.user.domain.entity.v1
{
    public class UserEntity
    {
        public int id { get; } = Random.Shared.Next(10, 21);
       public string Name { get; set; }
       public string Email { get; set; }
    }
}
