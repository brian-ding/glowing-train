namespace BookStore.Exceptions;

public class RemoteServiceException(string? message, int httpStatusCode, string errorMessage) : Exception(message)
{
    public int HttpStatusCode { get; set; } = httpStatusCode;

    public string ErrorMessage { get; set; } = errorMessage;
}