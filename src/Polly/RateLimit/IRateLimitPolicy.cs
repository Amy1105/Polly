#nullable enable
namespace Polly.RateLimit;

/// <summary>
/// Defines properties and methods common to all RateLimit policies.
/// 定义所有RateLimit策略共有的属性和方法.
/// </summary>
public interface IRateLimitPolicy : IsPolicy
{
}

/// <summary>
/// Defines properties and methods common to all RateLimit policies generic-typed for executions returning results of type <typeparamref name="TResult"/>.
/// </summary>
/// <typeparam name="TResult">The type of the result.</typeparam>
public interface IRateLimitPolicy<TResult> : IRateLimitPolicy
{
}
