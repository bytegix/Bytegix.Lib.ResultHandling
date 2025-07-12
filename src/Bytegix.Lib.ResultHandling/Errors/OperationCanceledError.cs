using System.Runtime.CompilerServices;

namespace Bytegix.Lib.ResultHandling.Errors;

public class OperationCanceledError : Error
{
    // Constructor
    // ==============================
    public OperationCanceledError(
        [CallerMemberName] string? callerMemberName = null,
        [CallerLineNumber] int? callerLineNumber = null) : base(
        $"Operation was canceled. Origin: {callerMemberName}:{callerLineNumber}")
    {
    }
}
