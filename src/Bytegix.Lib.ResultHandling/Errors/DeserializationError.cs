namespace Bytegix.Lib.ResultHandling.Errors;

public class DeserializationError : Error
{
    // Constructor
    // ==============================
    public DeserializationError(Type type) : base($"Failed to deserialize into {type.Name}")
    {
    }
}
