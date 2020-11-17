using Newtonsoft.Json;
using SimpleLed;

namespace Source.RainbowWave
{
    public class RainbowWaveConfigModel : SLSConfigData
    {
        private double speed = 3.0;
        public double Speed
        {
            get => speed;
            set
            {
                SetProperty(ref speed, value);
                DataIsDirty = true;
            }
        }

        private bool reverseDirection = false;

        public bool ReverseDirection
        {
            get => reverseDirection;
            set
            {
                SetProperty(ref reverseDirection, value);
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
