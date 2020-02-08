using System;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace PostEarthServer.Core
{
    class PostEarthPlugin : BaseScript
    {
        private string PluginName   = "???";
        private string ResourceName = "???";

        public PostEarthPlugin() 
        {
            PluginName = this.GetType().Name;
            if (PluginName != "PostEarthPlugin") { 
                EventHandlers["onResourceStart"] += new Action<string>(OnResourceStart);
                EventHandlers["onResourceStop"] += new Action<string>(OnResourceStop);
            }
        }

        private void OnResourceStart(string resourceName)
        {
            if (API.GetCurrentResourceName() != resourceName) return;

            this.ResourceName = resourceName;           
            Tick += OnTick;

            OnStart();

            DebugLog("started succesfully");
        }
        private void OnResourceStop(string resourceName)
        {
            if (API.GetCurrentResourceName() != resourceName) return;

            OnEnd();

            DebugLog("stopped succesfully");
        }

        protected void DebugLog(string log) {
            Debug.WriteLine($"^2[{ResourceName}]^0 {PluginName} {log}^7");
        }

        protected virtual void OnStart() 
        {
        }
        protected virtual void OnEnd()
        {
        }

        protected virtual async Task OnTick()
        {
            Tick -= OnTick;
            await Delay(0);
        }
    }
}
