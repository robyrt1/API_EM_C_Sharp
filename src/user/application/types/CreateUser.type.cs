namespace API_EM_C_.src.user.application.types
{
    public interface ICreateUserInput
    {
        String UserName { get; set; }
        String Email { get; set; }
        String Password { get; set; }
    }
}
