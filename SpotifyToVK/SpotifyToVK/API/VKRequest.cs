using VkNet;
using VkNet.Model;

namespace SpotifyToVK
{
	public static class VKRequest
	{
		public static void LoginVK()
		{
			var api = new VkApi();

			api.Authorize(new ApiAuthParams
			{
				AccessToken = Properties.Settings.Default.VKToken_data
			}); ;
		}
	}
}