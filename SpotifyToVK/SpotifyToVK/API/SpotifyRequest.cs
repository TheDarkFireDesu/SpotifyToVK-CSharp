using SpotifyAPI.Web;
using SpotifyAPI.Web.Auth;
using System;
using System.Threading.Tasks;

namespace SpotifyToVK
{
	public static class SpotifyRequest
	{
		public static async Task LoginSpotify()
		{
			var _clientId = Properties.Settings.Default.ClientID_data;
			var _secretId = Properties.Settings.Default.SecretID_data;

			var config = SpotifyClientConfig.CreateDefault();
			var server = new EmbedIOAuthServer(new Uri("http://localhost:8888/callback"), 8888);

			server.AuthorizationCodeReceived += async (sender, response) =>
			{
				await server.Stop();
				var tokenResponse = await new OAuthClient(config).RequestToken(new AuthorizationCodeTokenRequest(
				  _clientId, _secretId, response.Code, server.BaseUri
				));

				var spotify = new SpotifyClient(config.WithToken(tokenResponse.AccessToken));
			};

			await server.Start();

			var loginRequest = new LoginRequest(server.BaseUri, _clientId, LoginRequest.ResponseType.Code)
			{
				Scope = new[] { Scopes.PlaylistReadPrivate, Scopes.PlaylistReadCollaborative }
			};
			BrowserUtil.Open(loginRequest.ToUri());
		}
	}
}