using API_EM_C_.src.user.domain.entity.v1;

namespace API_EM_C_.src.user.domain.port.usecases.v1
{
  public interface IFindAllUsers
    {
        public List<UserEntity> Execute();
    }
}
