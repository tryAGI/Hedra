
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Default Value: Unknown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarUrl")]
        public string? AvatarUrl { get; set; }

        /// <summary>
        /// Default Value: free
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountTier")]
        public string? AccountTier { get; set; }

        /// <summary>
        /// Default Value: free
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiAccountTier")]
        public string? ApiAccountTier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webSubscriptionEnd")]
        public int? WebSubscriptionEnd { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarProjectCreditUsed")]
        public int? AvatarProjectCreditUsed { get; set; }

        /// <summary>
        /// Default Value: 250
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarProjectCreditLimit")]
        public int? AvatarProjectCreditLimit { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarProjectWebCreditUsed")]
        public int? AvatarProjectWebCreditUsed { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarProjectWebCreditLimit")]
        public int? AvatarProjectWebCreditLimit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowWebCreditOverages")]
        public bool? AllowWebCreditOverages { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webCreditOverageMax")]
        public int? WebCreditOverageMax { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowApiCreditOverages")]
        public bool? AllowApiCreditOverages { get; set; }

        /// <summary>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiCreditOverageMax")]
        public int? ApiCreditOverageMax { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarConsent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AvatarConsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptionState")]
        public string? SubscriptionState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tosAcceptableDate")]
        public string? TosAcceptableDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tosAcceptedVersion")]
        public string? TosAcceptedVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSubscriptionState")]
        public string? ApiSubscriptionState { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiTOSAcceptance")]
        public bool? ApiTOSAcceptance { get; set; }

        /// <summary>
        /// Default Value: NONE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketingEmailConsent")]
        public string? MarketingEmailConsent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aiTrainingOptOut")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AiTrainingOptOut { get; set; }

        /// <summary>
        /// Default Value: NONE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("residenceLegalConfirmed")]
        public string? ResidenceLegalConfirmed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dresidenceLegalUpdatedAt")]
        public string? DresidenceLegalUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tierLimits")]
        public global::Hedra.TierLimits? TierLimits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="username">
        /// Default Value: Unknown
        /// </param>
        /// <param name="avatarUrl"></param>
        /// <param name="accountTier">
        /// Default Value: free
        /// </param>
        /// <param name="apiAccountTier">
        /// Default Value: free
        /// </param>
        /// <param name="webSubscriptionEnd"></param>
        /// <param name="avatarProjectCreditUsed">
        /// Default Value: 0
        /// </param>
        /// <param name="avatarProjectCreditLimit">
        /// Default Value: 250
        /// </param>
        /// <param name="avatarProjectWebCreditUsed">
        /// Default Value: 0
        /// </param>
        /// <param name="avatarProjectWebCreditLimit">
        /// Default Value: 0
        /// </param>
        /// <param name="allowWebCreditOverages">
        /// Default Value: false
        /// </param>
        /// <param name="webCreditOverageMax">
        /// Default Value: 300
        /// </param>
        /// <param name="allowApiCreditOverages">
        /// Default Value: false
        /// </param>
        /// <param name="apiCreditOverageMax">
        /// Default Value: 300
        /// </param>
        /// <param name="avatarConsent"></param>
        /// <param name="subscriptionState"></param>
        /// <param name="tosAcceptableDate"></param>
        /// <param name="tosAcceptedVersion"></param>
        /// <param name="apiSubscriptionState"></param>
        /// <param name="apiTOSAcceptance">
        /// Default Value: false
        /// </param>
        /// <param name="marketingEmailConsent">
        /// Default Value: NONE
        /// </param>
        /// <param name="aiTrainingOptOut"></param>
        /// <param name="residenceLegalConfirmed">
        /// Default Value: NONE
        /// </param>
        /// <param name="dresidenceLegalUpdatedAt"></param>
        /// <param name="tierLimits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInfo(
            string userId,
            bool avatarConsent,
            bool aiTrainingOptOut,
            string? username,
            string? avatarUrl,
            string? accountTier,
            string? apiAccountTier,
            int? webSubscriptionEnd,
            int? avatarProjectCreditUsed,
            int? avatarProjectCreditLimit,
            int? avatarProjectWebCreditUsed,
            int? avatarProjectWebCreditLimit,
            bool? allowWebCreditOverages,
            int? webCreditOverageMax,
            bool? allowApiCreditOverages,
            int? apiCreditOverageMax,
            string? subscriptionState,
            string? tosAcceptableDate,
            string? tosAcceptedVersion,
            string? apiSubscriptionState,
            bool? apiTOSAcceptance,
            string? marketingEmailConsent,
            string? residenceLegalConfirmed,
            string? dresidenceLegalUpdatedAt,
            global::Hedra.TierLimits? tierLimits)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.AvatarConsent = avatarConsent;
            this.AiTrainingOptOut = aiTrainingOptOut;
            this.Username = username;
            this.AvatarUrl = avatarUrl;
            this.AccountTier = accountTier;
            this.ApiAccountTier = apiAccountTier;
            this.WebSubscriptionEnd = webSubscriptionEnd;
            this.AvatarProjectCreditUsed = avatarProjectCreditUsed;
            this.AvatarProjectCreditLimit = avatarProjectCreditLimit;
            this.AvatarProjectWebCreditUsed = avatarProjectWebCreditUsed;
            this.AvatarProjectWebCreditLimit = avatarProjectWebCreditLimit;
            this.AllowWebCreditOverages = allowWebCreditOverages;
            this.WebCreditOverageMax = webCreditOverageMax;
            this.AllowApiCreditOverages = allowApiCreditOverages;
            this.ApiCreditOverageMax = apiCreditOverageMax;
            this.SubscriptionState = subscriptionState;
            this.TosAcceptableDate = tosAcceptableDate;
            this.TosAcceptedVersion = tosAcceptedVersion;
            this.ApiSubscriptionState = apiSubscriptionState;
            this.ApiTOSAcceptance = apiTOSAcceptance;
            this.MarketingEmailConsent = marketingEmailConsent;
            this.ResidenceLegalConfirmed = residenceLegalConfirmed;
            this.DresidenceLegalUpdatedAt = dresidenceLegalUpdatedAt;
            this.TierLimits = tierLimits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        public UserInfo()
        {
        }
    }
}