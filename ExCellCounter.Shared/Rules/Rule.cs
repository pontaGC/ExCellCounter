namespace ExCellCounter.Shared.Rules;

/// <summary>
/// The implementation of the <see cref="IRule{T}"/>.
/// </summary>
public class Rule<T> : Rule<T, string>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Rule{T}"/> class.
    /// </summary>
    /// <param name="ruleName">The rule name.</param>
    /// <param name="applyRule">The check function that the target object satisfy a rule.</param>
    /// <param name="getError">The function to get error if rule fails.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="ruleName"/> or <paramref name="applyRule"/> or <paramref name="getError"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentException"><paramref name="ruleName"/> is an empty string.</exception>
    public Rule(string ruleName, Predicate<T> applyRule, Func<T, string> getError)
        : base(ruleName, applyRule, getError)
    {
    }
}
