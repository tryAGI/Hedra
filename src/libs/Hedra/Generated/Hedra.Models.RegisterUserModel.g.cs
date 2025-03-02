
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RegisterUserModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("residence_not_blocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResidenceNotBlocked { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tos_accepted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool TosAccepted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tos_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TosVersion { get; set; }

        /// <summary>
        /// Default Value: NONE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketing_email_consent")]
        public string? MarketingEmailConsent { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_training_opt_out")]
        public bool? AiTrainingOptOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterUserModel" /> class.
        /// </summary>
        /// <param name="residenceNotBlocked"></param>
        /// <param name="tosAccepted"></param>
        /// <param name="tosVersion"></param>
        /// <param name="marketingEmailConsent">
        /// Default Value: NONE
        /// </param>
        /// <param name="aiTrainingOptOut">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RegisterUserModel(
            string residenceNotBlocked,
            bool tosAccepted,
            string tosVersion,
            string? marketingEmailConsent,
            bool? aiTrainingOptOut)
        {
            this.ResidenceNotBlocked = residenceNotBlocked ?? throw new global::System.ArgumentNullException(nameof(residenceNotBlocked));
            this.TosAccepted = tosAccepted;
            this.TosVersion = tosVersion ?? throw new global::System.ArgumentNullException(nameof(tosVersion));
            this.MarketingEmailConsent = marketingEmailConsent;
            this.AiTrainingOptOut = aiTrainingOptOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterUserModel" /> class.
        /// </summary>
        public RegisterUserModel()
        {
        }
    }
}