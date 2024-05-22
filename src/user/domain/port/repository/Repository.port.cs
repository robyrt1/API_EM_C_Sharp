using API_EM_C_.src.user.domain.entity.v1;

namespace API_EM_C_.src.user.domain.port.repository
{
    public interface IRepositoryUser
    {
        Task<IEnumerable<UserEntity>> GetUsers();
    }
}


