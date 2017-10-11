using System.Threading;

namespace Client {
    public partial class MainWindow {
        public Viewmodel Viewmodel;

        public MainWindow() {
            InitializeComponent();
            Viewmodel = new Viewmodel();
            DataContext = Viewmodel;
            
            Thread thread = new Thread(Requester);
            thread.Start();
        }

        //Uses Invoke to get out of Threading so it can update the UI every 5secs
        private void Requester() {
            while (true) {
                Dispatcher.Invoke(new Viewmodel.UpdateText(Viewmodel.UpdateText2), Viewmodel.GetData());
                Thread.Sleep(5000);
            }
        }
    }
}
