using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class ConfigurationManager
    {
        private static readonly object lockObject = new object();
        private static ConfigurationManager instance;

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ConfigurationManager();
                        }
                    }
                }
                return instance;
            }
        }

        public void GetConfiguration()
        {
            Console.WriteLine("Getting configuration...");
        }
    }

    class Program
    {
        static void Main()
        {
            ConfigurationManager config1 = ConfigurationManager.Instance;
            ConfigurationManager config2 = ConfigurationManager.Instance;

            config1.GetConfiguration();

            Console.WriteLine(ReferenceEquals(config1, config2) ? "Same instance" : "Different instances");
        }
    }
}
