
#nullable enable

namespace Hedra
{
    /// <summary>
    /// ## Base URL<br/>
    /// All paths are referenced from the base URL: `https://mercury.dev.dream-ai.com/api`<br/>
    /// ## Example usage<br/>
    /// ### 1. Upload audio<br/>
    /// `audio_response = requests.post(f"{BASE_URL}/v1/audio", headers={'X-API-KEY': API_KEY}, files={'file': open('audio.mp3','rb')})`<br/>
    /// ### 2. Upload image<br/>
    /// `image_response = requests.post(f"{BASE_URL}/v1/portrait", headers={'X-API-KEY': API_KEY}, files={'file': open('img.png','rb')})`<br/>
    /// ### 3. Generate character video<br/>
    /// `video_response = requests.post(f"{BASE_URL}/v1/characters", headers={'X-API-KEY': API_KEY}, json={"avatarImage": image_response.json()["url"], "audioSource": "audio", "voiceUrl": audio_response.json()["url"]})`<br/>
    /// ### 4. Call the Project endpoint to see your project / job status and get access to the URL of your generated character.<br/>
    /// `project_status = requests.get(f"{BASE_URL}/v1/projects/{project_id}", headers={'X-API-KEY': API_KEY})`<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IHedraClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Hedra.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AudioClient Audio { get; }

        /// <summary>
        /// 
        /// </summary>
        public VoiceClient Voice { get; }

        /// <summary>
        /// 
        /// </summary>
        public PortraitClient Portrait { get; }

        /// <summary>
        /// 
        /// </summary>
        public CharactersClient Characters { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

    }
}