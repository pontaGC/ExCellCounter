namespace ExCellCounter.Shared.Rules;

/// <summary>
/// The list of <see cref="IRule{TTarget, TError}"/>.
/// </summary>
public class RuleList<TTarget, TError> : SynchronizedList<IRule<TTarget, TError>>
{
    /// <summary>
    /// Applies all rules to the given object with lazy evaluation.
    /// </summary>
    /// <param name="target">The target object to check.</param>
    /// <returns>The collection to error if rule fails.</returns>
    public IEnumerable<TError> Apply(TTarget target)
    {
        var allRules = this.ToArray();
        foreach (var rule in allRules)
        {
            var applied = rule.Apply(target);
            if (applied.Passed == false)
            {
                yield return applied.Error;
            }
        }
    }
}
