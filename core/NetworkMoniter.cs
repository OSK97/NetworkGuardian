using System.Net.NetworkInformation;

namespace NetworkGuardian.Core
{
    public class NetworkMonitor
    {
        public void PrintAllAdapters()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();

            foreach (NetworkInterface adapter in adapters)
            {
                System.Diagnostics.Debug.WriteLine(adapter.Name);
            }
        }
    }
}

