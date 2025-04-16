namespace Polly;

/// <summary>
/// Implements elements common to both non-generic and generic policies, and sync and async policies.
/// 实现非通用和通用策略以及同步和异步策略共有的元素.
/// </summary>
public abstract partial class PolicyBase
{
    /// <summary>
    /// Defines a value to use for continueOnCaptureContext, when none is supplied.
    /// 定义一个值，当没有提供值时，用于continueOnCaptureContext.
    /// </summary>
    internal const bool DefaultContinueOnCapturedContext = false;

    /// <summary>
    /// Gets the predicates indicating which exceptions the policy handles.
    /// 获取指示策略处理哪些异常的谓词.
    /// </summary>
    protected internal ExceptionPredicates ExceptionPredicates { get; }

    /// <summary>
    /// Defines a CancellationToken to use, when none is supplied.
    /// 定义一个默认的取消令牌.
    /// </summary>
    internal readonly CancellationToken DefaultCancellationToken = CancellationToken.None;

    internal static ExceptionType GetExceptionType(ExceptionPredicates exceptionPredicates, Exception exception)
    {
        bool isExceptionTypeHandledByThisPolicy = exceptionPredicates.FirstMatchOrDefault(exception) != null;

        return isExceptionTypeHandledByThisPolicy
            ? ExceptionType.HandledByThisPolicy
            : ExceptionType.Unhandled;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyBase"/> class.
    /// 初始化<see cref="PolicyBase"/>类的新实例.
    /// </summary>
    /// <param name="exceptionPredicates">Predicates indicating which exceptions the policy should handle.指示策略应处理哪些异常的谓词. </param>
    private protected PolicyBase(ExceptionPredicates exceptionPredicates) =>
        ExceptionPredicates = exceptionPredicates ?? ExceptionPredicates.None;

    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyBase"/> class.
    /// 初始化<see cref="PolicyBase"/>类的新实例.
    /// </summary>
    /// <param name="policyBuilder">A <see cref="PolicyBuilder"/> indicating which exceptions the policy should handle.
    /// <see cref="PolicyBuilder"/>指示策略应处理哪些异常.</param>
    protected PolicyBase(PolicyBuilder policyBuilder)
        : this(policyBuilder?.ExceptionPredicates)
    {
    }
}

/// <summary>
/// Implements elements common to sync and async generic policies.
/// 实现同步和异步通用策略的通用元素.
/// </summary>
/// <typeparam name="TResult">The type of the result.</typeparam>
public abstract class PolicyBase<TResult> : PolicyBase
{
    /// <summary>
    /// Gets the predicates indicating which results the policy handles.
    /// 获取指示策略处理哪些结果的谓词
    /// </summary>
    protected internal ResultPredicates<TResult> ResultPredicates { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyBase{TResult}"/> class.
    /// 初始化<see cref="PolicyBase{TResult}"/>类的新实例.
    /// </summary>
    /// <param name="exceptionPredicates">Predicates indicating which exceptions the policy should handle.指示策略应处理哪些异常的谓词. </param>
    /// <param name="resultPredicates">Predicates indicating which results the policy should handle.指示策略应处理哪些结果的谓词. </param>
    private protected PolicyBase(
        ExceptionPredicates exceptionPredicates,
        ResultPredicates<TResult> resultPredicates)
    : base(exceptionPredicates) =>
        ResultPredicates = resultPredicates ?? ResultPredicates<TResult>.None;

    /// <summary>
    /// Initializes a new instance of the <see cref="PolicyBase{TResult}"/> class.
    /// </summary>
    /// <param name="policyBuilder">A <see cref="PolicyBuilder"/> indicating which exceptions the policy should handle.</param>
    protected PolicyBase(PolicyBuilder<TResult> policyBuilder)
        : this(policyBuilder?.ExceptionPredicates, policyBuilder?.ResultPredicates)
    {
    }
}
