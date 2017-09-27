using System.Windows;

namespace Client {
    public partial class MainWindow:Window
    {
        public Viewmodel viewmodel;
        public MainWindow() {
            InitializeComponent();
            viewmodel = new Viewmodel();
            DataContext = viewmodel;
        }

        private void getData_onclick(object sender, RoutedEventArgs e)
        {
            viewmodel.GetData();
        }
    }
}
