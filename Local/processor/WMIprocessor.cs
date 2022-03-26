using System;
using System.Linq;
using System.Management;

namespace MultiTaskBase.Local.processor
{
    internal class WMIprocessor
    {
        public string name;
        public int num_Cores;
        public int num_LogicalCores;
        public string clock_speed;

        public void GetData()
        {
            Query();
        }
        private void Query()
        {
            try
            {
                ManagementObjectSearcher mosuc = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                    foreach (ManagementObject obj in mosuc.Get())
                    {
                        name = (string)obj["Name"];
                        num_Cores = Convert.ToInt32(obj["NumberOfCores"]);
                        num_LogicalCores = Convert.ToInt32(obj["NumberOfLogicalProcessors"]);
                        clock_speed = string.Format("{0:0.00} GHz", Convert.ToInt32(obj["CurrentClockSpeed"]) / 1000.0);
                    }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"{name}\n{num_Cores}\n{num_LogicalCores}\n{clock_speed}");
        }
    }
}
