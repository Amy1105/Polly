﻿using System.ComponentModel;

namespace Polly;

/// <summary>
/// Builder class that holds the list of current exception predicates.
/// 保存当前异常谓词列表的生成器类.
/// </summary>
public sealed partial class PolicyBuilder
{
    internal PolicyBuilder(ExceptionPredicate exceptionPredicate)
    {
        ExceptionPredicates = new ExceptionPredicates();
        ExceptionPredicates.Add(exceptionPredicate);
    }

    /// <summary>
    /// Gets the predicates specifying exceptions that the policy is being configured to handle.
    /// 获取指定策略配置为处理的异常的谓词.
    /// </summary>
    internal ExceptionPredicates ExceptionPredicates { get; }

    #region Hide object members

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() =>
        base.ToString();

    /// <summary>
    /// Determines whether the specified <see cref="object" /> is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) =>
        base.Equals(obj);

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() =>
        base.GetHashCode();

#pragma warning disable S4049 //Consider making method a property
    /// <summary>
    /// Gets the <see cref="System.Type" /> of the current instance.
    /// </summary>
    /// <returns>
    /// The <see cref="System.Type" /> instance that represents the exact runtime type of the current instance.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new Type GetType() =>
        base.GetType();
#pragma warning restore S4049

    #endregion
}

/// <summary>
/// Builder class that holds the list of current execution predicates filtering TResult result values.
/// </summary>
/// <typeparam name="TResult">The type of the result value that the execution predicates are filtering.</typeparam>
public sealed partial class PolicyBuilder<TResult>
{
    private PolicyBuilder()
    {
        ExceptionPredicates = new ExceptionPredicates();
        ResultPredicates = new ResultPredicates<TResult>();
    }

    internal PolicyBuilder(Func<TResult, bool> resultPredicate)
        : this() => OrResult(resultPredicate);

    internal PolicyBuilder(ExceptionPredicate predicate)
        : this() => ExceptionPredicates.Add(predicate);

    internal PolicyBuilder(ExceptionPredicates exceptionPredicates)
        : this() =>
        ExceptionPredicates = exceptionPredicates;

    /// <summary>
    /// Gets the predicates specifying exceptions that the policy is being configured to handle.
    /// </summary>
    internal ExceptionPredicates ExceptionPredicates { get; }

    /// <summary>
    /// Gets the predicates specifying results that the policy is being configured to handle.
    /// </summary>
    internal ResultPredicates<TResult> ResultPredicates { get; }

    #region Hide object members

    /// <summary>
    /// Returns a <see cref="string" /> that represents this instance.
    /// </summary>
    /// <returns>
    /// A <see cref="string" /> that represents this instance.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string ToString() =>
        base.ToString();

    /// <summary>
    /// Determines whether the specified <see cref="object" /> is equal to this instance.
    /// </summary>
    /// <param name="obj">The <see cref="object" /> to compare with this instance.</param>
    /// <returns>
    ///   <c>true</c> if the specified <see cref="object" /> is equal to this instance; otherwise, <c>false</c>.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override bool Equals(object obj) =>
        base.Equals(obj);

    /// <summary>
    /// Returns a hash code for this instance.
    /// </summary>
    /// <returns>
    /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override int GetHashCode() =>
        base.GetHashCode();

#pragma warning disable S4049 //Consider making method a property
    /// <summary>
    /// Gets the <see cref="System.Type" /> of the current instance.
    /// </summary>
    /// <returns>
    /// The <see cref="System.Type" /> instance that represents the exact runtime type of the current instance.
    /// </returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public new Type GetType() =>
        base.GetType();
#pragma warning restore S4049

    #endregion
}
