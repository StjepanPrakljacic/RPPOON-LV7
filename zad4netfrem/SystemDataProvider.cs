using System;
using System.Collections.Generic;
using System.Text;

namespace zad4netfrem
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
           if (Math.Abs(1.0 - this.previousCPULoad / currentLoad) > 0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentLoad = this.AvailableRAM;
            if (Math.Abs(1.0 - this.previousRAMAvailable / currentLoad) > 0.1)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentLoad;
            return currentLoad;

        }
    }
}
