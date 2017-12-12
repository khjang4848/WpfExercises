namespace WpfDemos
{
    public class CurrencyConverterViewModel : Notifier
    {
        private decimal _euros;
        private decimal _dollars;

        public decimal Euros
        {
            get => _euros;
            set
            {
                _euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        public decimal Dollars
        {
            get => _dollars;
            set
            {
                _dollars = value;
                OnPropertyChanged("Dollars");
            }
        }

        private void OnEurosChanged() => Dollars = Euros * 1.1M;


    }
}
