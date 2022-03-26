using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MultiTaskBase.Local.processor;
using Newtonsoft.Json;

namespace MultiTaskBase
{
    internal partial class DataSaver
    {
        string fileName = @"data.json";
        long L1, L2, L3;
        //var json = Newtonsoft.Json.JsonConvert.SerializeObject();

        public void WriteJson()
        {
            WMIprocessor ds = new WMIprocessor();
            ds.GetData();
            Cache.GetPerCoreCacheSizes(out L1, out L2, out L3);
            

            Processor processor = new Processor()
            {
                cpu_Name = ds.name,
                cores = ds.num_Cores,
                logical_cores = ds.num_LogicalCores,
                speed = ds.clock_speed,
                l1 = string.Format("{0} KB", (L1 / 1024) * 6),
                l2 = string.Format("{0:0.0} KB", (L2 / Math.Pow(1024, 2) * 6) + 0.0),
                l3 = string.Format("{0:0.0} KB", (L3 / Math.Pow(1024, 2) * 2) + 0.0)
            };
            string rsJson = JsonConvert.SerializeObject(processor);
            File.WriteAllText(fileName, rsJson);
            Console.WriteLine("Json data created!");
        }
    }
}
