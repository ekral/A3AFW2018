using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Exam
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; OnPropertyChanged();}
        }

        public Command CommandIncrease { get; set; }
        public Command CommandReset { get; set; }
        public Command CommandNavigateToEdit { get; set; }
        
        public CounterViewModel()
        {
            Number = 0;
            CommandIncrease = new Command(Increase);
            CommandReset = new Command(Reset);
            CommandNavigateToEdit = new Command(NavigateToEdit);
        }

        private void Increase()
        {
            ++Number;
        }

        private void Reset()
        {
            Number = 0;
        }

        async private void NavigateToEdit()
        {
            EditPage editPage = new EditPage(this);
            INavigation navigation = Application.Current.MainPage.Navigation;

            await navigation.PushAsync(editPage);
        }
    }
}
