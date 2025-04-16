namespace Polly.Timeout;

/// <summary>
/// Defines how timeouts are enforced.
/// 定义如何强制执行超时.
/// </summary>
public enum TimeoutStrategy
{
    /// <summary>
    /// An optimistic <see cref="TimeoutStrategy"/>. The <see cref="Timeout.TimeoutPolicy"/> relies on a timing-out <see cref="CancellationToken"/> to cancel executed delegates by co-operative cancellation.
    /// 乐观的<see cref="TimeoutStrategy"/>。<see cref="Timeout.TimeoutPolicy"/>依赖于超时<see cred="CancellationToken"/>通过合作取消来取消已执行的委托.
    /// </summary>
    Optimistic,

    /// <summary>
    /// A pessimistic <see cref="TimeoutStrategy"/>. The <see cref="Timeout.TimeoutPolicy"/> will assume the delegates passed to be executed will not necessarily honor
    /// any timing-out <see cref="CancellationToken"/> but the policy will still guarantee timing out (and returning to the caller) by other means.
    ///
    /// 悲观主义者<see cref="TimeoutStrategy"/>
    /// <see cref="Timeout.TimeoutPolicy"/>将假设传递给执行的委托不一定会遵守任何超时<see cred="CancellationToken"/>，但该策略仍将通过其他方式保证超时（并返回给调用者）.
    /// </summary>
    Pessimistic
}
