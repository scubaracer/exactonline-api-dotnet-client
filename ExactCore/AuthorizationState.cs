using System;
using System.Collections.Generic;
using System.Text;

namespace ExactCore
{
    public class AuthorizationState
    {
        /// <summary>
        /// Gets or sets the callback URL used to obtain authorization.
        /// </summary>
        /// <value>The callback URL.</value>
        public Uri Callback { get; set; }

        /// <summary>
        /// Gets or sets the long-lived token used to renew the short-lived <see cref="P:DotNetOpenAuth.OAuth2.IAuthorizationState.AccessToken" />.
        /// </summary>
        /// <value>The refresh token.</value>
        public string RefreshToken { get; set; }

        /// <summary>Gets or sets the access token.</summary>
        /// <value>The access token.</value>
        public string AccessToken { get; set; }

        /// <summary>Gets or sets the access token issue date UTC.</summary>
        /// <value>The access token issue date UTC.</value>
        public DateTime? AccessTokenIssueDateUtc { get; set; }

        /// <summary>Gets or sets the access token UTC expiration date.</summary>
        public DateTime? AccessTokenExpirationUtc { get; set; }
    }
}
