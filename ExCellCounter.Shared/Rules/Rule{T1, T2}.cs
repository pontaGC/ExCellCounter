using System.Diagnostics.CodeAnalysis;

namespace ExCellCounter.Shared.Rules;

/// <summary>
/// The implementation of the <see cref="IRule{TTarget, TError}"/>.
/// </summary>
public class Rule<TTarget, TError> : IRule<TTarget, TError>
{
    private readonly Predicate<TTarget> applyRule;
    private readonly Func<TTarget, TError> getError;

    /// <summary>
    /// Initializes a new instance of the <see cref="Rule{TTarget, TError}"/> class.
    /// </summary>
    /// <param name="ruleName">The rule name.</param>
    /// <param name="applyRule">The check function that the target object satisfy a rule.</param>
    /// <param name="getError">The function to get error if rule fails.</param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="ruleName"/> or <paramref name="applyRule"/> or <paramref name="getError"/> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentException"><paramref name="ruleName"/> is an empty string.</exception>
    public Rule(string ruleName, Predicate<TTarget> applyRule, Func<TTarget, TError> getError)
    {
        ArgumentException.ThrowIfNullOrEmpty(ruleName);
        ArgumentNullException.ThrowIfNull(applyRule);
        ArgumentNullException.ThrowIfNull(getError);

        this.Name = ruleName;
        this.applyRule = applyRule;
        this.getError = getError;
    }

    /// <inheritdoc />
    [NotNull]
    public string Name { get; }

    /// <inheritdoc />
    public (bool Passed, TError Error) Apply(TTarget target)
    {
        var passed = this.applyRule(target);
        if (passed)
        {
            return (true, default);
        }

        return (false, this.getError(target));
    }
}
