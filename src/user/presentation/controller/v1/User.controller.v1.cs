using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.usecases.v1;
using Microsoft.AspNetCore.Mvc;

namespace API_EM_C_.src.user.presentation.controller.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IFindAllUsers _findAllUsersUsecase;

        public UserController(ILogger<UserController> logger, IFindAllUsers findAllUsersUsecase)
        {
            _logger = logger;
            _findAllUsersUsecase = findAllUsersUsecase;
        }


        [HttpGet(Name = "Users")]
        public ActionResult<IEnumerable<UserEntity>> findAll()
        {
            var users = _findAllUsersUsecase.Execute();

            return Ok(users);
        }

    }
}
