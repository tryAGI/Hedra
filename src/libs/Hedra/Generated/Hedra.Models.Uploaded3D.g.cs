
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Uploaded3D
    {
        /// <summary>
        /// Default Value: uploaded_three_d
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Presigned download URL. For agent-composed assets this is a `.zip` bundle containing the composition + every corpus reference available in S3. For curated corpus rows this is the raw USD file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Extension of the file at `url` — `zip` for composed assets, `usda` / `usdc` / `usdz` for curated corpus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Uploaded3D" /> class.
        /// </summary>
        /// <param name="url">
        /// Presigned download URL. For agent-composed assets this is a `.zip` bundle containing the composition + every corpus reference available in S3. For curated corpus rows this is the raw USD file.
        /// </param>
        /// <param name="fileFormat">
        /// Extension of the file at `url` — `zip` for composed assets, `usda` / `usdc` / `usdz` for curated corpus.
        /// </param>
        /// <param name="type">
        /// Default Value: uploaded_three_d
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Uploaded3D(
            string url,
            string fileFormat,
            string? type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.FileFormat = fileFormat ?? throw new global::System.ArgumentNullException(nameof(fileFormat));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Uploaded3D" /> class.
        /// </summary>
        public Uploaded3D()
        {
        }

    }
}