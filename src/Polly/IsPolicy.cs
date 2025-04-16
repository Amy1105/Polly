namespace Polly;

/// <summary>
/// A marker interface identifying Polly policies of all types, and containing properties common to all policies.
/// 一个标记接口，用于标识所有类型的Polly策略，并包含所有策略共有的属性
/// </summary>
#pragma warning disable IDE1006

public interface IsPolicy
#pragma warning restore IDE1006
{
    /// <summary>
    /// Gets a key intended to be unique to each policy instance, which is passed with executions as the <see cref="Context.PolicyKey"/> property.
    /// 获取一个对每个策略实例都是唯一的键，该键与执行一起作为<see cref="Context.PolicyKey"/>属性传递。
    /// </summary>
    string PolicyKey { get; }
}
