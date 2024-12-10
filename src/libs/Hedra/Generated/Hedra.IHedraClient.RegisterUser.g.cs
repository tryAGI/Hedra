#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// Register User<br/>
        /// This is the registration endpoint, ported from the golang API.<br/>
        /// However, this is using a new url / path (/v1/user/register instead of /register -- which will end up being:<br/>
        /// /api/v1/user/register<br/>
        /// NOTE: this will automatically trigger creating brevo contacts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.GetUserResponse> RegisterUserAsync(
            global::Hedra.RegisterUserModel request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Register User<br/>
        /// This is the registration endpoint, ported from the golang API.<br/>
        /// However, this is using a new url / path (/v1/user/register instead of /register -- which will end up being:<br/>
        /// /api/v1/user/register<br/>
        /// NOTE: this will automatically trigger creating brevo contacts
        /// </summary>
        /// <param name="residenceNotBlocked"></param>
        /// <param name="tosAccepted"></param>
        /// <param name="tosVersion"></param>
        /// <param name="marketingEmailConsent">
        /// Default Value: NONE
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.GetUserResponse> RegisterUserAsync(
            string residenceNotBlocked,
            bool tosAccepted,
            string tosVersion,
            string? marketingEmailConsent = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}