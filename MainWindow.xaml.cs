using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NetworkGuardian.Services;

namespace NetworkGuardian
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NetworkMonitor monitor = new NetworkMonitor();
            if (monitor.IsTpLinkConnected())
            {
                TpStatus.Text = "TP-Link : 🟢 Connected";
            }
            else
            {
                TpStatus.Text = "TP-Link : 🔴 Disconnected";
            }
            if (monitor.IsTendaConnected())
            {
                TendaStatus.Text = "Tenda : 🟢 Connected";
            }
            else
            {
                TendaStatus.Text = "Tenda : 🔴 Disconnected";
            }
        }
    }
}