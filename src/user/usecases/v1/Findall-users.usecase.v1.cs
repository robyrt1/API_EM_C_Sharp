using API_EM_C_.src.shared.application.constants;
using API_EM_C_.src.shared.application.exceptions;
using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.usecases.v1;
using API_EM_C_.src.user.infra.repository;

namespace API_EM_C_.src.user.usecases.v1
{
    public class FindallUsersUsecase: IFindAllUsers
    {
        private readonly UserRepository _userRepository;

        public FindallUsersUsecase(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<object> Execute()
        {
            try
            {
                var users = await _userRepository.GetUsers();
                if (users == null || !users.Any())
                {
                    return new object();
                }

                return users;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
