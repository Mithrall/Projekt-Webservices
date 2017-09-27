using System.Windows;
using Client.LogService;

namespace Client {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow:Window
    {
        LogServiceClient client = new LogServiceClient();
        public MainWindow()
        {
            InitializeComponent();
        }


    }
}
