namespace API_EM_C_.src.shared.application.exceptions.type
{
    public interface IGenerateException <T>
    {
        T Data { get; protected set; }
        string Message { get; set; }
        int StatusCode { get; set; }
        bool Status { get; }
        
    }
}
