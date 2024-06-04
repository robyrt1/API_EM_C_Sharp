using API_EM_C_.src.shared.application.constants;

namespace API_EM_C_.src.shared.application.exceptions
{
    public class InternalErrorException : Exception
    {
        public string ExceptionCode { get; }

        public InternalErrorException(string message = null)
            : base(message)
        {
            ExceptionCode = ExceptionCodes.GENERIC_INTERNAL;
            HttpStatus = HttpStatusCode.BAD_REQUEST;
        }

        public HttpStatusCode HttpStatus { get; }
    }

    public class GenerateErrorExceptionByCode : Exception
    {
        public string ExceptionCode { get; }

        public GenerateErrorExceptionByCode(string Code,string message = null) : base(message) 
        {
            ExceptionCode = Code;
            HttpStatus = HttpStatusCode.BAD_REQUEST;
        }
        public HttpStatusCode HttpStatus { get; }
    }
}
