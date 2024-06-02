using API_EM_C_.src.shared.application.port;
using API_EM_C_.src.user.application.types;
using API_EM_C_.src.user.domain.entity.v1;
using API_EM_C_.src.user.domain.port.usecases.v1;
using API_EM_C_.src.user.domain.validator;
using API_EM_C_.src.user.usecases.v1;
using Microsoft.AspNetCore.Mvc;

namespace API_EM_C_.src.user.presentation.controller.v1
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController: ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IFindAllUsers _findAllUsersUsecase;
        private readonly ICreateUserPort _createUserPort;

        public UserController(ILogger<UserController> logger, IFindAllUsers findAllUsersUsecase, ICreateUserPort createUserPort)
        {
            _logger = logger;
            _findAllUsersUsecase = findAllUsersUsecase;
            _createUserPort = createUserPort;
        }


        [HttpGet(Name = "Users")]
        public ActionResult<IEnumerable<UserEntity>> findAll()
        {
            var users = _findAllUsersUsecase.Execute();

            return Ok(users);
        }

        [HttpPost(Name = "Users")]
        public async Task<ActionResult> CreateUser([FromBody] UserValidator input) {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user =  _createUserPort.Execute(input);
            return CreatedAtAction(nameof(CreateUser), new { id = user.Id }, user);
        }

    }
}
