namespace Bytegix.Lib.ResultHandling.Common;

/// <summary>Defines an actionable result.</summary>
public interface IActionableResult<out TResult> : IResult where TResult : IActionableResult<TResult>
{
    /// <summary>Creates a success result.</summary>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a success result with the specified value.</returns>
    static abstract TResult Ok();

    /// <summary>Creates a failed result.</summary>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result.</returns>
    static abstract TResult Fail();

    /// <summary>Creates a failed result with the given error message.</summary>
    /// <param name="errorMessage">The error message associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error message.</returns>
    static abstract TResult Fail(string errorMessage);

    /// <summary>Creates a failed result with the given error message and metadata.</summary>
    /// <param name="errorMessage">The error message associated with the failure.</param>
    /// <param name="metadata">The metadata associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error message and metadata.</returns>
    static abstract TResult Fail(string errorMessage, (string Key, object Value) metadata);

    /// <summary>Creates a failed result with the given error message and metadata.</summary>
    /// <param name="errorMessage">The error message associated with the failure.</param>
    /// <param name="metadata">The metadata associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error message and metadata.</returns>
    static abstract TResult Fail(string errorMessage, IDictionary<string, object> metadata);

    /// <summary>Creates a failed result with the given error.</summary>
    /// <param name="error">The error associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error.</returns>
    static abstract TResult Fail(IError error);

    /// <summary>Creates a failed result with the given errors.</summary>
    /// <param name="errors">A collection of errors associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified errors.</returns>
    static abstract TResult Fail(IEnumerable<IError> errors);
}

/// <summary>Defines an actionable result.</summary>
public interface IActionableResult<TValue, out TResult> : IResult<TValue> where TResult : IActionableResult<TValue, TResult>
{
    /// <summary>Creates a success result with the given value.</summary>
    /// <param name="value">The value to include in the result.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a success result with the specified value.</returns>
    static abstract TResult Ok(TValue value);

    /// <summary>Creates a failed result.</summary>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result.</returns>
    static abstract TResult Fail();

    /// <summary>Creates a failed result with the given error message.</summary>
    /// <param name="errorMessage">The error message associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error message.</returns>
    static abstract TResult Fail(string errorMessage);

    /// <summary>Creates a failed result with the given error message and metadata.</summary>
    /// <param name="errorMessage">The error message associated with the failure.</param>
    /// <param name="metadata">The metadata associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error message and metadata.</returns>
    static abstract TResult Fail(string errorMessage, (string Key, object Value) metadata);

    /// <summary>Creates a failed result with the given error message and metadata.</summary>
    /// <param name="errorMessage">The error message associated with the failure.</param>
    /// <param name="metadata">The metadata associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error message and metadata.</returns>
    static abstract TResult Fail(string errorMessage, IDictionary<string, object> metadata);

    /// <summary>Creates a failed result with the given error.</summary>
    /// <param name="error">The error associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified error.</returns>
    static abstract TResult Fail(IError error);

    /// <summary>Creates a failed result with the given errors.</summary>
    /// <param name="errors">A collection of errors associated with the failure.</param>
    /// <returns>A new instance of <typeparamref name="TResult" /> representing a failed result with the specified errors.</returns>
    static abstract TResult Fail(IEnumerable<IError> errors);
}
