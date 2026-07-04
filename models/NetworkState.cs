using System;
using System.Collections.Generic;
using System.Text;

namespace NetworkGuardian.Models
{
   
}

public class NetworkState
{
    public bool TpConnected { get; set; }
    public bool InternetAvailable { get; set; }
    public bool HotspotRunning { get; set; }
    public bool RecoveryInProgress { get; set; }
}