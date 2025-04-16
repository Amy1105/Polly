#nullable enable
namespace Polly.Bulkhead;

/// <summary>
/// Defines properties and methods common to all bulkhead policies.
/// 定义所有舱壁策略共有的属性和方法.
/// </summary>
public interface IBulkheadPolicy : IsPolicy, IDisposable
{
    /// <summary>
    /// Gets the number of slots currently available for executing actions through the bulkhead.
    /// 获取当前可用于通过隔板执行操作的插槽数.
    /// </summary>
    int BulkheadAvailableCount { get; }

    /// <summary>
    /// Gets the number of slots currently available for queuing actions for execution through the bulkhead.
    /// 获取当前可用于通过隔板排队执行操作的插槽数.
    /// </summary>
    int QueueAvailableCount { get; }
}

/// <summary>
/// Defines properties and methods common to all bulkhead policies generic-typed for executions returning results of type <typeparamref name="TResult"/>.
/// </summary>
/// <typeparam name="TResult">The type of the result.</typeparam>
public interface IBulkheadPolicy<TResult> : IBulkheadPolicy
{
}
