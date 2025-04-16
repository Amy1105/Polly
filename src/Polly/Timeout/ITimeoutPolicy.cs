namespace Polly.Timeout;

/// <summary>
/// Defines properties and methods common to all Timeout policies.
/// 定义所有Timeout策略共有的属性和方法.
/// </summary>
public interface ITimeoutPolicy : IsPolicy
{
}

/// <summary>
/// Defines properties and methods common to all Timeout policies generic-typed for executions returning results of type <typeparamref name="TResult"/>.
/// </summary>
/// <typeparam name="TResult">The type of the result.</typeparam>
public interface ITimeoutPolicy<TResult> : ITimeoutPolicy
{
}
