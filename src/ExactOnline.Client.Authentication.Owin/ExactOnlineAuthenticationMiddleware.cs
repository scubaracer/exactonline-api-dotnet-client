using ExactOnline.Client.Authentication.Owin.Provider;
using Microsoft.Owin;
using Microsoft.Owin.Logging;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler;
using Microsoft.Owin.Security.DataProtection;
using Microsoft.Owin.Security.Infrastructure;
using Owin;
using System;
using System.Globalization;
using System.Net.Http;

namespace ExactOnline.Client.Authentication.Owin
{

	public class ExactOnlineAuthenticationMiddleware : AuthenticationMiddleware<ExactOnlineAuthenticationOptions>
	{

		private readonly ILogger _logger;
		private readonly HttpClient _client;

		public ExactOnlineAuthenticationMiddleware(OwinMiddleware next, IAppBuilder app, ExactOnlineAuthenticationOptions options)
			: base(next, options)
		{
			if (String.IsNullOrWhiteSpace(Options.ClientId)) throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "The '{0}' option must be provided.", "ClientId"));
			if (String.IsNullOrWhiteSpace(Options.ClientSecret)) throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, "The '{0}' option must be provided.", "ClientSecret"));

			_logger = app.CreateLogger<ExactOnlineAuthenticationMiddleware>();

			if (Options.Provider == null)
			{
				Options.Provider = new ExactOnlineAuthenticationProvider();
			}
			if (Options.StateDataFormat == null)
			{
				IDataProtector dataProtector = app.CreateDataProtector(typeof(ExactOnlineAuthenticationMiddleware).FullName, Options.AuthenticationType, "v1");
				Options.StateDataFormat = new PropertiesDataFormat(dataProtector);
			}
			if (String.IsNullOrEmpty(Options.SignInAsAuthenticationType))
			{
				Options.SignInAsAuthenticationType = app.GetDefaultSignInAsAuthenticationType();
			}

			_client = new HttpClient(ResolveHttpMessageHandler(Options))
			{
				Timeout = Options.BackchannelTimeout,
				MaxResponseContentBufferSize = 1024 * 1024 //1 Mb)
			};
		}

		protected override AuthenticationHandler<ExactOnlineAuthenticationOptions> CreateHandler()
		{
			return new ExactOnlineAuthenticationHandler(_client,  _logger);
		}

		private static HttpMessageHandler ResolveHttpMessageHandler(ExactOnlineAuthenticationOptions options)
		{
			return new WebRequestHandler();
		}

	}

}
