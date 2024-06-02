namespace API_EM_C_.src.shared.application.port
{
    public interface UseCasePort<OutPut, Input>
    {
        public  Task<OutPut> Execute(Input input);
    }
}
