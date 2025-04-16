#nullable enable
namespace Polly.Caching;

/// <summary>
/// Defines a ttl strategy which will cache items until the specified point-in-time.
/// 定义一个ttl策略，该策略将缓存项目直到指定的时间点.
/// </summary>
public class AbsoluteTtl : NonSlidingTtl
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AbsoluteTtl"/> class.
    /// </summary>
    /// <param name="absoluteExpirationTime">The UTC point in time until which to consider the cache item valid.</param>
    public AbsoluteTtl(DateTimeOffset absoluteExpirationTime)
        : base(absoluteExpirationTime)
    {
    }
}
