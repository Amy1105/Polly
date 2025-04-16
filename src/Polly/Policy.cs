#nullable enable
namespace Polly;

/// <summary>
/// Transient exception handling policies that can be applied to synchronous delegates.
/// 可应用于同步委托的瞬态异常处理策略.
/// </summary>
public abstract partial class Policy : PolicyBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Policy"/> class.
    /// </summary>
    /// <param name="exceptionPredicates">Predicates indicating which exceptions the policy should handle.
    /// 指示策略应处理哪些异常的谓词.</param>
    private protected Policy(ExceptionPredicates exceptionPredicates)
        : base(exceptionPredicates)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Policy"/> class.
    /// </summary>
    /// <param name="policyBuilder">A <see cref="PolicyBuilder"/> specifying which exceptions the policy should handle.
    /// 指定策略应处理哪些异常.</param>
    protected Policy(PolicyBuilder? policyBuilder = null)
        : base(policyBuilder)
    {
    }
}
