using API_EM_C_.src.shared.application.exceptions.type;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace API_EM_C_.src.shared.application.exceptions
{
    public class ApiResponseException<T> : IGenerateException<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public bool Status { get; } = false;

        public ApiResponseException(T data, string message, int statusCode, bool status = false)
        {
            Data = data;
            Message = message;
            StatusCode = statusCode;
            Status = status;
        }

    }
}
