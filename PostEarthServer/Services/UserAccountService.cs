using CitizenFX.Core;
using PostEarthServer.Core;
using System;

namespace PostEarthServer.Services
{
    class UserAccountService : PostEarthPlugin
    {
        protected override void OnStart() 
        {
            EventHandlers["PostEarth.UserAccountService.RequestProfile"] += new Action<Player, string, string>(RequestUserProfile);
        }

        private void RequestUserProfile([FromSource] Player source, string username, string hash)
        {
            DebugLog($"Login attempt from [IP: {source.Identifiers["ip"]}, Steam: {source.Identifiers["steam"]}, License: {source.Identifiers["license"]}], username: {username}, hash: ************.");
        }
    }
}
