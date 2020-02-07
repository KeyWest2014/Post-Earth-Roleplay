using CitizenFX.Core.Native;
using PostEarthClient.Core;
using System.Threading.Tasks;

namespace PostEarthClient.System
{
    class SpawnManager : PostEarthPlugin
    {
        private const int LOADING_TICK_RATE = 1000;
        private const int ALIVE_TICK_RATE = 5000;

        private int TickRate = LOADING_TICK_RATE;

        public SpawnManager() 
        {
        
        }

        protected override void OnStart()
        {
        }

        protected override async Task OnTick() 
        {

            if (API.NetworkIsPlayerActive(LocalPlayer.Handle)) 
            {
                API.ShutdownLoadingScreen();
                TickRate = ALIVE_TICK_RATE;
            }

            await Delay(TickRate); 
        }
    }
}
