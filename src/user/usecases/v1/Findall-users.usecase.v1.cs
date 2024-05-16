using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.usecases.v1;

namespace API_EM_C_.src.user.usecases.v1
{
    public class FindallUsersUsecase: IFindAllUsers
    {
        public List<UserEntity> Execute()
        {
            var users = new List<UserEntity>
            {
                new UserEntity { Name = "Usuário 1", Email = "usuario1@example.com" },
                new UserEntity { Name = "Usuário 2", Email = "usuario2@example.com" },
                new UserEntity { Name = "Usuário 3", Email = "usuario3@example.com" }
            };

            return users;
            //throw new NotImplementedException();
        }
    }
}
