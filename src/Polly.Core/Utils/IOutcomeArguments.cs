namespace Polly.Utils;

/// <summary>
/// Marker interface for outcome arguments.
/// 结果参数的标记接口.
/// </summary>
/// <typeparam name="TResult">The type of result.</typeparam>
internal interface IOutcomeArguments<TResult>
{
    /// <summary>
    /// Gets the resilience context.
    /// 获取弹性上下文.
    /// </summary>
    ResilienceContext Context { get; }

    /// <summary>
    /// Gets the outcome.
    /// 获取结果.
    /// </summary>
    Outcome<TResult> Outcome { get; }
}
