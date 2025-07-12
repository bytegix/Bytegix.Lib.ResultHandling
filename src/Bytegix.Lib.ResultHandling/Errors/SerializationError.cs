namespace Bytegix.Lib.ResultHandling.Errors;

public class SerializationError : Error
{
    // Constructor
    // ==============================
    public SerializationError(Type type) : base($"Failed to serialize {type.Name}")
    {
    }
}
