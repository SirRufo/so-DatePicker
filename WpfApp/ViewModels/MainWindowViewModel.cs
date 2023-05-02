using System.Collections.ObjectModel;

namespace WpfApp.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ObservableCollection<DateTime> _selectedDateHistory;

        [Reactive] public DateTime SelectedDate { get; set; }
        public ReadOnlyObservableCollection<DateTime> SelectedDateHistory { get; }

        public MainWindowViewModel()
        {
            _selectedDateHistory = new ObservableCollection<DateTime>();
            SelectedDateHistory = new ReadOnlyObservableCollection<DateTime>( _selectedDateHistory );

            SelectedDate = DateTime.Today;
            this.WhenAnyValue( e => e.SelectedDate ).Subscribe( OnDateSelected );
        }

        private void OnDateSelected( DateTime value )
        {
            while ( _selectedDateHistory.Count >= 5 ) _selectedDateHistory.RemoveAt( _selectedDateHistory.Count - 1 );

            _selectedDateHistory.Insert( 0, value );
        }
    }
}