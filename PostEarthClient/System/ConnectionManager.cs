using CitizenFX.Core.Native;
using PostEarthClient.Core;
using System.Threading.Tasks;

namespace PostEarthClient.System
{
    class ConnectionManager : PostEarthPlugin
    {
        private const int LOADING_TICK_RATE = 1000;
        private const int ALIVE_TICK_RATE = 5000;

        private int TickRate = LOADING_TICK_RATE;

        public ConnectionManager() 
        {
        
        }

        private void RequestUserProfile() 
        {
            TriggerServerEvent("PostEarth.UserAccountService.RequestProfile", "0x5DC", "Password123");
        }

        protected override void OnStart()
        {
        }

        private bool hasSent = false;

        protected override async Task OnTick() 
        {
            if (!hasSent) {
                hasSent = true;
                RequestUserProfile();
            }
            await Delay(TickRate); 
        }
    }
}
