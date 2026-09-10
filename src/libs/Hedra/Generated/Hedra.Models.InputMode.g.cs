
#nullable enable

namespace Hedra
{
    /// <summary>
    /// A named input mode grouping mutually exclusive input slots.<br/>
    /// Each mode represents a distinct way to use the model (e.g., image_to_video<br/>
    /// vs first_last_frame_to_video). The frontend selects one mode at a time and<br/>
    /// presents only that mode's slots.<br/>
    /// The text_to_video mode (no input files) is always implicitly available<br/>
    /// for VIDEO type models and is never included in the inputs list.<br/>
    /// `aspect_ratios` is the mode's own output menu, which is not the model's<br/>
    /// wherever the media changes it: MiniMax H3 offers six ratios from a prompt,<br/>
    /// none from a start frame, and a seventh (`adaptive`) from reference images.<br/>
    /// A model stamps its `supported_aspect_ratios` onto the modes it declares<br/>
    /// (`VideoModel.declarative_input_modes`, and `ai_models._image_input_modes`<br/>
    /// for image), and `union_variant_inputs` carries each variant's onto the<br/>
    /// family's published entry, so one card states a menu per mode instead of one<br/>
    /// menu per variant.
    /// </summary>
    public sealed partial class InputMode
    {
        /// <summary>
        /// Mode name identifying this input combination (e.g., 'image_to_video', 'first_last_frame_to_video', 'reference_to_video', 'video_to_video').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// Ordered list of input slots available in this mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Hedra.InputSlot> Slots { get; set; }

        /// <summary>
        /// Output aspect ratios offered in this mode, which may differ from the model's. Absent where the mode states none, and where a family's variants declare the same mode with different menus.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratios")]
        public global::System.Collections.Generic.IList<string>? AspectRatios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMode" /> class.
        /// </summary>
        /// <param name="mode">
        /// Mode name identifying this input combination (e.g., 'image_to_video', 'first_last_frame_to_video', 'reference_to_video', 'video_to_video').
        /// </param>
        /// <param name="slots">
        /// Ordered list of input slots available in this mode.
        /// </param>
        /// <param name="aspectRatios">
        /// Output aspect ratios offered in this mode, which may differ from the model's. Absent where the mode states none, and where a family's variants declare the same mode with different menus.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InputMode(
            string mode,
            global::System.Collections.Generic.IList<global::Hedra.InputSlot> slots,
            global::System.Collections.Generic.IList<string>? aspectRatios)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.Slots = slots ?? throw new global::System.ArgumentNullException(nameof(slots));
            this.AspectRatios = aspectRatios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputMode" /> class.
        /// </summary>
        public InputMode()
        {
        }

    }
}