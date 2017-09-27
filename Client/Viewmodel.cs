using System.ComponentModel;
using System.Runtime.CompilerServices;
using Client.ClientServiceRef;

namespace Client {
    public class Viewmodel :INotifyPropertyChanged {
        LogServiceClient client = new LogServiceClient();
        private string _test = "test";

        public string Test {
            get { return _test; }
            set {
                if (value != _test) {
                    _test = value;
                    OnPropertyChanged();
                }
            }
        }

        public void GetData() {
            Test = client.GetLast();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
