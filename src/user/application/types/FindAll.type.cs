using API_EM_C_.src.shared.application.port;
using API_EM_C_.src.user.domain.entity.v1;

namespace API_EM_C_.src.user.application.types
{
    public interface FindAllOutPutType : IResponseQuery<IEnumerable<UserEntity>>
    {
    }
}
