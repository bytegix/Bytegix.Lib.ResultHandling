using System.Collections.Frozen;

namespace Bytegix.Lib.ResultHandling.Errors;

public class ExternalServiceError : Error
{
    // Constructor
    // ==============================
    public ExternalServiceError(string serviceName, string? message = null)
        : base(message ?? $"An error occurred while using external service: {serviceName}")
    {
        
    }
}