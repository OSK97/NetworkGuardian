using System.Diagnostics;
using System.Net.NetworkInformation;

namespace NetworkGuardian.Services
{
    public class NetworkMonitor
    {
        public bool IsTpLinkConnected()
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.Name.Equals("tp", StringComparison.OrdinalIgnoreCase))
                {
                    return adapter.OperationalStatus == OperationalStatus.Up;
                }
            }
            return false;
        }
        public bool IsTendaConnected()
        {
            foreach (NetworkInterface adapter in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (adapter.Name.Equals("tenda", StringComparison.OrdinalIgnoreCase))
                {
                    return adapter.OperationalStatus == OperationalStatus.Up;
                }
            }
            return false;
        }
    }
}