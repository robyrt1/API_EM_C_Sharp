using API_EM_C_.src.shared.application.port;
using API_EM_C_.src.user.application.types;
using API_EM_C_.src.user.domain.entity.v1;

namespace API_EM_C_.src.user.domain.port.usecases.v1
{
    public interface ICreateUserPort 
    {
        Task<UserEntity> Execute(ICreateUserInput input);
    }
}
