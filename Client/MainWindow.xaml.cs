using System.Threading;
using System.Windows;

namespace Client {
    public partial class MainWindow:Window {
        public Viewmodel Viewmodel;

        public MainWindow() {
            InitializeComponent();
            Viewmodel = new Viewmodel();
            DataContext = Viewmodel;
            
            Thread thread = new Thread(Requester);
            thread.Start();
        }

        private void Requester() {
            while (true) {
                Dispatcher.Invoke(new Viewmodel.UpdateText(Viewmodel.UpdateText2), Viewmodel.GetData());
                Thread.Sleep(5000);
            }
        }
    }
}
