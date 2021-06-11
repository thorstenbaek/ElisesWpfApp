using Prism.Commands;
using System.ComponentModel;
using System.Windows.Input;

namespace ElisesWpfApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public ICommand SendButtonCommand { get; }

        public MainViewModel(string firstName)
        {
            FirstName = firstName;

            SendButtonCommand = new DelegateCommand(DoSend);
        }

        private void RaisePropertyChanged(string property) 
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void DoSend()
        {
            Title = FirstName;
            RaisePropertyChanged("Title");
        }
    }
}
