
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupportedLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Chinese,
        /// <summary>
        /// 
        /// </summary>
        Chinese_Yue,
        /// <summary>
        /// 
        /// </summary>
        English,
        /// <summary>
        /// 
        /// </summary>
        Arabic,
        /// <summary>
        /// 
        /// </summary>
        Russian,
        /// <summary>
        /// 
        /// </summary>
        Spanish,
        /// <summary>
        /// 
        /// </summary>
        French,
        /// <summary>
        /// 
        /// </summary>
        Portuguese,
        /// <summary>
        /// 
        /// </summary>
        German,
        /// <summary>
        /// 
        /// </summary>
        Turkish,
        /// <summary>
        /// 
        /// </summary>
        Dutch,
        /// <summary>
        /// 
        /// </summary>
        Ukrainian,
        /// <summary>
        /// 
        /// </summary>
        Vietnamese,
        /// <summary>
        /// 
        /// </summary>
        Indonesian,
        /// <summary>
        /// 
        /// </summary>
        Japanese,
        /// <summary>
        /// 
        /// </summary>
        Italian,
        /// <summary>
        /// 
        /// </summary>
        Korean,
        /// <summary>
        /// 
        /// </summary>
        Thai,
        /// <summary>
        /// 
        /// </summary>
        Polish,
        /// <summary>
        /// 
        /// </summary>
        Romanian,
        /// <summary>
        /// 
        /// </summary>
        Greek,
        /// <summary>
        /// 
        /// </summary>
        Czech,
        /// <summary>
        /// 
        /// </summary>
        Finnish,
        /// <summary>
        /// 
        /// </summary>
        Hindi,
        /// <summary>
        /// 
        /// </summary>
        Bulgarian,
        /// <summary>
        /// 
        /// </summary>
        Danish,
        /// <summary>
        /// 
        /// </summary>
        Hebrew,
        /// <summary>
        /// 
        /// </summary>
        Malay,
        /// <summary>
        /// 
        /// </summary>
        Persian,
        /// <summary>
        /// 
        /// </summary>
        Slovak,
        /// <summary>
        /// 
        /// </summary>
        Swedish,
        /// <summary>
        /// 
        /// </summary>
        Croatian,
        /// <summary>
        /// 
        /// </summary>
        Filipino,
        /// <summary>
        /// 
        /// </summary>
        Hungarian,
        /// <summary>
        /// 
        /// </summary>
        Norwegian,
        /// <summary>
        /// 
        /// </summary>
        Slovenian,
        /// <summary>
        /// 
        /// </summary>
        Catalan,
        /// <summary>
        /// 
        /// </summary>
        Nynorsk,
        /// <summary>
        /// 
        /// </summary>
        Tamil,
        /// <summary>
        /// 
        /// </summary>
        Afrikaans,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SupportedLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedLanguage value)
        {
            return value switch
            {
                SupportedLanguage.Chinese => "Chinese",
                SupportedLanguage.Chinese_Yue => "Chinese,Yue",
                SupportedLanguage.English => "English",
                SupportedLanguage.Arabic => "Arabic",
                SupportedLanguage.Russian => "Russian",
                SupportedLanguage.Spanish => "Spanish",
                SupportedLanguage.French => "French",
                SupportedLanguage.Portuguese => "Portuguese",
                SupportedLanguage.German => "German",
                SupportedLanguage.Turkish => "Turkish",
                SupportedLanguage.Dutch => "Dutch",
                SupportedLanguage.Ukrainian => "Ukrainian",
                SupportedLanguage.Vietnamese => "Vietnamese",
                SupportedLanguage.Indonesian => "Indonesian",
                SupportedLanguage.Japanese => "Japanese",
                SupportedLanguage.Italian => "Italian",
                SupportedLanguage.Korean => "Korean",
                SupportedLanguage.Thai => "Thai",
                SupportedLanguage.Polish => "Polish",
                SupportedLanguage.Romanian => "Romanian",
                SupportedLanguage.Greek => "Greek",
                SupportedLanguage.Czech => "Czech",
                SupportedLanguage.Finnish => "Finnish",
                SupportedLanguage.Hindi => "Hindi",
                SupportedLanguage.Bulgarian => "Bulgarian",
                SupportedLanguage.Danish => "Danish",
                SupportedLanguage.Hebrew => "Hebrew",
                SupportedLanguage.Malay => "Malay",
                SupportedLanguage.Persian => "Persian",
                SupportedLanguage.Slovak => "Slovak",
                SupportedLanguage.Swedish => "Swedish",
                SupportedLanguage.Croatian => "Croatian",
                SupportedLanguage.Filipino => "Filipino",
                SupportedLanguage.Hungarian => "Hungarian",
                SupportedLanguage.Norwegian => "Norwegian",
                SupportedLanguage.Slovenian => "Slovenian",
                SupportedLanguage.Catalan => "Catalan",
                SupportedLanguage.Nynorsk => "Nynorsk",
                SupportedLanguage.Tamil => "Tamil",
                SupportedLanguage.Afrikaans => "Afrikaans",
                SupportedLanguage.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedLanguage? ToEnum(string value)
        {
            return value switch
            {
                "Chinese" => SupportedLanguage.Chinese,
                "Chinese,Yue" => SupportedLanguage.Chinese_Yue,
                "English" => SupportedLanguage.English,
                "Arabic" => SupportedLanguage.Arabic,
                "Russian" => SupportedLanguage.Russian,
                "Spanish" => SupportedLanguage.Spanish,
                "French" => SupportedLanguage.French,
                "Portuguese" => SupportedLanguage.Portuguese,
                "German" => SupportedLanguage.German,
                "Turkish" => SupportedLanguage.Turkish,
                "Dutch" => SupportedLanguage.Dutch,
                "Ukrainian" => SupportedLanguage.Ukrainian,
                "Vietnamese" => SupportedLanguage.Vietnamese,
                "Indonesian" => SupportedLanguage.Indonesian,
                "Japanese" => SupportedLanguage.Japanese,
                "Italian" => SupportedLanguage.Italian,
                "Korean" => SupportedLanguage.Korean,
                "Thai" => SupportedLanguage.Thai,
                "Polish" => SupportedLanguage.Polish,
                "Romanian" => SupportedLanguage.Romanian,
                "Greek" => SupportedLanguage.Greek,
                "Czech" => SupportedLanguage.Czech,
                "Finnish" => SupportedLanguage.Finnish,
                "Hindi" => SupportedLanguage.Hindi,
                "Bulgarian" => SupportedLanguage.Bulgarian,
                "Danish" => SupportedLanguage.Danish,
                "Hebrew" => SupportedLanguage.Hebrew,
                "Malay" => SupportedLanguage.Malay,
                "Persian" => SupportedLanguage.Persian,
                "Slovak" => SupportedLanguage.Slovak,
                "Swedish" => SupportedLanguage.Swedish,
                "Croatian" => SupportedLanguage.Croatian,
                "Filipino" => SupportedLanguage.Filipino,
                "Hungarian" => SupportedLanguage.Hungarian,
                "Norwegian" => SupportedLanguage.Norwegian,
                "Slovenian" => SupportedLanguage.Slovenian,
                "Catalan" => SupportedLanguage.Catalan,
                "Nynorsk" => SupportedLanguage.Nynorsk,
                "Tamil" => SupportedLanguage.Tamil,
                "Afrikaans" => SupportedLanguage.Afrikaans,
                "auto" => SupportedLanguage.Auto,
                _ => null,
            };
        }
    }
}