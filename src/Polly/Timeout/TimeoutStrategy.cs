namespace Polly.Timeout;

/// <summary>
/// Defines how timeouts are enforced.
/// �������ǿ��ִ�г�ʱ.
/// </summary>
public enum TimeoutStrategy
{
    /// <summary>
    /// An optimistic <see cref="TimeoutStrategy"/>. The <see cref="Timeout.TimeoutPolicy"/> relies on a timing-out <see cref="CancellationToken"/> to cancel executed delegates by co-operative cancellation.
    /// �ֹ۵�<see cref="TimeoutStrategy"/>��<see cref="Timeout.TimeoutPolicy"/>�����ڳ�ʱ<see cred="CancellationToken"/>ͨ������ȡ����ȡ����ִ�е�ί��.
    /// </summary>
    Optimistic,

    /// <summary>
    /// A pessimistic <see cref="TimeoutStrategy"/>. The <see cref="Timeout.TimeoutPolicy"/> will assume the delegates passed to be executed will not necessarily honor
    /// any timing-out <see cref="CancellationToken"/> but the policy will still guarantee timing out (and returning to the caller) by other means.
    ///
    /// ����������<see cref="TimeoutStrategy"/>
    /// <see cref="Timeout.TimeoutPolicy"/>�����贫�ݸ�ִ�е�ί�в�һ���������κγ�ʱ<see cred="CancellationToken"/>�����ò����Խ�ͨ��������ʽ��֤��ʱ�������ظ������ߣ�.
    /// </summary>
    Pessimistic
}
