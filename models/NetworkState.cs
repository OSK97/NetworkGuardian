using System;
using System.Collections.Generic;
using System.Text;
    
namespace NetworkGuardian.Models
{
    public class NetworkState
    {
        public string? TpLinkName { get; set; }
        public string? TendaName { get; set; }
        public string? WifiDirectName { get; set; }

        public bool TpConnected { get; set; }
        public bool TendaConnected { get; set; }
        public bool WifiDirectAvailable { get; set; }

        public bool InternetAvailable { get; set; }
        public bool HotspotRunning { get; set; }
        public bool RecoveryInProgress { get; set; }
    }
}