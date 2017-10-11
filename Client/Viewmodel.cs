using System.ComponentModel;
using System.Runtime.CompilerServices;
using Client.ClientServiceRef;

namespace Client {
    public class Viewmodel:INotifyPropertyChanged {
        public LogServiceClient Client = new LogServiceClient();

        private string _test;
        public string Test {
            get { return _test; }
            set {
                if (value != _test) {
                    _test = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _id;
        public string Id {
            get { return _id; }
            set {
                if (value != _id) {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _alarm;
        public string Alarm {
            get { return _alarm; }
            set {
                if (value != _alarm) {
                    _alarm = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _name;
        public string Name {
            get { return _name; }
            set {
                if (value != _name) {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _department;
        public string Department {
            get { return _department; }
            set {
                if (value != _department) {
                    _department = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _residential;
        public string Residential {
            get { return _residential; }
            set {
                if (value != _residential) {
                    _residential = value;
                    OnPropertyChanged();
                }
            }
        }

        //Updates the UI when "OnPropertyChanged()" is called from any of the setters above
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //Requests the latest data (string) from the server
        public string GetData() {
            return Client.GetLast();
        }

        //specifies where what part of the string is shown in the UI when the Invoke from MainWindow.xaml.cs is called
        public delegate void UpdateText(string s);
        public void UpdateText2(string message) {
            string[] s = message.Split('\t');
            Id = s[1];
            Alarm = s[2];
            Name = s[3];
            Department = s[4];
            Residential = s[5];
        }
    }
}
