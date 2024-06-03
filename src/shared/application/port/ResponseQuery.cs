namespace API_EM_C_.src.shared.application.port
{
    public interface IResponseQuery<T>
    {
        T result { get; set; }
        int Id { get; set; }
        Exception Exception { get; set; }
        int Status { get; set; }
        bool IsCanceled { get; set; }
        bool IsCompleted { get; set; }
        bool IsCompletedSuccessfully { get; set; }
        TaskCreationOptions CreationOptions { get; set; }
        object AsyncState { get; set; }
        bool IsFaulted { get; set; }
    }
}
