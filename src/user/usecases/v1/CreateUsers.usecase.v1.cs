using API_EM_C_.src.user.application.types;
using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.repository;
using API_EM_C_.src.user.domain.port.usecases.v1;

namespace API_EM_C_.src.user.usecases.v1
{
    public class CreateUserUseCase : ICreateUserPort
    {
        private readonly IRepositoryUser _userRepository;


        public CreateUserUseCase(IRepositoryUser userRepository) { 
            _userRepository = userRepository;
        }

        public async Task<UserEntity> Execute(ICreateUserInput input)
        {
            try
            {
                var userCreated = new UserEntity(
                    input.UserName,
                    input.Email,
                    input.Password
                );

                 _userRepository.AddUser(userCreated);

                return userCreated;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
