using CitizenFX.Core.Native;
using Newtonsoft.Json;
using PostEarthClient.Core;
using System.Threading.Tasks;

/* 
 * TriggerServerEvent("PostEarth.UserAccountService.RequestProfile", "0x5DC", "Password123");
 */

namespace PostEarthClient.System
{
    class ConnectionManager : PostEarthPlugin
    {
        private int TickRate = 1000;

        protected override async Task OnTick()
        {
            if (API.NetworkIsPlayerActive(LocalPlayer.Handle)) 
            {
                API.SendNuiMessage(JsonConvert.SerializeObject(new
                {
                    message = "closeLoadingScreen"
                }));
                API.SendNuiMessage(JsonConvert.SerializeObject(new {
                    message = "openConnectionPortal"
                }));
            }

            await Delay(TickRate); 
        }
    }
}
