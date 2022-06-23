using SpotifyAPI;
using SpotifyAPI.Web;
using System.Threading.Tasks;

namespace SpotifyToVK
{
    static class LoginCheckClass
    {
        
        public static async Task LoginCheck(string track)
        {
            var spotify = new SpotifyClient(Properties.Settings.Default.SpotifyToken_data);

            var _track = await spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
            
        }
    }
}
