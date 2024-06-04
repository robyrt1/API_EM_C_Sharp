namespace API_EM_C_.src.user.infra.repository
{
    using API_EM_C_.src.shared.infrastructure.services.Data;
    using API_EM_C_.src.user.domain.entity.v1;
    using API_EM_C_.src.user.domain.port.repository;
    using Microsoft.EntityFrameworkCore;

    public class UserRepository : IRepositoryUser
    {
        private readonly DatabaseContext _dbContext;

        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public async Task<IEnumerable<UserEntity>> GetUsers()
        {
                var users =  _dbContext.Users
                    .Select(user => new UserEntity 
                        { 
                            Id = user.Id,
                            UserName = user.UserName,
                            Email = user.Email,
                        })
                    .ToList();

                return users;

        }

        public void AddUser(UserEntity user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }
    }
}
