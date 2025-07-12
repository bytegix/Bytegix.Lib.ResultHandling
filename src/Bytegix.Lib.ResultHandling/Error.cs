using System.Collections.Frozen;
using Bytegix.Lib.ResultHandling.Common;

namespace Bytegix.Lib.ResultHandling;

/// <summary>Represents an error with a message and associated metadata.</summary>
public class Error : IError
{
    internal static Error Empty { get; } = new();

    /// <inheritdoc />
    public string Message { get; }

    /// <inheritdoc />
    public IReadOnlyDictionary<string, object> Metadata => _metadata;

    private readonly FrozenDictionary<string, object> _metadata;

    /// <summary>Initializes a new instance of the <see cref="Error" /> class.</summary>
    public Error() : this("")
    {
    }

    /// <summary>Initializes a new instance of the <see cref="Error" /> class with the specified error message.</summary>
    /// <param name="message">The error message.</param>
    public Error(string message)
    {
        Message = message;

        _metadata = FrozenDictionary<string, object>.Empty;
    }


    /// <summary>Initializes a new instance of the <see cref="Error" /> class with the specified metadata.</summary>
    /// <param name="metadata">The metadata associated with the error.</param>
    public Error((string Key, object Value) metadata) : this("", metadata)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="Error" /> class with the specified error message and metadata.</summary>
    /// <param name="message">The error message.</param>
    /// <param name="metadata">The metadata associated with the error.</param>
    public Error(string message, (string Key, object Value) metadata)
    {
        Message = message;

        var dictionary = new Dictionary<string, object> { { metadata.Key, metadata.Value } };
        _metadata = dictionary.ToFrozenDictionary();
    }

    /// <summary>Initializes a new instance of the <see cref="Error" /> class with the specified metadata.</summary>
    /// <param name="metadata">The metadata associated with the error.</param>
    public Error(IDictionary<string, object> metadata) : this("", metadata)
    {
    }

    /// <summary>Initializes a new instance of the <see cref="Error" /> class with the specified error message and metadata.</summary>
    /// <param name="message">The error message.</param>
    /// <param name="metadata">The metadata associated with the error.</param>
    public Error(string message, IDictionary<string, object> metadata)
    {
        Message = message;

        _metadata = metadata.ToFrozenDictionary();
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return ResultStringHelper.GetErrorString(this);
    }
}
