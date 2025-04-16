#nullable enable
namespace Polly.Fallback;

/// <summary>
/// Defines properties and methods common to all Fallback policies.
/// 定义所有回退策略共有的属性和方法.
/// </summary>
public interface IFallbackPolicy : IsPolicy
{
}

/// <summary>
/// Defines properties and methods common to all Fallback policies generic-typed for executions returning results of type <typeparamref name="TResult"/>.
/// </summary>
/// <typeparam name="TResult">The type of the result.</typeparam>
public interface IFallbackPolicy<TResult> : IFallbackPolicy
{
}
