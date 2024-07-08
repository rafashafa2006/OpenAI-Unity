namespace OpenAI
{
    public interface IResponse
    {
        ApiError Error { get; set; }
        string Warning { get; set; }
    }
}
