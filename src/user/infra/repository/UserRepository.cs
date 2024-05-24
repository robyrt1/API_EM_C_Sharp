using API_EM_C_.src.shared.infrastructure.services.Data;
using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.repository;
using Npgsql;


namespace API_EM_C_.src.user.infra.repository
{
    public class UserRepository : IRepositoryUser
    {
        private readonly DatabaseContext _dbContext;

        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<UserEntity>> GetUsers()
        {            try
            {
                var users =   _dbContext.Users.ToList();
                return users;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao executar a consulta: {ex.Message}");
                throw;
            }
        }
    }
}
