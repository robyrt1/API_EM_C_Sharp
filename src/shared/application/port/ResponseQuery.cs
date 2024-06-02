namespace API_EM_C_.src.shared.application.port
{
    public interface IResponseQuery<T>
    {
        public List<T[,]> result { get; set; }
    }
}
