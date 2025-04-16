namespace Polly;

public abstract partial class Policy
{
    /// <summary>
    /// Defines the implementation of a policy for sync executions with no return value.
    /// 定义不返回值的同步执行策略的实现.
    /// </summary>
    /// <param name="action">The action passed by calling code to execute through the policy.</param>
    /// <param name="context">The policy execution context.</param>
    /// <param name="cancellationToken">A token to signal that execution should be cancelled.</param>
    [DebuggerStepThrough]
    protected virtual void Implementation(Action<Context, CancellationToken> action, Context context, CancellationToken cancellationToken) =>
        Implementation((ctx, token) =>
        {
            action(ctx, token);
            return EmptyStruct.Instance;
        }, context, cancellationToken);

    /// <summary>
    /// Defines the implementation of a policy for synchronous executions returning <typeparamref name="TResult"/>.
    /// 定义同步执行返回<typeparamref name="TResult"/>的策略的实现.
    /// </summary>
    /// <typeparam name="TResult">The type returned by synchronous executions through the implementation.</typeparam>
    /// <param name="action">The action passed by calling code to execute through the policy.</param>
    /// <param name="context">The policy execution context.</param>
    /// <param name="cancellationToken">A token to signal that execution should be cancelled.</param>
    /// <returns>A <typeparamref name="TResult"/> result of the execution.</returns>
    protected abstract TResult Implementation<TResult>(Func<Context, CancellationToken, TResult> action, Context context, CancellationToken cancellationToken);
}
