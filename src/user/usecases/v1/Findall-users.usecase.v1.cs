using API_EM_C_.src.user.domain.port.repository;
using API_EM_C_.src.user.domain.port.usecases.v1;
using API_EM_C_.src.user.infra.repository;

namespace API_EM_C_.src.user.usecases.v1
{
    public class FindallUsersUsecase: IFindAllUsers
    {
        private readonly IRepositoryUser _userRepository;

        public FindallUsersUsecase(IRepositoryUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<object> Execute(object input = null)
        {
            throw new NotImplementedException();

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
