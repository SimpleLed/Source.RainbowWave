using Newtonsoft.Json;
using SimpleLed;

namespace Source.RainbowWave
{
    public class RainbowWaveConfigModel : SLSConfigData
    {
        private int speed = 3;
        public int Speed
        {
            get => speed;
            set
            {
                SetProperty(ref speed, value);
                DataIsDirty = true;
            }
        }

        private ControlDevice controlDevice;

        [JsonIgnore]
        public ControlDevice CurrentControlDevice
        {
            get => controlDevice;
            set => SetProperty(ref controlDevice, value);
        }
    }
}
