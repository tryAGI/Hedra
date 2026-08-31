
#nullable enable

namespace Hedra
{
    /// <summary>
    /// One machine-readable conditional input rule the backend enforces.<br/>
    /// Published verbatim on the v2 `/models` surface so clients can apply the<br/>
    /// same narrowing the submit validators do, instead of hardcoding per-model<br/>
    /// rules. Declared by `BaseAIModel.conditional_constraints()`; each instance<br/>
    /// mirrors (or drives) a backend validator, and a registry test pins the two<br/>
    /// together so they cannot drift.
    /// </summary>
    public sealed partial class ConditionalConstraint
    {
        /// <summary>
        /// Conjunctive conditions; all present keys must match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.ConstraintCondition When { get; set; }

        /// <summary>
        /// How the advertised values narrow while `when` matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("then")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.ConstraintEffect Then { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalConstraint" /> class.
        /// </summary>
        /// <param name="when">
        /// Conjunctive conditions; all present keys must match.
        /// </param>
        /// <param name="then">
        /// How the advertised values narrow while `when` matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConditionalConstraint(
            global::Hedra.ConstraintCondition when,
            global::Hedra.ConstraintEffect then)
        {
            this.When = when ?? throw new global::System.ArgumentNullException(nameof(when));
            this.Then = then ?? throw new global::System.ArgumentNullException(nameof(then));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalConstraint" /> class.
        /// </summary>
        public ConditionalConstraint()
        {
        }

    }
}