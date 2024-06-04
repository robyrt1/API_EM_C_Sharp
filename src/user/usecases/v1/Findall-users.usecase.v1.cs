using API_EM_C_.src.shared.application.exceptions;
using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.repository;
using API_EM_C_.src.user.domain.port.usecases.v1;


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

        public async Task<IEnumerable<UserEntity>> Execute()
        {
            try
            {
                var users =  await _userRepository.GetUsers();
                if (users is null || !users.Any())
                {
                    Console.WriteLine(users.ToString());
                    throw new GenerateErrorExceptionByCode(ExceptionCodes.USER_NO_LONGER_FOUND,"Do not exists users");
                }

                return users;
            }
            catch (GenerateErrorExceptionByCode ex)
            {
                throw ;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
