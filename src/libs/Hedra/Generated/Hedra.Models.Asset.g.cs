
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Asset
    {
        /// <summary>
        /// The id of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// The type of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AssetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.AssetType Type { get; set; } = default!;

        /// <summary>
        /// Name of the asset. Default to user-provided file name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// URL of the thumbnail image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thumbnail_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ThumbnailUrl { get; set; } = default!;

        /// <summary>
        /// Optional description of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the asset is favorited by the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Whether this asset was recently used by the user.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent")]
        public bool? Recent { get; set; }

        /// <summary>
        /// Date the asset was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Date the asset was favorited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("favorited_at")]
        public string? FavoritedAt { get; set; }

        /// <summary>
        /// The asset itself.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.Asset1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.Asset1 Asset1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the asset.
        /// </param>
        /// <param name="type">
        /// The type of the asset.
        /// </param>
        /// <param name="name">
        /// Name of the asset. Default to user-provided file name.
        /// </param>
        /// <param name="thumbnailUrl">
        /// URL of the thumbnail image.
        /// </param>
        /// <param name="description">
        /// Optional description of the asset.
        /// </param>
        /// <param name="isFavorite">
        /// Whether the asset is favorited by the user.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="recent">
        /// Whether this asset was recently used by the user.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="createdAt">
        /// Date the asset was created.
        /// </param>
        /// <param name="favoritedAt">
        /// Date the asset was favorited.
        /// </param>
        /// <param name="asset1">
        /// The asset itself.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Asset(
            global::System.Guid id,
            global::Hedra.AssetType type,
            string name,
            string thumbnailUrl,
            string createdAt,
            global::Hedra.Asset1 asset1,
            string? description,
            bool? isFavorite,
            bool? recent,
            string? favoritedAt)
        {
            this.Id = id;
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ThumbnailUrl = thumbnailUrl ?? throw new global::System.ArgumentNullException(nameof(thumbnailUrl));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Asset1 = asset1;
            this.Description = description;
            this.IsFavorite = isFavorite;
            this.Recent = recent;
            this.FavoritedAt = favoritedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Asset" /> class.
        /// </summary>
        public Asset()
        {
        }
    }
}